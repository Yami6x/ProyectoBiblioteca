using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Servicios
{
    public class PagoServicioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Servicio_Pago_Validacion")]
        public void Servicio_Pago_Validacion()
        {
            var opts = CrearOpciones("Pagosvcdb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new PagoRepositorio(contexto);
                var servicio = new PagoServicio(repo);

                var entidad = new Pago { Nombre = "Valido" };
                var creado = servicio.AgregarConValidacion(entidad);
                Assert.True(creado.Id != 0);

                var malo = new Pago { Nombre = "a" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(malo));

                var vacio = new Pago { Nombre = "" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(vacio));
            }
        }
    }
}
