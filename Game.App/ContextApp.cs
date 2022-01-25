using System;
using Microsoft.EntityFrameworkCore;

namespace Game.App
{
    public class ContextApp : DbContext
    {

        public DbSet<Game> Games { get; set; }

        public ContextApp()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GameDB;Trusted_Connection=True;");
        }
    }
}
