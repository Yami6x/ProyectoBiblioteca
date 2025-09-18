using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class MiembroRepositorio : IRepositorio<Miembro>
    {
        private readonly FullBibliotecaContexto _contexto;

        public MiembroRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Miembro Agregar(Miembro entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Miembro>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Miembro>().Find(id);
            if (e == null) return false;
            _contexto.Set<Miembro>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Miembro ObtenerPorId(int id) => _contexto.Set<Miembro>().Find(id);

        public IEnumerable<Miembro> ObtenerTodos() => _contexto.Set<Miembro>().AsNoTracking().ToList();

        public Miembro Actualizar(Miembro entidad)
        {
            var existente = _contexto.Set<Miembro>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
