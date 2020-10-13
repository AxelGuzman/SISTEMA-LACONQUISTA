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
    public partial class ListadoCliente : Form
    {
        public ListadoCliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            DisplayCliente();
        }
        public void DisplayCliente()
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                List<ListClienteViewModels> listaCliente = new List<ListClienteViewModels>();
                listaCliente = db.tbCliente.Select(x => new ListClienteViewModels
                {
                    IdCliente = x.clint_IdCliente,
                    Nombre = x.clint_Nombre + " " + x.clint_Apellido,
                    Identificacion = x.clint_Identificacion,
                    Telefono = x.clint_Telefono,
                    Correo = x.clint_Correo,
                }).ToList();
                dataGridView1.DataSource = listaCliente;
            }
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
        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.ShowDialog();
            DisplayCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                AgregarCliente agregarCliente = new AgregarCliente(id);
                agregarCliente.ShowDialog();
                DisplayCliente();
            }
        }
    }
}
