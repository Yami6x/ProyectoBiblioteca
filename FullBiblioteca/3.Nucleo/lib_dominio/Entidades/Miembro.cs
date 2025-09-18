using System;

namespace FullBiblioteca.Nucleo.Entidades
{
   
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Miembro()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
