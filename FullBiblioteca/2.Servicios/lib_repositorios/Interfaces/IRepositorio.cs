using System.Collections.Generic;

namespace FullBiblioteca.Servicios.Interfaces
{
    
    public interface IRepositorio<T> where T : class
    {
        T Agregar(T entidad);
        T ObtenerPorId(int id);
        IEnumerable<T> ObtenerTodos();
        T Actualizar(T entidad);
        bool Eliminar(int id);
    }
}
