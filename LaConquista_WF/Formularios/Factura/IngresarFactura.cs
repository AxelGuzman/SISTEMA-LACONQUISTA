using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.Helpers;
using LaConquista_WF.Models;
using LaConquista_WF.Models.Parciales.Proveedores;
using static LaConquista_WF.AgregarProducto;
using static LaConquista_WF.Helpers.Utilidades;

namespace LaConquista_WF
{
    public partial class IngresarFactura : Form
    {
        private string CodigoFact = "";
        private string NombreClient = "";
        private string GlosubTotal = "";
        private string Gloisv = "";
        private string Glototal = "";

        private string nombreProducto = "";

        public IngresarFactura()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void IngresarFactura_Load(object sender, EventArgs e)
        {
            nmr_totalFactura.ReadOnly = true;
            nmr_totalFactura.Increment = 0;
            //nmr_totalFactura.Value = 100;

            nmr_totalFactura.Controls.RemoveAt(0);
            nmr_Cantidad.Controls.RemoveAt(0);
            nmr_Descuento.Controls.RemoveAt(0);

            BuscarPorProducto();
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    CBCLIENTEFACTURA.DropDownStyle = ComboBoxStyle.DropDownList;
                    var descripciones = db.tbCliente.Where(x => x.clint_Estado == true).Select(x => x.clint_Nombre + " " + x.clint_Apellido).ToList();
                    descripciones.ForEach(x =>
                    {
                        CBCLIENTEFACTURA.Items.Add(x);
                    });


                    //var clientes = db.tbCliente.Where(x => x.clint_Estado == true).Select(y => new listProveedores
                    //{
                    //    id = y.clint_IdCliente,
                    //    Nombre = y.clint_Nombre + " " + y.clint_Apellido
                    //}).ToList();
                    //ComboboxItem c = new ComboboxItem();
                    //clientes.ForEach(y =>
                    //{
                    //    c.Value = y.id;
                    //    c.Text = y.Nombre;
                    //    CBCLIENTEFACTURA.Items.Add(c);
                    //});

                    foreach(var item in this.Controls.OfType<Button>())
                    {
                        if(item.BackColor == Color.Salmon || item.BackColor == Color.LightCoral || item.BackColor == Color.Tomato)
                        {
                            item.Click += EvaluarExistencias;
                        }
                    }

                    txt_Descripcion.AutoCompleteCustomSource = autocompleteProducts();
                    txt_Descripcion.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txt_Descripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                txt_Descripcion.KeyDown += evaluaTecla;

            }
            catch (Exception ex)
            {

            }
        }

        private AutoCompleteStringCollection autocompleteProducts()
        {
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    var products = db.tbProducto.Where(x => 
                                                                x.produ_Estado == true 
                                                                //&& x.tbInventarioProductos.FirstOrDefault(y => y.produ_IdProducto == x.produ_IdProducto).invp_Stock > 0
                                                        ).ToList();
                    products.ForEach(x =>
                    {
                        data.Add(x.produ_Descripcion);
                    });
                    return data;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private void EvaluarExistencias(object sender, EventArgs e)
        {
            try
            {
                string pr = (sender as Button).Text;
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    var obj = db.tbProducto.FirstOrDefault(x => x.produ_Descripcion.ToUpper().Trim() == pr.ToUpper().Trim());
                    if (obj != null)
                    {
                        txt_Codigo.Text = obj.produ_Codigo;
                        txt_Descripcion.Text = pr;
                        txt_Precio.Text = obj.produ_PrecioVenta.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Este producto no esta registrado, registre el producto el nombre: " + pr);
                        AgregarProducto p = new AgregarProducto();
                        p.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
        
        private void Apellido_cliente_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_cliente_Click(object sender, EventArgs e)
        {

        }
        
        private void TXT_DESCRIPCION_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXTIDESCUENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNMENU_Click(object sender, EventArgs e)
        {

        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {

        }


        private void BTNAGREGARFACTURA_Click(object sender, EventArgs e)
        {
            if (nmr_Cantidad.Value > 0)
            {
                using (SistemaLaConquistaEntities context = new SistemaLaConquistaEntities())
                {
                    var selectProducto = context.tbProducto.Where(x => x.produ_Codigo == txt_Codigo.Text && x.produ_Estado == true).Select(x => new SelectProductoViewModels
                    {
                        codigoProducto = x.produ_Codigo,
                        descripcionProducto = x.produ_Descripcion,
                        precioProducto = x.produ_PrecioVenta ?? 0,
                        cantidadProducto = x.produ_Cantidad ?? 0,
                        subTotalProducto = (x.produ_PrecioVenta ?? 0) * (x.produ_Cantidad ?? 0),
                    });
                    decimal SubTotal = Convert.ToDecimal(nmr_Cantidad.Value) * Convert.ToDecimal(txt_Precio.Text);
                    decimal Descuento = Math.Round(((SubTotal * nmr_Descuento.Value) / 100), 2);
                    decimal Total = Math.Round(((SubTotal - Descuento) > 0 ? (SubTotal - Descuento) : 0), 2);
                    dataGridViewProductosFactura.Rows.Add(txt_Codigo.Text, txt_Descripcion.Text, txt_Precio.Text, nmr_Cantidad.Value, SubTotal, Descuento, Total);

                    //que el precio tambien sea 0
                    txt_Codigo.Clear();
                    txt_Descripcion.Clear();
                    txt_Precio.Clear();

                    nmr_totalFactura.Value += (SubTotal - Descuento) > 0 ? (SubTotal - Descuento) : 0;

                    nmr_Cantidad.Value = 0;
                    nmr_Descuento.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(!txt_Codigo.Text.Trim().Equals(""))
            {
                BuscarPorProducto(txt_Codigo.Text.Trim());
            }
        }

        private void BuscarPorProducto(string busqueda = null)
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                //IQueryable<SelectProductoViewModels> buscarProducto = from d in db.tbProducto
                //                                              select new SelectProductoViewModels
                //                                              {
                //                                                  codigoProducto = d.produ_Codigo,
                //                                                  descripcionProducto = d.produ_Descripcion,
                //                                                  precioProducto = d.produ_PrecioVenta,
                //                                              };
                //if(busqueda != null)
                //{
                //   buscarProducto = buscarProducto.Where(d => d.codigoProducto == busqueda);
                //}
                //txt_Descripcion.Text = buscarProducto.ToString();
                //txt_Cantidad.Text = buscarProducto.ToString();
            }
        }

        private void BTNINGRESARCLIENTE_Click(object sender, EventArgs e)
        {
            //EvaluarExistencias(BTNINGRESARCLIENTE.Text);
        }

        private void evaluaTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pr = txt_Descripcion.Text;

                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    var producto = db.tbProducto.FirstOrDefault(x => x.produ_Descripcion == pr);

                    txt_Codigo.Text = producto.produ_Codigo;
                    txt_Descripcion.Text = producto.produ_Descripcion;
                    txt_Precio.Text = producto.produ_PrecioVenta.ToString();
                }

            }
        }

        private void BTNCOBRAR_Click(object sender, EventArgs e)
        {
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    var Filas = dataGridViewProductosFactura.Rows;

                    var registros = dataGridViewProductosFactura.Rows;

                    int c = 0;
                    int qRows = registros.Count;

                    string [][] conjuntodedatos;
                    conjuntodedatos = new string[qRows][];

                    List<DataGridViewRow> listofrows = new List<DataGridViewRow>();
                    foreach (DataGridViewRow item in registros)
                    {
                        conjuntodedatos[c] = new string[7];//item.Cells[i].Value.ToString();
                        for (int i = 0; i < item.Cells.Count; i++)
                        {
                            conjuntodedatos[c][i] = item.Cells[i].Value.ToString();
                        }
                        c++;
                    }

                    tbEncabezadoFactura encabezado = new tbEncabezadoFactura();
                    int idcliente = db.tbCliente.FirstOrDefault(x => (x.clint_Nombre + " " + x.clint_Apellido) == CBCLIENTEFACTURA.Text).clint_IdCliente;
                    
                    string dia = (DateTime.Now).Day.ToString();
                    string mes = (DateTime.Now).Month.ToString();
                    string annio = (DateTime.Now).Year.ToString();
                    string hora = (DateTime.Now).Hour.ToString();
                    string mnuto = (DateTime.Now).Minute.ToString();
                    string second = (DateTime.Now).Second.ToString();

                    string codigo = "" + 1 + dia + mes + annio + hora + mnuto + second;

                    decimal Subtotal = nmr_totalFactura.Value;
                    decimal isv = Math.Round(((nmrupdwnisv.Value * Subtotal) / 100), 2);
                    isv = isv > 0 ? isv : 0;
                    decimal final = Subtotal + isv;

                    encabezado.clint_IdCliente = idcliente;
                    encabezado.efact_CodigoFactura = codigo;
                    encabezado.efact_FechaFacturacion = DateTime.Now;
                    encabezado.efact_Subtotal = Subtotal;
                    encabezado.efact_Isv = isv;
                    encabezado.efact_Total = final;
                    encabezado.efact_Estado = true;
                    encabezado.UsuarioCrea = session.usuario.user_IdUsuario;
                    encabezado.FechaCrea = DateTime.Now;

                    db.tbEncabezadoFactura.Add(encabezado);
                    //ESTE REGRESALO db.SaveChanges();

                    int id = 11;//ESTE REGRESALO encabezado.fact_Id;
                    tbDetalleFactura dfact = null;
                    int productId = 0;

                    foreach (var item in conjuntodedatos)
                    { 
                        string pcode = item[0];
                        productId = db.tbProducto.First(x => x.produ_Codigo == pcode).produ_IdProducto;

                        dfact = new tbDetalleFactura();
                        dfact.fact_Id = encabezado.fact_Id;
                        dfact.produ_IdProducto = productId;
                        dfact.defact_DescripcionProducto = item[1];
                        dfact.defact_PrecioProducto = Convert.ToDecimal(item[2]);
                        dfact.defact_CantidadProducto = Convert.ToDecimal(item[3]);
                        dfact.defact_Subtotal = Convert.ToDecimal(item[4]);
                        dfact.defact_Descuento = Convert.ToDecimal(item[5]);
                        dfact.defact_Total = Convert.ToDecimal(item[6]);
                        dfact.defact_Estado = true;
                        dfact.UsuarioCrea = session.usuario.user_IdUsuario;
                        dfact.FechaCrea = DateTime.Now;

                        db.tbDetalleFactura.Add(dfact);
                        dfact = null;
                    }
                    try
                    {
                        //db.SaveChanges();
                        //En este imprimo factura

                        //Enviar el nomrbe del cliente y el codigo de la factura

                        CodigoFact = codigo;
                        NombreClient = CBCLIENTEFACTURA.Text;
                        
                        GlosubTotal = "" + Subtotal;
                        Gloisv = "" + isv;
                        Glototal = "" + final;

                        printDocument1 = new PrintDocument();
                        PrinterSettings confg = new PrinterSettings();
                        printDocument1.PrinterSettings = confg;
                        printDocument1.PrintPage += Imprime;
                        printDocument1.Print();

                    }
                    catch (Exception ex)
                    {
                        db.tbEncabezadoFactura.Remove(encabezado);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error." + ex.Message);
            }
        }

        private void Imprime(object sender, PrintPageEventArgs e)
        {
            Font f = new Font("Arial", 14);
            int w = 150, y = 20;

            e.Graphics.DrawString(
                "---• La conquista •---"
                , f
                , Brushes.Black
                , new Rectangle(0, y += 20, w, 20)
            );

            e.Graphics.DrawString(
                " Factura: " + CodigoFact
                , f
                , Brushes.Black
                , new Rectangle(0, y += 20, w, 20)
            );

            e.Graphics.DrawString(
                " Cliente: " + NombreClient
                , f
                , Brushes.Black
                , new Rectangle(0, y += 20, w, 20)
            );

            e.Graphics.DrawString(
                "---• PRODUCTOS •---"
                , f
                , Brushes.Black
                , new Rectangle(0, y += 30, w, 20)
            );

            e.Graphics.DrawString(
                "•Cantidad " + " " + "•Precio " + " " + "•Sub total" + " " + "•Producto" 
                , f
                , Brushes.Black
                , new Rectangle(0, y += 30, w, 20)
            );

            var registros = dataGridViewProductosFactura.Rows;
            int c = 0;
            int qRows = registros.Count;
            string[][] conjuntodedatos;
            conjuntodedatos = new string[qRows][];
            List<DataGridViewRow> listofrows = new List<DataGridViewRow>();
            foreach (DataGridViewRow item in registros)
            {
                conjuntodedatos[c] = new string[7];//item.Cells[i].Value.ToString();
                for (int i = 0; i < item.Cells.Count; i++)
                {
                    conjuntodedatos[c][i] = item.Cells[i].Value.ToString();
                }
                c++;
            }
            foreach (var item in conjuntodedatos)
            {
                string cant = item[3];
                string Precio = item[2];
                string sub = item[6];
                string producto = item[1];

                //imprimir productos
                e.Graphics.DrawString(
                    "" + cant + " " + Precio + " " + sub + " " + producto
                    , f
                    , Brushes.Black
                    , new Rectangle(0, y += 20, w, 20)
                );
            }

            e.Graphics.DrawString(
                "-Sub total: " + GlosubTotal
                , f
                , Brushes.Black
                , new Rectangle(0, y += 20, w, 20)
            );

            e.Graphics.DrawString(
                "-Isv: " + Gloisv
                , f
                , Brushes.Black
                , new Rectangle(0, y += 20, w, 20)
            );

            e.Graphics.DrawString(
                "-Total: " + Glototal
                , f
                , Brushes.Black
                , new Rectangle(0, y += 20, w, 20)
            );

        }
    }
}
