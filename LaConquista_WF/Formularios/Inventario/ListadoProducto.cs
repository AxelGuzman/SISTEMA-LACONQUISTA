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
    public partial class ListadoProducto : Form
    {
        public ListadoProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ListadoProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            DisplayProducto();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void DisplayProducto()
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                List<ListProductoViewModels> listaProducto = new List<ListProductoViewModels>();
                listaProducto = db.tbProducto.Select(x => new ListProductoViewModels
                {
                    IdProducto = x.produ_IdProducto,
                    Codigo = x.produ_Codigo,
                    Descripcion = x.produ_Descripcion,
                    PrecioCompra = x.produ_PrecioCompra,
                    PrecioVenta = x.produ_PrecioVenta,
                    Categoria = x.produ_Categoria,
                    CantidadDisponible = x.produ_Cantidad
                }).ToList();
                dataGridView1.DataSource = listaProducto;
            }
        }

        private void btbINGRESARPRODUCTO_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
            DisplayProducto();
        }

        private void BTNSALIRPRODUCTO_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                AgregarProducto agregarProducto = new AgregarProducto(id);
                agregarProducto.ShowDialog();
                DisplayProducto();
            }
        }
    }
}
