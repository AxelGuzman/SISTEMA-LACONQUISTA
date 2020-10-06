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
    public partial class AgregarProveedor : Form
    {
        public int? id;
        tbProveedor proveedores = null;

        public AgregarProveedor(int? id = null)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.id = id;
            if (id != null) cargarData();
        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void BTNINGRESARCLIENTE_Click(object sender, EventArgs e)
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                if (id == null)
                    proveedores = new tbProveedor();

                proveedores.prove_Nombre = TXT_NOMBRE.Text;
                proveedores.prove_Apellido = TXT_APELLIDO.Text;
                proveedores.prove_Identificacion = TXTIDENTIDAD.Text;
                proveedores.provee_Contacto = TXTTELEFONO.Text;
                proveedores.provee_Correo = TXTEMAIL.Text;


                if (id == null)
                {
                    db.tbProveedor.Add(proveedores);
                }
                else
                {
                    db.Entry(proveedores).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            this.Hide();
            
        }




        private void cargarData()
        {
            using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
            {
                proveedores = model.tbProveedor.Find(id);

                TXT_NOMBRE.Text = proveedores.prove_Nombre;
                TXT_APELLIDO.Text = proveedores.prove_Apellido;
                TXTIDENTIDAD.Text = proveedores.prove_Identificacion;
                TXTEMAIL.Text = proveedores.provee_Correo;
                TXTTELEFONO.Text = proveedores.provee_Contacto;
            }
        }
    }
}
