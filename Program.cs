using BookDB.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
// Adaugam DatabaseContext ca serviciu in service provider-ul din ASP.
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite($"Data Source={System.IO.Path.Join(Environment.CurrentDirectory, "BookDB.db")}"));

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
    pattern: "{controller}/{action=GetAll}/{id?}");

app.MapFallbackToFile("index.html"); 

/** DB Testing Code. */


using var db = new DatabaseContext(new DbContextOptionsBuilder<DatabaseContext>().Options);

Console.WriteLine($"Database Path: {db.DatabasePath}");

// db.Database.ExecuteSqlRaw("delete from Authors");

Console.WriteLine("Inserting 3 new authors...");
db.Add(new Author { AuthorName = "FirstName1", BirthDate = new DateTime(1998, 1, 8)});
db.Add(new Author { AuthorName = "FirstName2", BirthDate = new DateTime(1999, 1, 8) });
db.Add(new Author { AuthorName = "FirstName3", BirthDate = new DateTime(2000, 1, 8) });
db.SaveChanges();


Console.WriteLine("Reading all authors...");
var authors = db.Authors;
for(int i = 0; i < authors.ToArray().Length; ++i) {
    Console.WriteLine($"Author { i + 1 }: { authors.ToArray().ElementAt(i).AuthorName} { authors.ToArray().ElementAt(i).BirthDate} ");
}


Console.WriteLine("Updating first author to 4...");
var author = authors.First();
author.AuthorName = "FirstName4";
db.SaveChanges();

Console.WriteLine("Reading all authors again...");
authors = db.Authors;
for (int i = 0; i < authors.ToArray().Length; ++i) {
    Console.WriteLine($"Author {i + 1}: {authors.ToArray().ElementAt(i).AuthorName} {authors.ToArray().ElementAt(i).BirthDate} ");
}

Console.WriteLine("Deleting all authors...");
db.Authors.RemoveRange(authors);
db.SaveChanges();

Console.WriteLine("Reading all authors one last time...");
authors = db.Authors;
for (int i = 0; i < authors.ToArray().Length; ++i) {
    Console.WriteLine($"Author {i + 1}: {authors.ToArray().ElementAt(i).AuthorName} {authors.ToArray().ElementAt(i).BirthDate} ");
}

db.Dispose();


/** End DB Testing Code. */

app.Run();