using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Repositorios
{
    public class LibroRepositorioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Repositorio_Libro_CRUD")]
        public void Repositorio_Libro_CRUD()
        {
            var opts = CrearOpciones("Librodb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new LibroRepositorio(contexto);

                var entidad = new Libro { Nombre = "Prueba Libro" };
                var creado = repo.Agregar(entidad);
                Assert.True(creado.Id != 0);

                var obtenido = repo.ObtenerPorId(creado.Id);
                Assert.NotNull(obtenido);
                Assert.Equal("Prueba Libro", obtenido.Nombre);

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
