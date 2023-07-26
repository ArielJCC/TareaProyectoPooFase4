using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    // Implementación del repositorio para la entidad RegistroCompras
    class RegistroComprasRepositorio : IRepositorio<RegistroCompras>
    {
        private List<RegistroCompras> registros = new List<RegistroCompras>();
        public void Agregar(RegistroCompras entidad)
        {
            registros.Add(entidad);
        }

        public void Actualizar(RegistroCompras entidad)
        {
            // Implementar lógica para actualizar el registro de compras en la base de datos
        }

        public void Eliminar(RegistroCompras entidad)
        {
            registros.Remove(entidad);
        }

        public List<RegistroCompras> ObtenerTodos()
        {
            return registros;
        }

        public RegistroCompras ObtenerPorId(int id)
        {
            return registros.FirstOrDefault(r => r.Id == id);
        }
    }

    }
