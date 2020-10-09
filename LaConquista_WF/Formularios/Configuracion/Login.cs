using LaConquista_WF.Formularios.Proveedores;
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
using static LaConquista_WF.Helpers.Utilidades;

namespace LaConquista_WF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string encryptpass = Encrypt.GetSHA256(TXT_CLAVE.Text.Trim());
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                var user = from x in db.tbUsuario
                          where x.user_NombreUsuario == TXT_USUARIO.Text
                          && x.user_Contrasenna == encryptpass
                          select x;
                if(user.Count() > 0)
                {
                    ListadoUsuarios lst = new ListadoUsuarios();

                    tbUsuario u = new tbUsuario();
                    u.user_NombreUsuario = user.FirstOrDefault().user_NombreUsuario;
                    u.user_IdUsuario = user.FirstOrDefault().user_IdUsuario;

                    session.usuario = u;

                    this.Hide();
                    lst.Show();
                }   
                else
                {
                    MessageBox.Show("Usario o contraseña incorrecta");
                }
            }

            
        }
    }
}
