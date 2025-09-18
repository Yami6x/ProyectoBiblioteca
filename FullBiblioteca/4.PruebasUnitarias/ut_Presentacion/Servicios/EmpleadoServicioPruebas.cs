using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Servicios
{
    public class EmpleadoServicioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Servicio_Empleado_Validacion")]
        public void Servicio_Empleado_Validacion()
        {
            var opts = CrearOpciones("Empleadosvcdb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new EmpleadoRepositorio(contexto);
                var servicio = new EmpleadoServicio(repo);

                var entidad = new Empleado { Nombre = "Valido" };
                var creado = servicio.AgregarConValidacion(entidad);
                Assert.True(creado.Id != 0);

                var malo = new Empleado { Nombre = "a" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(malo));

                var vacio = new Empleado { Nombre = "" };
                Assert.Throws<ArgumentException>(() => servicio.AgregarConValidacion(vacio));
            }
        }
    }
}
