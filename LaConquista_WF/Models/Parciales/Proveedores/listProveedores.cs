using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConquista_WF.Models.Parciales.Proveedores
{
    class listProveedores
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Contacto { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Email { get; set; }
        public Nullable<int> IdUsuarioModifica { get; set; }
        public int IdUsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }




        public string UsuarioCreado { get; set; }
        public string UsuarioModificado { get; set; }
    }
}
