using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProyectoPoo
{
    class RegistroCompras
    {
        public int Cantidad { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalUnitario { get; set; }
        public int Id { get; internal set; }

        public RegistroCompras()
        {

        }
    }
}
