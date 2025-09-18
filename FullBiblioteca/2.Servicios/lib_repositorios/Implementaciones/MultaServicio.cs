using System;
using System.Collections.Generic;
using FullBiblioteca.Nucleo.Entidades;
using FullBiblioteca.Servicios.Interfaces;

namespace FullBiblioteca.Servicios.Implementaciones
{
    
    public class MultaServicio
    {
        private readonly IRepositorio<Multa> _repositorio;

        public MultaServicio(IRepositorio<Multa> repositorio)
        {
            _repositorio = repositorio;
        }

        public Multa AgregarConValidacion(Multa entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));
            if (string.IsNullOrWhiteSpace(entidad.Nombre)) throw new ArgumentException("El nombre es obligatorio");
            if (entidad.Nombre.Length < 3) throw new ArgumentException("El nombre debe tener al menos 3 caracteres");
            return _repositorio.Agregar(entidad);
        }

        public IEnumerable<Multa> Listar() => _repositorio.ObtenerTodos();
    }
}
