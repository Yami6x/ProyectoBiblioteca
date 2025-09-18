using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class EditorialRepositorio : IRepositorio<Editorial>
    {
        private readonly FullBibliotecaContexto _contexto;

        public EditorialRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Editorial Agregar(Editorial entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Editorial>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Editorial>().Find(id);
            if (e == null) return false;
            _contexto.Set<Editorial>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Editorial ObtenerPorId(int id) => _contexto.Set<Editorial>().Find(id);

        public IEnumerable<Editorial> ObtenerTodos() => _contexto.Set<Editorial>().AsNoTracking().ToList();

        public Editorial Actualizar(Editorial entidad)
        {
            var existente = _contexto.Set<Editorial>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
