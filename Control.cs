using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class Control
    {
        private ICommand[] comandos = new ICommand[2];
        //  Se crea el constuctor
        public Control(Cliente pdatos)
        {
            //A cada uno de los elementos dentro del arreglo se le va a asignar
            //un comando en específico
            comandos[0] = new Guardar(pdatos);
            comandos[1] = new Imprimir(pdatos);
        }
        //A través de esto llamamos la acción en específica a ejecutar 
        //de acuerdo a lo que indique el usuario.
        public void Boton(int pIndice)
        {
            comandos[pIndice].Ejecutar();
        }
    }
}
