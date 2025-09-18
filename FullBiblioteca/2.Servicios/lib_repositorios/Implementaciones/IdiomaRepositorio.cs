using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class IdiomaRepositorio : IRepositorio<Idioma>
    {
        private readonly FullBibliotecaContexto _contexto;

        public IdiomaRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Idioma Agregar(Idioma entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Idioma>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Idioma>().Find(id);
            if (e == null) return false;
            _contexto.Set<Idioma>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Idioma ObtenerPorId(int id) => _contexto.Set<Idioma>().Find(id);

        public IEnumerable<Idioma> ObtenerTodos() => _contexto.Set<Idioma>().AsNoTracking().ToList();

        public Idioma Actualizar(Idioma entidad)
        {
            var existente = _contexto.Set<Idioma>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
