using AppHero.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;

namespace AppHero.Context
{
    public class DBHerosContext : DbContext
    {
        public DBHerosContext()
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=DPPP-RTR\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Hero> Heros { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Power> Powers { get; set; }
    }
}