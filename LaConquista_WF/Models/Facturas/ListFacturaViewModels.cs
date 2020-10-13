using LaConquista_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaConquista_WF.Helpers
{
    class ListFacturaViewModels
    {
            public int fact_Id { get; set; }
            public int clint_IdCliente { get; set; }
            public string efact_CodigoFactura { get; set; }
            public System.DateTime efact_FechaFacturacion { get; set; }
            public decimal efact_Subtotal { get; set; }
            public decimal efact_Isv { get; set; }
            public decimal efact_Descuento { get; set; }
            public decimal efact_Total { get; set; }
            public bool efact_Estado { get; set; }


            public int dtfact_Id { get; set; }
            public int produ_IdProducto { get; set; }
            public string defact_DescripcionProducto { get; set; }
            public decimal defact_CantidadProducto { get; set; }
            public decimal defact_PrecioProducto { get; set; }
            public decimal defact_Subtotal { get; set; }
            public decimal defact_Isv { get; set; }
            public decimal defact_Descuento { get; set; }
            public decimal defact_Total { get; set; }
            public bool defact_Estado { get; set; }


            public int UsuarioCrea { get; set; }
            public int UsuarioModifica { get; set; }
            public System.DateTime FechaCrea { get; set; }
            public System.DateTime FechaModifica { get; set; }

            public virtual tbEncabezadoFactura tbEncabezadoFactura { get; set; }
            public virtual tbProducto tbProducto { get; set; }
            public virtual tbUsuario tbUsuario { get; set; }
            public virtual tbUsuario tbUsuario1 { get; set; }
            public virtual tbCliente tbCliente { get; set; }
    }
}
