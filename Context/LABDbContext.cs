using labclothingcollectionbd.Models;
using Microsoft.EntityFrameworkCore;

namespace labclothingcollectionbd.Context
{
    public class LABDbContext: DbContext
    {
        public LABDbContext(DbContextOptions<LABDbContext> options) : base(options) { }
        public LABDbContext() { }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("LABClothingCollection");
            }
        }
    }
}
