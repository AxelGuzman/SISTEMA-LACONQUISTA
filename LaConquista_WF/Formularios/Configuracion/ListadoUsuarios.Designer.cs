namespace LaConquista_WF
{
    partial class ListadoUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.BTNSALIRUSUARIO = new System.Windows.Forms.Button();
            this.BTNINGRESARUSUARIO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUSUARIOS = new System.Windows.Forms.DataGridView();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLaConquistaDataSet = new LaConquista_WF.SistemaLaConquistaDataSet();
            this.tbUsuarioTableAdapter = new LaConquista_WF.SistemaLaConquistaDataSetTableAdapters.tbUsuarioTableAdapter();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEstadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIRUSUARIO
            // 
            this.BTNSALIRUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRUSUARIO.Location = new System.Drawing.Point(424, 338);
            this.BTNSALIRUSUARIO.Name = "BTNSALIRUSUARIO";
            this.BTNSALIRUSUARIO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRUSUARIO.TabIndex = 9;
            this.BTNSALIRUSUARIO.Text = "SALIR";
            this.BTNSALIRUSUARIO.UseVisualStyleBackColor = false;
            // 
            // BTNINGRESARUSUARIO
            // 
            this.BTNINGRESARUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARUSUARIO.Location = new System.Drawing.Point(110, 338);
            this.BTNINGRESARUSUARIO.Name = "BTNINGRESARUSUARIO";
            this.BTNINGRESARUSUARIO.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARUSUARIO.TabIndex = 8;
            this.BTNINGRESARUSUARIO.Text = "INGRESAR";
            this.BTNINGRESARUSUARIO.UseVisualStyleBackColor = false;
            this.BTNINGRESARUSUARIO.Click += new System.EventHandler(this.BTNINGRESARUSUARIO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTADO DE USUARIOS";
            // 
            // dataGridViewUSUARIOS
            // 
            this.dataGridViewUSUARIOS.AutoGenerateColumns = false;
            this.dataGridViewUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUSUARIOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Usuario,
            this.Creado,
            this.userEstadoDataGridViewCheckBoxColumn});
            this.dataGridViewUSUARIOS.DataSource = this.tbUsuarioBindingSource;
            this.dataGridViewUSUARIOS.Location = new System.Drawing.Point(99, 73);
            this.dataGridViewUSUARIOS.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUSUARIOS.MultiSelect = false;
            this.dataGridViewUSUARIOS.Name = "dataGridViewUSUARIOS";
            this.dataGridViewUSUARIOS.ReadOnly = true;
            this.dataGridViewUSUARIOS.RowTemplate.Height = 24;
            this.dataGridViewUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUSUARIOS.Size = new System.Drawing.Size(443, 228);
            this.dataGridViewUSUARIOS.TabIndex = 10;
            this.dataGridViewUSUARIOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUSUARIOS_CellContentClick_1);
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.sistemaLaConquistaDataSet;
            // 
            // sistemaLaConquistaDataSet
            // 
            this.sistemaLaConquistaDataSet.DataSetName = "SistemaLaConquistaDataSet";
            this.sistemaLaConquistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(216, 338);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 32);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(321, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "user_IdUsuario";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "user_Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "user_Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "user_NombreUsuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Creado
            // 
            this.Creado.DataPropertyName = "user_FechaCreacion";
            this.Creado.HeaderText = "Creado";
            this.Creado.Name = "Creado";
            this.Creado.ReadOnly = true;
            // 
            // userEstadoDataGridViewCheckBoxColumn
            // 
            this.userEstadoDataGridViewCheckBoxColumn.DataPropertyName = "user_Estado";
            this.userEstadoDataGridViewCheckBoxColumn.HeaderText = "user_Estado";
            this.userEstadoDataGridViewCheckBoxColumn.Name = "userEstadoDataGridViewCheckBoxColumn";
            this.userEstadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.userEstadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(641, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridViewUSUARIOS);
            this.Controls.Add(this.BTNSALIRUSUARIO);
            this.Controls.Add(this.BTNINGRESARUSUARIO);
            this.Controls.Add(this.label1);
            this.Name = "ListadoUsuarios";
            this.Text = "ListadoUsuarios";
            this.Load += new System.EventHandler(this.ListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIRUSUARIO;
        private System.Windows.Forms.Button BTNINGRESARUSUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUSUARIOS;
        private SistemaLaConquistaDataSet sistemaLaConquistaDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private SistemaLaConquistaDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userEstadoDataGridViewCheckBoxColumn;
    }
}