using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.Helpers;
using LaConquista_WF.Models;

namespace LaConquista_WF
{
    public partial class AgregarProducto : Form
    {
        public int? id;
        tbProducto ontbProducto = null;
        public AgregarProducto(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CargaDatos()
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                try
                {
                    ontbProducto = db.tbProducto.Find(id);
                    txt_Codigo.Text = ontbProducto.produ_Codigo;
                    txt_Descripcion.Text = ontbProducto.produ_Descripcion;
                    txt_PrecioCompra.Text = Convert.ToString(ontbProducto.produ_PrecioCompra);
                    txt_PrecioVenta.Text = Convert.ToString(ontbProducto.produ_PrecioVenta);
                    txt_Cantidad.Text = Convert.ToString(ontbProducto.produ_Cantidad);
                    cbx_Categoria.Text = Convert.ToString(ontbProducto.cprod_Id);
                    cbx_Categoria.Text = ontbProducto.produ_Categoria;
                    cbx_Proveedor.Text = Convert.ToString(ontbProducto.prove_IdProveedor);
                    //byte[] img = (byte[])ontbProducto.produ_Foto;
                    //if(img == null)
                    //{
                    //    lbInfImagen.Visible = true;
                    //}
                    //else
                    //{
                    //    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    //    pictboxFoto.Image = Image.FromStream(ms);
                    //}
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            //aqui se rompe
            //// TODO: esta línea de código carga datos en la tabla 'sistemaLaConquistaDataSet1.tbProveedor' Puede moverla o quitarla según sea necesario.
            //this.tbProveedorTableAdapter.Fill(this.sistemaLaConquistaDataSet1.tbProveedor);
            this.tbProveedorTableAdapter.Fill(this.sistemaLaConquistaDataSet1.tbProveedor);
            //// TODO: esta línea de código carga datos en la tabla 'sistemaLaConquistaDataSet1.tbCatalogoProductos' Puede moverla o quitarla según sea necesario.
            //this.tbCatalogoProductosTableAdapter.Fill(this.sistemaLaConquistaDataSet1.tbCatalogoProductos);
            //// TODO: esta línea de código carga datos en la tabla 'sistemaLaConquistaDataSet1.tbCatalogoProductos' Puede moverla o quitarla según sea necesario.
            //this.tbCatalogoProductosTableAdapter.Fill(this.sistemaLaConquistaDataSet1.tbCatalogoProductos);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbCatalogoProductosTableAdapter.FillBy(this.sistemaLaConquistaDataSet1.tbCatalogoProductos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BTNSALIRPRODUCTO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNINGRESARPRODUCTO_Click(object sender, EventArgs e)
        {
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    if (id == null)
                    {
                        ontbProducto = new tbProducto();
                        ontbProducto.produ_Codigo = txt_Codigo.Text;
                        ontbProducto.produ_Descripcion = txt_Descripcion.Text;
                        ontbProducto.produ_PrecioCompra = Convert.ToDecimal(txt_PrecioCompra.Text);
                        ontbProducto.produ_PrecioVenta = Convert.ToDecimal(txt_PrecioVenta.Text);
                        ontbProducto.produ_Cantidad = Convert.ToDecimal(txt_Cantidad.Text);
                        ontbProducto.cprod_Id = Convert.ToInt32(cbx_Categoria.SelectedValue);
                        ontbProducto.produ_Categoria = cbx_Categoria.Text;
                        ontbProducto.prove_IdProveedor = Convert.ToInt32(cbx_Proveedor.SelectedValue);// cbx_Proveedor.Text;
                        ontbProducto.produ_Estado = true;
                        ontbProducto.FechaCrea = DateTime.Now;
                        ontbProducto.UsuarioCrea = 5;
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pictboxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //ontbProducto.produ_Foto = ms.GetBuffer();
                        db.tbProducto.Add(ontbProducto);
                        db.SaveChanges();
                        MessageBox.Show("Datos ingresado correctamente!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ontbProducto.produ_Codigo = txt_Codigo.Text;
                        ontbProducto.produ_Descripcion = txt_Descripcion.Text;
                        ontbProducto.produ_PrecioCompra = Convert.ToDecimal(txt_PrecioCompra.Text);
                        ontbProducto.produ_PrecioVenta = Convert.ToDecimal(txt_PrecioVenta.Text);
                        ontbProducto.produ_Cantidad = Convert.ToDecimal(txt_Cantidad.Text);
                        ontbProducto.cprod_Id = Convert.ToInt32(cbx_Categoria.SelectedValue);
                        ontbProducto.produ_Categoria = cbx_Categoria.Text;
                        ontbProducto.prove_IdProveedor = Convert.ToInt32(cbx_Proveedor.SelectedValue);// cbx_Proveedor.Text;
                        ontbProducto.produ_Estado = true;
                        ontbProducto.UsuarioModifica = session.usuario.user_IdUsuario;
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pictboxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //ontbProducto.produ_Foto = ms.GetBuffer();
                        ontbProducto.FechaModifica = DateTime.Now;
                        db.Entry(ontbProducto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos editado correctamente!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if(rs == DialogResult.OK)
            {
                pictboxFoto.Image = Image.FromFile(fo.FileName);
            }
        }

        private void consultarProveedoresToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbProveedorTableAdapter1.ConsultarProveedores(this.dataSetPrincipal.tbProveedor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
