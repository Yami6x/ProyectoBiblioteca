using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class PrestamoRepositorio : IRepositorio<Prestamo>
    {
        private readonly FullBibliotecaContexto _contexto;

        public PrestamoRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Prestamo Agregar(Prestamo entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Prestamo>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Prestamo>().Find(id);
            if (e == null) return false;
            _contexto.Set<Prestamo>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Prestamo ObtenerPorId(int id) => _contexto.Set<Prestamo>().Find(id);

        public IEnumerable<Prestamo> ObtenerTodos() => _contexto.Set<Prestamo>().AsNoTracking().ToList();

        public Prestamo Actualizar(Prestamo entidad)
        {
            var existente = _contexto.Set<Prestamo>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
