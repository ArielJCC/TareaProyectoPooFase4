using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class PagoCreditoDebito : IPago
    {
        public string NombrePago { get; set; }

        public PagoCreditoDebito()
        {
            this.NombrePago = "Pago por Tarjeta de Crédito/Débito";
        }
        public string MostrarMetodoPago()
        {
            return "Modo de pago por:  " + this.NombrePago;
        }
    }
}