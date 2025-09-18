using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class CategoriaRepositorio : IRepositorio<Categoria>
    {
        private readonly FullBibliotecaContexto _contexto;

        public CategoriaRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Categoria Agregar(Categoria entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Categoria>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Categoria>().Find(id);
            if (e == null) return false;
            _contexto.Set<Categoria>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Categoria ObtenerPorId(int id) => _contexto.Set<Categoria>().Find(id);

        public IEnumerable<Categoria> ObtenerTodos() => _contexto.Set<Categoria>().AsNoTracking().ToList();

        public Categoria Actualizar(Categoria entidad)
        {
            var existente = _contexto.Set<Categoria>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
