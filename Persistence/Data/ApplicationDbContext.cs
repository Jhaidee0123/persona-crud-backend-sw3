using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PersonaEntity> Personas { get; set; }
        public DbSet<TipoDocumentoIdentidadEntity> TiposDocumentoIdentidad { get; set; }
    }
}
