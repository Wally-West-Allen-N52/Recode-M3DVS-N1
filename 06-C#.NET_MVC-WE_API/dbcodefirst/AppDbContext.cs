using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dbcodefirst
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FVCFDK;" + "Initial Catalog=EFCoreDB;Integrated Security=True");
        }
    }
}