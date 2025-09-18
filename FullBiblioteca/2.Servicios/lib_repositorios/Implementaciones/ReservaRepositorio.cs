using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class ReservaRepositorio : IRepositorio<Reserva>
    {
        private readonly FullBibliotecaContexto _contexto;

        public ReservaRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Reserva Agregar(Reserva entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Reserva>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Reserva>().Find(id);
            if (e == null) return false;
            _contexto.Set<Reserva>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Reserva ObtenerPorId(int id) => _contexto.Set<Reserva>().Find(id);

        public IEnumerable<Reserva> ObtenerTodos() => _contexto.Set<Reserva>().AsNoTracking().ToList();

        public Reserva Actualizar(Reserva entidad)
        {
            var existente = _contexto.Set<Reserva>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
