using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class PagoEfectivo : IPago
    {
        public string NombrePago { get; set; }

        public PagoEfectivo()
        {
            this.NombrePago = "Pago Efectivo";
        }
        public string MostrarMetodoPago()
        {
            return "Modo de pago por:" + this.NombrePago;
        }
    }
}