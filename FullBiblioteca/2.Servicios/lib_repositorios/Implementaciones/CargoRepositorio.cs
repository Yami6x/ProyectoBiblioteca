using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
   
    public class CargoRepositorio : IRepositorio<Cargo>
    {
        private readonly FullBibliotecaContexto _contexto;

        public CargoRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Cargo Agregar(Cargo entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Cargo>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Cargo>().Find(id);
            if (e == null) return false;
            _contexto.Set<Cargo>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Cargo ObtenerPorId(int id) => _contexto.Set<Cargo>().Find(id);

        public IEnumerable<Cargo> ObtenerTodos() => _contexto.Set<Cargo>().AsNoTracking().ToList();

        public Cargo Actualizar(Cargo entidad)
        {
            var existente = _contexto.Set<Cargo>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
