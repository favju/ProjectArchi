using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Purse> Purses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjectDemo");
        }
    }
}
