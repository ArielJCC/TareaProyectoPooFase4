using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class Cliente
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public int Celular { get; set; }
        public string DireccionDomicilio { get; set; }
        public DateTime Fechaemision { get; set; }
        public int Id { get; internal set; }

        public Cliente()
        {
        }

        public string MostrarDatosCliente()
        {
            return "Nombre: " + this.Name + "\nApellido: " + this.Apellido + "\nCedula: " + this.Cedula + "\nCelular: " + this.Celular + "\nFecha: " + DateTime.Now + "\n";
        }
        public void Guardar()
        {
            Console.WriteLine("Se están guardando los datos en BD...");
            Console.WriteLine("Guardados exitosamente.");
        }
        public void Imprimir()
        {
            Console.WriteLine("Preparando para imprimir...");
            Console.WriteLine("Listo.");
        }
    }
}