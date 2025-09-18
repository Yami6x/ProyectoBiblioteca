using System;

namespace FullBiblioteca.Nucleo.Entidades
{
  
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Pais()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
