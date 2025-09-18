using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class PaisRepositorio : IRepositorio<Pais>
    {
        private readonly FullBibliotecaContexto _contexto;

        public PaisRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Pais Agregar(Pais entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Pais>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Pais>().Find(id);
            if (e == null) return false;
            _contexto.Set<Pais>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Pais ObtenerPorId(int id) => _contexto.Set<Pais>().Find(id);

        public IEnumerable<Pais> ObtenerTodos() => _contexto.Set<Pais>().AsNoTracking().ToList();

        public Pais Actualizar(Pais entidad)
        {
            var existente = _contexto.Set<Pais>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
