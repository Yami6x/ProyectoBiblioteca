using System;

namespace FullBiblioteca.Nucleo.Entidades
{
   
    public class Prestamo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Prestamo()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
