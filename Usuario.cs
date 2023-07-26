using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int Id { get; internal set; }

        public Usuario()
        {
        }
    }
}