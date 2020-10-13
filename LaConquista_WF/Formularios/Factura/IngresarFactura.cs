using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.Models;

namespace LaConquista_WF
{
    public partial class IngresarFactura : Form
    {
        public IngresarFactura()
        {
            InitializeComponent();
        }

        private void IngresarFactura_Load(object sender, EventArgs e)
        {
            BuscarPorProducto();
        }

        private void Nombre_cliente_Click(object sender, EventArgs e)
        {

        }

        

        private void Apellido_cliente_Click(object sender, EventArgs e)
        {

        }

        private void TXT_DESCRIPCION_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXTIDESCUENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNMENU_Click(object sender, EventArgs e)
        {

        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {

        }

        private void BTNCOBRAR_Click(object sender, EventArgs e)
        {

        }

        private void BTNAGREGARFACTURA_Click(object sender, EventArgs e)
        {
            using (SistemaLaConquistaEntities context = new SistemaLaConquistaEntities())
            {
                var selectProducto = context.tbProducto.Where(x => x.produ_Codigo == txt_Codigo.Text && x.produ_Estado == true).Select(x => new SelectProductoViewModels {
                    codigoProducto = x.produ_Codigo,
                    descripcionProducto = x.produ_Descripcion,
                    precioProducto = x.produ_PrecioVenta ?? 0,
                    cantidadProducto = x.produ_Cantidad ?? 0,
                    subTotalProducto = (x.produ_PrecioVenta ?? 0) * (x.produ_Cantidad ?? 0),
                });
            }
                dataGridView1.Rows.Add(txt_Codigo.Text, txt_Descripcion.Text, 23.53, 2, 23.53 * 2/*, txt_Descuento.Text*/);
            txt_Codigo.Clear();
            txt_Descripcion.Clear();
            //txt_Descuento.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(!txt_Codigo.Text.Trim().Equals(""))
            {
                BuscarPorProducto(txt_Codigo.Text.Trim());
            }
        }
        private void BuscarPorProducto(string busqueda = null)
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                IQueryable<SelectProductoViewModels> buscarProducto = from d in db.tbProducto
                                                              select new SelectProductoViewModels
                                                              {
                                                                  codigoProducto = d.produ_Codigo,
                                                                  descripcionProducto = d.produ_Descripcion,
                                                                  precioProducto = d.produ_PrecioVenta,
                                                              };
                if(busqueda != null)
                {
                   buscarProducto = buscarProducto.Where(d => d.codigoProducto == busqueda);
                }
                txt_Descripcion.Text = buscarProducto.ToString();
                txt_Cantidad.Text = buscarProducto.ToString();

                
            }
        }
    }
}
