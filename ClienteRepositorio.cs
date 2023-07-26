using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
// Implementación del repositorio para la entidad Cliente
 class ClienteRepositorio : IRepositorio<Cliente>
 {
    private List<Cliente> clientes = new List<Cliente>();
     public void Agregar(Cliente entidad)
        {
            clientes.Add(entidad);
        }

        public void Actualizar(Cliente entidad)
        {
            // Implementar lógica para actualizar el cliente en la base de datos
        }

        public void Eliminar(Cliente entidad)
        {
            clientes.Remove(entidad);
        }

        public List<Cliente> ObtenerTodos()
        {
            return clientes;
        }

        public Cliente ObtenerPorId(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }
    }

 }
