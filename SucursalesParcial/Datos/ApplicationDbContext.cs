using Microsoft.EntityFrameworkCore;
using SucursalesParcial.Models;


namespace SucursalesParcial.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Sucursal> Sucursal { get; set; }
    }
}