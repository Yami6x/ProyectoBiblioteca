using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Servicios
{
    public class EditorialServicioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Servicio_Editorial_Validacion")]
        public void Servicio_Editorial_Validacion()
        {
            var opts = CrearOpciones("Editorialsvcdb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new EditorialRepositorio(contexto);
                var servicio = new EditorialServicio(repo);

                var entidad = new Editorial { Nombre = "Valido" };
                var creado = servicio.AgregarConValidacion(entidad);
                Assert.True(creado.Id != 0);

                var malo = new Editorial { Nombre = "a" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(malo));

                var vacio = new Editorial { Nombre = "" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(vacio));
            }
        }
    }
}
