using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class CiudadRepositorio : IRepositorio<Ciudad>
    {
        private readonly FullBibliotecaContexto _contexto;

        public CiudadRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Ciudad Agregar(Ciudad entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Ciudad>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Ciudad>().Find(id);
            if (e == null) return false;
            _contexto.Set<Ciudad>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Ciudad ObtenerPorId(int id) => _contexto.Set<Ciudad>().Find(id);

        public IEnumerable<Ciudad> ObtenerTodos() => _contexto.Set<Ciudad>().AsNoTracking().ToList();

        public Ciudad Actualizar(Ciudad entidad)
        {
            var existente = _contexto.Set<Ciudad>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
