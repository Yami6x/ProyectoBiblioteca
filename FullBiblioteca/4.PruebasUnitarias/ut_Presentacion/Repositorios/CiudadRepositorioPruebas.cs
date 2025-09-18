using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Repositorios
{
    public class CiudadRepositorioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Repositorio_Ciudad_CRUD")]
        public void Repositorio_Ciudad_CRUD()
        {
            var opts = CrearOpciones("Ciudaddb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new CiudadRepositorio(contexto);

                var entidad = new Ciudad { Nombre = "Prueba Ciudad" };
                var creado = repo.Agregar(entidad);
                Assert.True(creado.Id != 0);

                var obtenido = repo.ObtenerPorId(creado.Id);
                Assert.NotNull(obtenido);
                Assert.Equal("Prueba Ciudad", obtenido.Nombre);

                creado.Nombre = "Modificado";
                var actualizado = repo.Actualizar(creado);
                Assert.Equal("Modificado", actualizado.Nombre);

                var todos = repo.ObtenerTodos();
                Assert.Contains(todos, x => x.Id == creado.Id);

                var eliminado = repo.Eliminar(creado.Id);
                Assert.True(eliminado);
            }
        }
    }
}
