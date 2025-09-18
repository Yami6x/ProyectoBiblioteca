using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Servicios
{
    public class CiudadServicioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Servicio_Ciudad_Validacion")]
        public void Servicio_Ciudad_Validacion()
        {
            var opts = CrearOpciones("Ciudadsvcdb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new CiudadRepositorio(contexto);
                var servicio = new CiudadServicio(repo);

                var entidad = new Ciudad { Nombre = "Valido" };
                var creado = servicio.AgregarConValidacion(entidad);
                Assert.True(creado.Id != 0);

                var malo = new Ciudad { Nombre = "a" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(malo));

                var vacio = new Ciudad { Nombre = "" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(vacio));
            }
        }
    }
}
