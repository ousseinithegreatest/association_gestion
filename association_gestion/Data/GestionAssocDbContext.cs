using association_gestion.Models.Domain;
using association_gestion.Models;

using Microsoft.EntityFrameworkCore;

namespace association_gestion.Data
{
    public class GestionAssocDbContext : DbContext
    {
        public GestionAssocDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Association> Associations { get; set; }
        public DbSet<Activite> Activites { get; set; }

    }
}
