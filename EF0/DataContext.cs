using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF0
{
    internal class DataContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Trabajo> Trabajos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;database=ef0;user=root;password=ljac1978");
        }
    }
}
