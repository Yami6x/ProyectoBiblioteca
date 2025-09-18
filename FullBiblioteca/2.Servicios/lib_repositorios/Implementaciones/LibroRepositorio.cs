using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class LibroRepositorio : IRepositorio<Libro>
    {
        private readonly FullBibliotecaContexto _contexto;

        public LibroRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Libro Agregar(Libro entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Libro>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Libro>().Find(id);
            if (e == null) return false;
            _contexto.Set<Libro>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Libro ObtenerPorId(int id) => _contexto.Set<Libro>().Find(id);

        public IEnumerable<Libro> ObtenerTodos() => _contexto.Set<Libro>().AsNoTracking().ToList();

        public Libro Actualizar(Libro entidad)
        {
            var existente = _contexto.Set<Libro>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
