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
using LaConquista_WF.Helpers;
using static LaConquista_WF.Helpers.Utilidades;

namespace LaConquista_WF
{
    public partial class AgregarUsuarios : Form
    {
        public int? id;
        tbUsuario usuarios = null;

        public AgregarUsuarios(int? id = null)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.id = id;
            if (id != null) cargarData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNINGRESARUSUARIO_Click(object sender, EventArgs e)
        {
            string pass = TXT_CLAVE.Text;
            string passConfirm = TXT_CONFIRMARCLAVE.Text;

            if(pass == passConfirm)
            {
                using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
                {
                    Utilidades u = new Utilidades();

                    if (id == null)
                        usuarios = new tbUsuario();

                    string encryptpass = Encrypt.GetSHA256(TXT_CLAVE.Text.Trim());
                    usuarios.user_Nombre = TXT_NOMBRE.Text;
                    usuarios.user_Apellido = TXT_APELLIDO.Text;
                    usuarios.user_NombreUsuario = TXT_USUARIO.Text;

                    bool v = model.tbUsuario.Any(b => b.user_NombreUsuario == TXT_USUARIO.Text);
                    if (v)
                    {
                        MessageBox.Show("Nombre de usuario ya existe");
                        TXT_USUARIO.Text = "";
                        TXT_CLAVE.Text = "";
                        TXT_CONFIRMARCLAVE.Text = "";
                    }
                    else
                    {
                        usuarios.user_FechaCreacion = DateTime.Now;
                        usuarios.user_Contrasenna = encryptpass;

                        if (id == null)
                        {
                            model.tbUsuario.Add(usuarios);
                        }
                        else
                        {
                            model.Entry(usuarios).State = System.Data.Entity.EntityState.Modified;
                        }

                        model.SaveChanges();
                        this.Hide();
                    }

                }
            }
            else
            {
                MessageBox.Show("Confirmación de contraseña incorrecta, intente de nuevo");
                TXT_CLAVE.Text = "";
                TXT_CONFIRMARCLAVE.Text = "";
            }
        }


        private void cargarData()
        {
            using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
            {
                usuarios = model.tbUsuario.Find(id);

                TXT_NOMBRE.Text = usuarios.user_Nombre;
                TXT_APELLIDO.Text = usuarios.user_Apellido;
                TXT_USUARIO.Text = usuarios.user_NombreUsuario;
            }
        }
    }
}
