using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class UsuarioRepositorio : IRepositorio<Usuario>
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void Agregar(Usuario entidad)
        {
            usuarios.Add(entidad);
        }

        public void Actualizar(Usuario entidad)
        {
            // Implementar lógica para actualizar el usuario en la base de datos
        }

        public void Eliminar(Usuario entidad)
        {
            usuarios.Remove(entidad);
        }

        public List<Usuario> ObtenerTodos()
        {
            return usuarios;
        }

        public Usuario ObtenerPorId(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }
    }   
    }
