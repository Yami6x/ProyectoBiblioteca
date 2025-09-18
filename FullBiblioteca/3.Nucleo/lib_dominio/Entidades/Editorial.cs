using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Editorial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Editorial()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
