using System;
using System.Collections.Generic;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class CargoServicio
    {
        private readonly IRepositorio<Cargo> _repositorio;

        public CargoServicio(IRepositorio<Cargo> repositorio)
        {
            _repositorio = repositorio;
        }

        public Cargo AgregarConValidacion(Cargo entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new ArgumentException("El nombre es obligatorio");
            if (entidad.Nombre.Length < 3) throw new ArgumentException("El nombre debe tener al menos 3 caracteres");
            return _repositorio.Agregar(entidad);
        }

        public IEnumerable<Cargo> Listar() => _repositorio.ObtenerTodos();
    }
}
