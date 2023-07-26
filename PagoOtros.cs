using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class PagoOtros : IPago
    {
        public string NombrePago { get; set; }

        public PagoOtros()
        {
            this.NombrePago = "Pago Otros";
        }
        public string MostrarMetodoPago()
        {
            return "Modo de pago por:  " + this.NombrePago;
        }
    }
}
