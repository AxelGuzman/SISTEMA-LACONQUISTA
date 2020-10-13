using LaConquista_WF.Helpers;
using LaConquista_WF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaConquista_WF.Formularios.Proveedores
{
    public partial class alterarEstado : Form
    {
        public int id;

        public alterarEstado(int id)
        {
            InitializeComponent();
            this.id = id;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void alterarEstado_Load(object sender, EventArgs e)
        {
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    tbProveedor p = db.tbProveedor.Find(id);
                    bool estado = p.provee_Estado ?? false;
                    LBL_REGISTRO.Text = p.prove_Nombre + " " + p.prove_Apellido;
                    if (estado)
                    {
                        LBL_ESTASDOACTUAL.Text = "HABILITADO";
                        BTNCAMBIAR.Text = "INHABILITAR ESTE REGISTRO";
                        BTNCAMBIAR.BackColor = Color.Crimson;
                    }
                    else
                    {
                        LBL_ESTASDOACTUAL.Text = "INHABILITADO";
                        BTNCAMBIAR.Text = "HABILITAR ESTE REGISTRO";
                        BTNCAMBIAR.BackColor = Color.Cyan;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex.Data.ToString());
            }
            
        }

        private void BTNCAMBIAR_Click(object sender, EventArgs e)
        {
            try
            {
                using(SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    tbProveedor proveedores = db.tbProveedor.Find(id);
                    bool estado = proveedores.provee_Estado ?? false;
                    if (estado)
                    {
                        proveedores.provee_Estado = false;
                    }
                    else
                    {
                        proveedores.provee_Estado = true;
                    }
                    proveedores.UsuarioModifica = session.usuario.user_IdUsuario;
                    proveedores.FechaModifica = DateTime.Now;
                    db.Entry(proveedores).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
