using Entity.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-FL2FF7V; Database=OyunBilgi2; Trusted_Connection=true");
        }
        public DbSet<Game> Oyunlar { get; set; }
        public DbSet<info> Bilgiler { get; set; }

    }
}
