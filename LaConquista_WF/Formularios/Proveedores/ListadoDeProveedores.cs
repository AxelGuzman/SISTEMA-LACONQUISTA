using LaConquista_WF.Models;
using LaConquista_WF.Models.Parciales.Proveedores;
using System;
using System.Collections;
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
    public partial class ListadoDeProveedores : Form
    {
        public ListadoDeProveedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ListadoDeProveedores_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            try
            {
                using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
                {
                    var lst = from obj in model.tbProveedor
                              select obj;
                    var lst1 = lst.Select(b => new listProveedores
                    {
                        id = b.prove_IdProveedor,
                        Identificacion = b.prove_Identificacion,
                        Nombre = b.prove_Nombre + " " + b.prove_Apellido,
                        Contacto = b.provee_Contacto,
                        Email = b.provee_Correo,
                        Estado = b.provee_Estado,
                        FechaCrea = b.FechaCrea,
                        FechaModifica = b.FechaModifica,
                        IdUsuarioCrea = b.UsuarioCrea,
                        IdUsuarioModifica = b.UsuarioModifica,
                        UsuarioCreado = b.tbUsuario.user_NombreUsuario,
                        UsuarioModificado = b.tbUsuario1.user_NombreUsuario,
                        estadoStr = b.provee_Estado == true ? "Habilitado" : "Inhabilitado"
                    }).ToList();

                    dataGridViewProveedores.DataSource = lst1;
                    dibujar();

                }
            }
            catch (Exception ex)
            {

            }
        }
        private void dibujar()
        {
            try
            {
                foreach (DataGridViewRow row in (IEnumerable)this.dataGridViewProveedores.Rows)
                {
                    bool estado = (bool)row.Cells["Estado"].Value;
                    if (estado)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;// Cells["estadoStr"].defa;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;// Cells["estadoStr"].defa;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BTNINGRESARUSUARIO_Click(object sender, EventArgs e)
        {
            AgregarProveedor add = new AgregarProveedor();
            add.ShowDialog();
            refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewProveedores.Rows[dataGridViewProveedores.CurrentRow.Index].Cells["id"].Value.ToString());
            if (id != null)
            {
                AgregarProveedor agregar = new AgregarProveedor(id);
                agregar.ShowDialog();
                refrescar();
            }
        }

        private void BTN_INREHABILITAR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewProveedores.Rows[dataGridViewProveedores.CurrentRow.Index].Cells["id"].Value.ToString());
            if (id != null)
            {
                alterarEstado estado = new alterarEstado(id);
                estado.ShowDialog();
                refrescar();
            }
        }
    }
}
