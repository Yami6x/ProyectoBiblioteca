using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Sucursal()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
