namespace LaConquista_WF
{
    partial class IngresarFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BTNINGRESARCLIENTE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.dataGridViewProductosFactura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNAGREGARFACTURA = new System.Windows.Forms.Button();
            this.BTNMENU = new System.Windows.Forms.Button();
            this.BTNCOBRAR = new System.Windows.Forms.Button();
            this.BTNREGISTRARPRODUCTOFACTURA = new System.Windows.Forms.Button();
            this.BTNELIMINARFACTURA = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFACTURA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCLIENTEFACTURA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmr_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.nmr_Descuento = new System.Windows.Forms.NumericUpDown();
            this.nmr_totalFactura = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrupdwnisv = new System.Windows.Forms.NumericUpDown();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_totalFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupdwnisv)).BeginInit();
            this.SuspendLayout();
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_cliente.Location = new System.Drawing.Point(195, 253);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(86, 15);
            this.Apellido_cliente.TabIndex = 21;
            this.Apellido_cliente.Text = "DESCRIPCION";
            this.Apellido_cliente.Click += new System.EventHandler(this.Apellido_cliente_Click);
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_cliente.Location = new System.Drawing.Point(51, 254);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(57, 15);
            this.Nombre_cliente.TabIndex = 20;
            this.Nombre_cliente.Text = "CÓDIGO";
            this.Nombre_cliente.Click += new System.EventHandler(this.Nombre_cliente_Click);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Codigo.Location = new System.Drawing.Point(107, 250);
            this.txt_Codigo.Multiline = true;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.ReadOnly = true;
            this.txt_Codigo.Size = new System.Drawing.Size(85, 22);
            this.txt_Codigo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "INGRESAR FACTURA";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(851, 151);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BTNINGRESARCLIENTE
            // 
            this.BTNINGRESARCLIENTE.BackColor = System.Drawing.Color.Salmon;
            this.BTNINGRESARCLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARCLIENTE.Location = new System.Drawing.Point(85, 95);
            this.BTNINGRESARCLIENTE.Name = "BTNINGRESARCLIENTE";
            this.BTNINGRESARCLIENTE.Size = new System.Drawing.Size(117, 37);
            this.BTNINGRESARCLIENTE.TabIndex = 25;
            this.BTNINGRESARCLIENTE.Text = "HUEVOS";
            this.BTNINGRESARCLIENTE.UseVisualStyleBackColor = false;
            this.BTNINGRESARCLIENTE.Click += new System.EventHandler(this.BTNINGRESARCLIENTE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(229, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "AZUCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(229, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "SAL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(85, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 28;
            this.button3.Text = "ARROZ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(85, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 37);
            this.button4.TabIndex = 29;
            this.button4.Text = "FRIJOLES";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(229, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 37);
            this.button5.TabIndex = 30;
            this.button5.Text = "CONSOME";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(510, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 37);
            this.button6.TabIndex = 36;
            this.button6.Text = "LECHE";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(366, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 37);
            this.button7.TabIndex = 35;
            this.button7.Text = "POLLO";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCoral;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(366, 182);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 37);
            this.button8.TabIndex = 34;
            this.button8.Text = "CHULETA";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightCoral;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(510, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 37);
            this.button9.TabIndex = 33;
            this.button9.Text = "QUESO";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightCoral;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(510, 138);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 37);
            this.button10.TabIndex = 32;
            this.button10.Text = "MANTEQUILLA";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightCoral;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(366, 95);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 37);
            this.button11.TabIndex = 31;
            this.button11.Text = "MORTADELA";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Tomato;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(791, 182);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(117, 37);
            this.button12.TabIndex = 42;
            this.button12.Text = "ZANAHORIA";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Tomato;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(648, 138);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(117, 37);
            this.button13.TabIndex = 41;
            this.button13.Text = "JUGO";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Tomato;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(648, 182);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 37);
            this.button14.TabIndex = 40;
            this.button14.Text = "REFRESCO";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Tomato;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(791, 95);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 37);
            this.button15.TabIndex = 39;
            this.button15.Text = "TOMATE";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Tomato;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(791, 138);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(117, 37);
            this.button16.TabIndex = 38;
            this.button16.Text = "CEBOLLA";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Tomato;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(648, 95);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(117, 37);
            this.button17.TabIndex = 37;
            this.button17.Text = "AGUA";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProductosFactura
            // 
            this.dataGridViewProductosFactura.AllowUserToAddRows = false;
            this.dataGridViewProductosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductosFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.Descuento,
            this.TotalProducto});
            this.dataGridViewProductosFactura.Location = new System.Drawing.Point(61, 288);
            this.dataGridViewProductosFactura.Name = "dataGridViewProductosFactura";
            this.dataGridViewProductosFactura.Size = new System.Drawing.Size(743, 173);
            this.dataGridViewProductosFactura.TabIndex = 43;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // TotalProducto
            // 
            this.TotalProducto.HeaderText = "Total Producto";
            this.TotalProducto.Name = "TotalProducto";
            this.TotalProducto.ReadOnly = true;
            // 
            // BTNAGREGARFACTURA
            // 
            this.BTNAGREGARFACTURA.BackColor = System.Drawing.Color.Black;
            this.BTNAGREGARFACTURA.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGARFACTURA.ForeColor = System.Drawing.Color.White;
            this.BTNAGREGARFACTURA.Location = new System.Drawing.Point(823, 296);
            this.BTNAGREGARFACTURA.Name = "BTNAGREGARFACTURA";
            this.BTNAGREGARFACTURA.Size = new System.Drawing.Size(112, 34);
            this.BTNAGREGARFACTURA.TabIndex = 44;
            this.BTNAGREGARFACTURA.Text = "AGREGAR";
            this.BTNAGREGARFACTURA.UseVisualStyleBackColor = false;
            this.BTNAGREGARFACTURA.Click += new System.EventHandler(this.BTNAGREGARFACTURA_Click);
            // 
            // BTNMENU
            // 
            this.BTNMENU.BackColor = System.Drawing.Color.Black;
            this.BTNMENU.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMENU.ForeColor = System.Drawing.Color.White;
            this.BTNMENU.Location = new System.Drawing.Point(52, 473);
            this.BTNMENU.Name = "BTNMENU";
            this.BTNMENU.Size = new System.Drawing.Size(117, 37);
            this.BTNMENU.TabIndex = 45;
            this.BTNMENU.Text = "MENÚ";
            this.BTNMENU.UseVisualStyleBackColor = false;
            this.BTNMENU.Click += new System.EventHandler(this.BTNMENU_Click);
            // 
            // BTNCOBRAR
            // 
            this.BTNCOBRAR.BackColor = System.Drawing.Color.Black;
            this.BTNCOBRAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCOBRAR.ForeColor = System.Drawing.Color.White;
            this.BTNCOBRAR.Location = new System.Drawing.Point(365, 473);
            this.BTNCOBRAR.Name = "BTNCOBRAR";
            this.BTNCOBRAR.Size = new System.Drawing.Size(117, 37);
            this.BTNCOBRAR.TabIndex = 46;
            this.BTNCOBRAR.Text = "COBRAR";
            this.BTNCOBRAR.UseVisualStyleBackColor = false;
            this.BTNCOBRAR.Click += new System.EventHandler(this.BTNCOBRAR_Click);
            // 
            // BTNREGISTRARPRODUCTOFACTURA
            // 
            this.BTNREGISTRARPRODUCTOFACTURA.BackColor = System.Drawing.Color.Black;
            this.BTNREGISTRARPRODUCTOFACTURA.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREGISTRARPRODUCTOFACTURA.ForeColor = System.Drawing.Color.White;
            this.BTNREGISTRARPRODUCTOFACTURA.Location = new System.Drawing.Point(822, 374);
            this.BTNREGISTRARPRODUCTOFACTURA.Name = "BTNREGISTRARPRODUCTOFACTURA";
            this.BTNREGISTRARPRODUCTOFACTURA.Size = new System.Drawing.Size(117, 46);
            this.BTNREGISTRARPRODUCTOFACTURA.TabIndex = 47;
            this.BTNREGISTRARPRODUCTOFACTURA.Text = "REGISTRAR PRODUCTO";
            this.BTNREGISTRARPRODUCTOFACTURA.UseVisualStyleBackColor = false;
            // 
            // BTNELIMINARFACTURA
            // 
            this.BTNELIMINARFACTURA.BackColor = System.Drawing.Color.Black;
            this.BTNELIMINARFACTURA.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINARFACTURA.ForeColor = System.Drawing.Color.White;
            this.BTNELIMINARFACTURA.Location = new System.Drawing.Point(822, 426);
            this.BTNELIMINARFACTURA.Name = "BTNELIMINARFACTURA";
            this.BTNELIMINARFACTURA.Size = new System.Drawing.Size(117, 37);
            this.BTNELIMINARFACTURA.TabIndex = 48;
            this.BTNELIMINARFACTURA.Text = "ELIMINAR";
            this.BTNELIMINARFACTURA.UseVisualStyleBackColor = false;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Black;
            this.BTNSALIR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.Color.White;
            this.BTNSALIR.Location = new System.Drawing.Point(207, 473);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(117, 37);
            this.BTNSALIR.TabIndex = 49;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(610, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "TOTAL";
            // 
            // DTPFACTURA
            // 
            this.DTPFACTURA.Location = new System.Drawing.Point(111, 44);
            this.DTPFACTURA.Name = "DTPFACTURA";
            this.DTPFACTURA.Size = new System.Drawing.Size(283, 22);
            this.DTPFACTURA.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "CLIENTE";
            // 
            // CBCLIENTEFACTURA
            // 
            this.CBCLIENTEFACTURA.FormattingEnabled = true;
            this.CBCLIENTEFACTURA.Location = new System.Drawing.Point(460, 44);
            this.CBCLIENTEFACTURA.Name = "CBCLIENTEFACTURA";
            this.CBCLIENTEFACTURA.Size = new System.Drawing.Size(457, 23);
            this.CBCLIENTEFACTURA.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "FECHA";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Black;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(824, 336);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(111, 31);
            this.button18.TabIndex = 58;
            this.button18.Text = "BUSCAR";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "PRECIO";
            // 
            // txt_Precio
            // 
            this.txt_Precio.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Precio.Location = new System.Drawing.Point(515, 250);
            this.txt_Precio.Multiline = true;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(84, 23);
            this.txt_Precio.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "CANTIDAD";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(288, 250);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(173, 22);
            this.txt_Descripcion.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(762, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "DESCUENTO %";
            // 
            // nmr_Cantidad
            // 
            this.nmr_Cantidad.Location = new System.Drawing.Point(673, 250);
            this.nmr_Cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmr_Cantidad.Name = "nmr_Cantidad";
            this.nmr_Cantidad.Size = new System.Drawing.Size(84, 22);
            this.nmr_Cantidad.TabIndex = 66;
            // 
            // nmr_Descuento
            // 
            this.nmr_Descuento.DecimalPlaces = 2;
            this.nmr_Descuento.Location = new System.Drawing.Point(857, 251);
            this.nmr_Descuento.Name = "nmr_Descuento";
            this.nmr_Descuento.Size = new System.Drawing.Size(73, 22);
            this.nmr_Descuento.TabIndex = 67;
            // 
            // nmr_totalFactura
            // 
            this.nmr_totalFactura.DecimalPlaces = 2;
            this.nmr_totalFactura.Location = new System.Drawing.Point(699, 485);
            this.nmr_totalFactura.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nmr_totalFactura.Name = "nmr_totalFactura";
            this.nmr_totalFactura.Size = new System.Drawing.Size(231, 22);
            this.nmr_totalFactura.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Goldenrod;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(637, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "ISV%";
            // 
            // nmrupdwnisv
            // 
            this.nmrupdwnisv.DecimalPlaces = 2;
            this.nmrupdwnisv.Location = new System.Drawing.Point(699, 521);
            this.nmrupdwnisv.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nmrupdwnisv.Name = "nmrupdwnisv";
            this.nmrupdwnisv.Size = new System.Drawing.Size(66, 22);
            this.nmrupdwnisv.TabIndex = 70;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprime);
            // 
            // IngresarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1030, 554);
            this.Controls.Add(this.nmrupdwnisv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmr_totalFactura);
            this.Controls.Add(this.nmr_Descuento);
            this.Controls.Add(this.nmr_Cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBCLIENTEFACTURA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPFACTURA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNELIMINARFACTURA);
            this.Controls.Add(this.BTNREGISTRARPRODUCTOFACTURA);
            this.Controls.Add(this.BTNCOBRAR);
            this.Controls.Add(this.BTNMENU);
            this.Controls.Add(this.BTNAGREGARFACTURA);
            this.Controls.Add(this.dataGridViewProductosFactura);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNINGRESARCLIENTE);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IngresarFactura";
            this.Text = "IngresarFactura";
            this.Load += new System.EventHandler(this.IngresarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_totalFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupdwnisv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BTNINGRESARCLIENTE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.DataGridView dataGridViewProductosFactura;
        private System.Windows.Forms.Button BTNAGREGARFACTURA;
        private System.Windows.Forms.Button BTNMENU;
        private System.Windows.Forms.Button BTNCOBRAR;
        private System.Windows.Forms.Button BTNREGISTRARPRODUCTOFACTURA;
        private System.Windows.Forms.Button BTNELIMINARFACTURA;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFACTURA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBCLIENTEFACTURA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmr_Cantidad;
        private System.Windows.Forms.NumericUpDown nmr_Descuento;
        private System.Windows.Forms.NumericUpDown nmr_totalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrupdwnisv;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}