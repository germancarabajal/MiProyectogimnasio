using Microsoft.EntityFrameworkCore;
using MiProyectogimnasio.Models;

namespace MiProyectogimnasio.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Socio> Socios { get; set; }
        public DbSet<Clase> Clases { get; set; }
      
    }

}
