using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConquista_WF.Models
{
    class ListClienteViewModels
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        //public string Direccion { get; set; }
        public string Correo { get; set; }
    }
}
