using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Reserva
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Reserva()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
