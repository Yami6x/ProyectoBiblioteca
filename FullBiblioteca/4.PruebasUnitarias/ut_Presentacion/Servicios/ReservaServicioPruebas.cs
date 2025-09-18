using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Servicios
{
    public class ReservaServicioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Servicio_Reserva_Validacion")]
        public void Servicio_Reserva_Validacion()
        {
            var opts = CrearOpciones("Reservasvcdb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new ReservaRepositorio(contexto);
                var servicio = new ReservaServicio(repo);

                var entidad = new Reserva { Nombre = "Valido" };
                var creado = servicio.AgregarConValidacion(entidad);
                Assert.True(creado.Id != 0);

                var malo = new Reserva { Nombre = "a" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(malo));

                var vacio = new Reserva { Nombre = "" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(vacio));
            }
        }
    }
}
