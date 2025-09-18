using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Implementaciones;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Pruebas.Repositorios
{
    public class AutorRepositorioPruebas
    {
        private DbContextOptions<FullBibliotecaContexto> CrearOpciones(string dbName)
        {
            return new DbContextOptionsBuilder<FullBibliotecaContexto>()
                .UseInMemoryDatabase(dbName)
                .Options;
        }

        [Fact(DisplayName = "Repositorio_Autor_CRUD")]
        public void Repositorio_Autor_CRUD()
        {
            var opts = CrearOpciones("Autordb" + Guid.NewGuid());

            using (var contexto = new FullBibliotecaContexto(opts))
            {
                var repo = new AutorRepositorio(contexto);

                var entidad = new Autor { Nombre = "Prueba Autor" };
                var creado = repo.Agregar(entidad);
                Assert.True(creado.Id != 0);

                var obtenido = repo.ObtenerPorId(creado.Id);
                Assert.NotNull(obtenido);
                Assert.Equal("Prueba Autor", obtenido.Nombre);

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
