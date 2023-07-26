using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class PagoElectronico : IPago
    {
        public string NombrePago { get; set; }

        public PagoElectronico()
        {
            this.NombrePago = "Pago por Dinero Electrónico";
        }
        public string MostrarMetodoPago()
        {
            return "Modo de pago por:  " + this.NombrePago;
        }
    }
}
