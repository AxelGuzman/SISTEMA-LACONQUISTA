//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaConquista_WF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEncabezadoFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEncabezadoFactura()
        {
            this.tbDetalleFactura = new HashSet<tbDetalleFactura>();
        }
    
        public int fact_Id { get; set; }
        public Nullable<int> clint_IdCliente { get; set; }
        public string efact_CodigoFactura { get; set; }
        public Nullable<System.DateTime> efact_FechaFacturacion { get; set; }
        public Nullable<decimal> efact_Subtotal { get; set; }
        public Nullable<decimal> efact_Isv { get; set; }
        public Nullable<decimal> efact_Total { get; set; }
        public Nullable<bool> efact_Estado { get; set; }
        public int UsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual tbCliente tbCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDetalleFactura> tbDetalleFactura { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
