using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Empleado()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
