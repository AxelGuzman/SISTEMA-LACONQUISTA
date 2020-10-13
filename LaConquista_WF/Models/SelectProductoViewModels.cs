using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConquista_WF.Models
{
    class SelectProductoViewModels
    {
        public int idProducto { get; set; }
        public string codigoProducto { get; set; }
        public string descripcionProducto { get; set; }
        public decimal? precioProducto { get; set; }
        public decimal cantidadProducto { get; set; }
        public decimal subTotalProducto { get; set; }
    }
}
