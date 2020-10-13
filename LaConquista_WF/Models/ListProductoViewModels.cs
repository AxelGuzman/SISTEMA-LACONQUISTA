using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConquista_WF.Models
{
    class ListProductoViewModels
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public string Categoria { get; set; }
        public Nullable<decimal> CantidadDisponible { get; set; }
    }
}
