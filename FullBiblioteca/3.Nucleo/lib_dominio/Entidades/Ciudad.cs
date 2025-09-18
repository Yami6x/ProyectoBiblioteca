using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Ciudad()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
