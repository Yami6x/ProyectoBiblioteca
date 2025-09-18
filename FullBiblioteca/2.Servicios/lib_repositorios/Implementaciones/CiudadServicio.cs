using System;
using System.Collections.Generic;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class CiudadServicio
    {
        private readonly IRepositorio<Ciudad> _repositorio;

        public CiudadServicio(IRepositorio<Ciudad> repositorio)
        {
            _repositorio = repositorio;
        }

        public Ciudad AgregarConValidacion(Ciudad entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new ArgumentException("El nombre es obligatorio");
            if (entidad.Nombre.Length < 3) throw new ArgumentException("El nombre debe tener al menos 3 caracteres");
            return _repositorio.Agregar(entidad);
        }

        public IEnumerable<Ciudad> Listar() => _repositorio.ObtenerTodos();
    }
}
