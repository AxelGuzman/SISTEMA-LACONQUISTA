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
    public partial class AgregarCliente : Form
    {
        public int? id;
        tbCliente ontbCliente = null;
        public AgregarCliente(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if(id != null)
            {
                CargaDatos();
            }
            this.ttMensaje.SetToolTip(this.txt_Nombre, "Ingrese nombre");
            this.ttMensaje.SetToolTip(this.txt_Apellido, "Ingrese apellido");
            this.ttMensaje.SetToolTip(this.txt_Identificacion, "Ingrse identificación");
            this.ttMensaje.SetToolTip(this.txt_Telefono, "Ingrese telefono");
            this.ttMensaje.SetToolTip(this.txt_Correo, "Ingrese correo");
        }

        private void CargaDatos()
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                ontbCliente = db.tbCliente.Find(id);

                txt_Nombre.Text = ontbCliente.clint_Nombre;
                txt_Apellido.Text = ontbCliente.clint_Apellido;
                txt_Identificacion.Text = ontbCliente.clint_Identificacion;
                txt_Telefono.Text = ontbCliente.clint_Telefono;
                txt_Correo.Text = ontbCliente.clint_Correo;
            }
        }
        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        public void LimpiaText()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Identificacion.Clear();
            txt_Telefono.Clear();
            txt_Correo.Clear();
        }
        private void BTNINGRESARCLIENTE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    if(id == null)
                    {
                        ontbCliente = new tbCliente();
                        ontbCliente.clint_Nombre = txt_Nombre.Text;
                        ontbCliente.clint_Apellido = txt_Apellido.Text;
                        ontbCliente.clint_Identificacion = txt_Identificacion.Text;
                        ontbCliente.clint_Telefono = txt_Telefono.Text;
                        //ontbCliente.clint_Direccion = txt_Direccion.Text;
                        ontbCliente.clint_Correo = txt_Correo.Text;
                        ontbCliente.clint_Estado = true;
                        ontbCliente.UsuarioCrea = 5;
                        ontbCliente.FechaCrea = DateTime.Now;
                        db.tbCliente.Add(ontbCliente);
                        db.SaveChanges();
                        MessageBox.Show("Datos ingresado correctamente!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ontbCliente.clint_Nombre = txt_Nombre.Text;
                        ontbCliente.clint_Apellido = txt_Apellido.Text;
                        ontbCliente.clint_Identificacion = txt_Identificacion.Text;
                        ontbCliente.clint_Telefono = txt_Telefono.Text;
                        //ontbCliente.clint_Direccion = txt_Direccion.Text;
                        ontbCliente.clint_Correo = txt_Correo.Text;
                        ontbCliente.clint_Estado = true;
                        ontbCliente.UsuarioModifica = 5;
                        ontbCliente.FechaModifica = DateTime.Now;
                        db.Entry(ontbCliente).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos editados correctamente!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }

        }

        private void BTNSALIRCLIENTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
