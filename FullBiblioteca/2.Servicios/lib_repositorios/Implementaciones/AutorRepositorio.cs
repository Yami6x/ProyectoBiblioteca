using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FullBiblioteca.Nucleo.Contexto;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class AutorRepositorio : IRepositorio<Autor>
    {
        private readonly FullBibliotecaContexto _contexto;

        public AutorRepositorio(FullBibliotecaContexto contexto)
        {
            _contexto = contexto;
        }

        public Autor Agregar(Autor entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            _contexto.Set<Autor>().Add(entidad);
            _contexto.SaveChanges();
            return entidad;
        }

        public bool Eliminar(int id)
        {
            var e = _contexto.Set<Autor>().Find(id);
            if (e == null) return false;
            _contexto.Set<Autor>().Remove(e);
            _contexto.SaveChanges();
            return true;
        }

        public Autor ObtenerPorId(int id) => _contexto.Set<Autor>().Find(id);

        public IEnumerable<Autor> ObtenerTodos() => _contexto.Set<Autor>().AsNoTracking().ToList();

        public Autor Actualizar(Autor entidad)
        {
            var existente = _contexto.Set<Autor>().Find(entidad.Id);
            if (existente == null) throw new InvalidOperationException("Entidad no encontrada");
            existente.Nombre = entidad.Nombre;
            _contexto.SaveChanges();
            return existente;
        }
    }
}
