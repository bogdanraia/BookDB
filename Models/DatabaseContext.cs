using Microsoft.EntityFrameworkCore;

namespace BookDB.Models

{
    public class DatabaseContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<BookType> BookTypes { get; set; }

        public string DatabasePath { get; }

        public DatabaseContext() {
            var folderPath = Environment.CurrentDirectory;
            this.DatabasePath = System.IO.Path.Join(folderPath, "BookDB.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={this.DatabasePath}");
    }
}