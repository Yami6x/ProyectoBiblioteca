using System;

namespace FullBiblioteca.Nucleo.Entidades
{
  
    public class Pago
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Pago()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
