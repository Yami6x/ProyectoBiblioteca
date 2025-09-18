using System;

namespace FullBiblioteca.Nucleo.Entidades
{
    
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Categoria()
        {
            FechaRegistro = DateTime.UtcNow;
        }
    }
}
