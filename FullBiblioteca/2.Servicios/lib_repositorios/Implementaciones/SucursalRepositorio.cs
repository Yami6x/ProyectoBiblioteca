using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class SucursalRepositorio : IRepositorio<Sucursal>
    {
        private readonly FullBibliotecaContexto _contexto;

        public SucursalRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Sucursal Agregar(Sucursal entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Sucursal>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Sucursal>().Find(id);
            if (e == null) return false;
            _contexto.Set<Sucursal>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Sucursal ObtenerPorId(int id) => _contexto.Set<Sucursal>().Find(id);

        public IEnumerable<Sucursal> ObtenerTodos() => _contexto.Set<Sucursal>().AsNoTracking().ToList();

        public Sucursal Actualizar(Sucursal entidad)
        {
            var existente = _contexto.Set<Sucursal>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
