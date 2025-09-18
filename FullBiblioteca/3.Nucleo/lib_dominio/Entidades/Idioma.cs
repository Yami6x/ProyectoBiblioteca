using System;

namespace FullBiblioteca.Nucleo.Entidades
{
   
    public class Idioma
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Idioma()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
