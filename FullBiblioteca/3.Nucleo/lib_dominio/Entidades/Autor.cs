using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Autor()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
