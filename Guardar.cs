using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class Guardar : ICommand
    {
        Cliente datos;

        public Guardar(Cliente pdatos)
        {
            datos = pdatos;

        }
        public void Ejecutar()
        {
            datos.Guardar();
            //Se invoca la acción relacionada con los Datos en específico del cliente
        }
    }
}
