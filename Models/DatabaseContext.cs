using Microsoft.EntityFrameworkCore;

namespace BookDB.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public string DatabasePath { get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
            this.DatabasePath = System.IO.Path.Join(Environment.CurrentDirectory, "BookDB.db");
        }
        
        // Aceasta functie este necesara pentru a permite initializarea unui DatabaseContext si prin metoda clasica folosind = new.
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={this.DatabasePath}");
    }
}