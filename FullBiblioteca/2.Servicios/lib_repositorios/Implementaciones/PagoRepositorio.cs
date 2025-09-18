using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class PagoRepositorio : IRepositorio<Pago>
    {
        private readonly FullBibliotecaContexto _contexto;

        public PagoRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Pago Agregar(Pago entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Pago>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Pago>().Find(id);
            if (e == null) return false;
            _contexto.Set<Pago>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Pago ObtenerPorId(int id) => _contexto.Set<Pago>().Find(id);

        public IEnumerable<Pago> ObtenerTodos() => _contexto.Set<Pago>().AsNoTracking().ToList();

        public Pago Actualizar(Pago entidad)
        {
            var existente = _contexto.Set<Pago>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
