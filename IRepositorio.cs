using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    // Interfaz para el repositorio
    interface IRepositorio<T>
    {
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
    }
}