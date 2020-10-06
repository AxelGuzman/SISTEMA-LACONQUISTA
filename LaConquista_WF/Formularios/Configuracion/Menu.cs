using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.Formularios;

namespace LaConquista_WF
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            ListadoCliente listadoCliente = new ListadoCliente();
            listadoCliente.Show();
            this.Hide(); 
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            ListadoProducto listadoProducto = new ListadoProducto();
            listadoProducto.Show();
            this.Hide();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            IngresarFactura ingresarFactura = new IngresarFactura();
            ingresarFactura.Show();
            this.Close();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
