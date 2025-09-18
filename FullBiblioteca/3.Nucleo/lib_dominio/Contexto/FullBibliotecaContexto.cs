using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Entidades;

namespace FullBiblioteca.Nucleo.Contexto
{
    
    public class FullBibliotecaContexto : DbContext
    {
        public FullBibliotecaContexto(DbContextOptions<FullBibliotecaContexto> opciones) : base(opciones) { }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ciudad> Ciudads { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Pais> Paiss { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
