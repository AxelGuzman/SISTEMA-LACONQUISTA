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

namespace LaConquista_WF
{
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridViewUSUARIOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tbUsuarioTableAdapter.Fill(this.sistemaLaConquistaDataSet.tbUsuario);
            refrescar();
        }

        private void BTNINGRESARUSUARIO_Click(object sender, EventArgs e)
        {
            string user = session.usuario.user_NombreUsuario;
            AgregarUsuarios add = new AgregarUsuarios();
            add.ShowDialog();
            refrescar();
        }

        #region generales
        private void refrescar()
        {
            try
            {
                using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
                {
                    var lst = from obj in model.tbUsuario
                              select obj;
                    //var lst1 = lst.select(b => new tbusuario
                    //{
                    //    user_idusuario = b.user_idusuario,
                    //    user_nombre = b.user_nombre,
                    //    user_apellido = b.user_apellido,
                    //    user_fechacreacion = b.user_fechacreacion,
                    //    user_estado = b.user_estado
                    //}).tolist();
                    dataGridViewUSUARIOS.DataSource = lst.ToList();

                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewUSUARIOS.Rows[dataGridViewUSUARIOS.CurrentRow.Index].Cells["Id"].Value.ToString());
            if (id != null)
            {
                AgregarUsuarios agregar = new AgregarUsuarios(id);
                agregar.ShowDialog();
                refrescar();
            }
        }

        private void dataGridViewUSUARIOS_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewUSUARIOS.Rows[dataGridViewUSUARIOS.CurrentRow.Index].Cells["Id"].Value.ToString());
            if (id != null)
            {
                AgregarUsuarios agregar = new AgregarUsuarios(id);
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    tbUsuario usuarios = db.tbUsuario.Find(id);
                    db.tbUsuario.Remove(usuarios);
                    db.SaveChanges();
                }
                refrescar();
            }
        }
    }
}
