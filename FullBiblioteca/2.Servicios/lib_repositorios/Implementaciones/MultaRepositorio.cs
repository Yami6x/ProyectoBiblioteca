using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
  
    public class MultaRepositorio : IRepositorio<Multa>
    {
        private readonly FullBibliotecaContexto _contexto;

        public MultaRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Multa Agregar(Multa entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Multa>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Multa>().Find(id);
            if (e == null) return false;
            _contexto.Set<Multa>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Multa ObtenerPorId(int id) => _contexto.Set<Multa>().Find(id);

        public IEnumerable<Multa> ObtenerTodos() => _contexto.Set<Multa>().AsNoTracking().ToList();

        public Multa Actualizar(Multa entidad)
        {
            var existente = _contexto.Set<Multa>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
