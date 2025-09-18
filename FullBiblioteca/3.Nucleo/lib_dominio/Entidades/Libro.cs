using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Libro()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
