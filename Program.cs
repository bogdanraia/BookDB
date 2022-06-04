using BookDB.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

/** DB Testing Code. */

using var db = new DatabaseContext();

Console.WriteLine($"Database Path: {db.DatabasePath}");

Console.WriteLine("Inserting 3 new authors...");
db.Add(new Author { AuthorFirstName = "FirstName1", AuthorLastName = "LastName1" });
db.Add(new Author { AuthorFirstName = "FirstName2", AuthorLastName = "LastName2" });
db.Add(new Author { AuthorFirstName = "FirstName3", AuthorLastName = "LastName3" });
db.SaveChanges();

Console.WriteLine("Reading all authors...");
var authors = db.Authors;
for(int i = 0; i < authors.ToArray().Length; ++i) {
    Console.WriteLine($"Author { i + 1 }: { authors.ToArray().ElementAt(i).AuthorFirstName } {authors.ToArray().ElementAt(i).AuthorLastName}");
}

Console.WriteLine("Updating first author to 4...");
var author = authors.First();
author.AuthorFirstName = "FirstName4";
author.AuthorLastName = "LastName4";
db.SaveChanges();

Console.WriteLine("Reading all authors again...");
authors = db.Authors;
for (int i = 0; i < authors.ToArray().Length; ++i) {
    Console.WriteLine($"Author {i + 1}: {authors.ToArray().ElementAt(i).AuthorFirstName} {authors.ToArray().ElementAt(i).AuthorLastName}");
}

Console.WriteLine("Deleting all authors...");
db.Authors.RemoveRange(authors);
db.SaveChanges();

Console.WriteLine("Reading all authors one last time...");
authors = db.Authors;
for (int i = 0; i < authors.ToArray().Length; ++i) {
    Console.WriteLine($"Author {i + 1}: {authors.ToArray().ElementAt(i).AuthorFirstName} {authors.ToArray().ElementAt(i).AuthorLastName}");
}

db.Dispose();

/** End DB Testing Code. */

app.Run();