using System;
using System.Collections.Generic;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class PaisServicio
    {
        private readonly IRepositorio<Pais> _repositorio;

        public PaisServicio(IRepositorio<Pais> repositorio)
        {
            _repositorio = repositorio;
        }

        public Pais AgregarConValidacion(Pais entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new ArgumentException("El nombre es obligatorio");
            if (entidad.Nombre.Length < 3) throw new ArgumentException("El nombre debe tener al menos 3 caracteres");
            return _repositorio.Agregar(entidad);
        }

        public IEnumerable<Pais> Listar() => _repositorio.ObtenerTodos();
    }
}
