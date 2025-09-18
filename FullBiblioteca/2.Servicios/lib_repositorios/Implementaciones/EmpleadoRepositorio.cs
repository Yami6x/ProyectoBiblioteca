using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
  
    public class EmpleadoRepositorio : IRepositorio<Empleado>
    {
        private readonly FullBibliotecaContexto _contexto;

        public EmpleadoRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Empleado Agregar(Empleado entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Empleado>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Empleado>().Find(id);
            if (e == null) return false;
            _contexto.Set<Empleado>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Empleado ObtenerPorId(int id) => _contexto.Set<Empleado>().Find(id);

        public IEnumerable<Empleado> ObtenerTodos() => _contexto.Set<Empleado>().AsNoTracking().ToList();

        public Empleado Actualizar(Empleado entidad)
        {
            var existente = _contexto.Set<Empleado>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
