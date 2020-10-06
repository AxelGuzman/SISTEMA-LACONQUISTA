namespace LaConquista_WF.Formularios.Proveedores
{
    partial class ListadoDeProveedores
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BTNSALIRUSUARIO = new System.Windows.Forms.Button();
            this.BTNINGRESARUSUARIO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProveedores = new System.Windows.Forms.DataGridView();
            this.listProveedoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listProveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioModificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaModifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProveedoresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(506, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(401, 482);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 31);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BTNSALIRUSUARIO
            // 
            this.BTNSALIRUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRUSUARIO.Location = new System.Drawing.Point(609, 482);
            this.BTNSALIRUSUARIO.Name = "BTNSALIRUSUARIO";
            this.BTNSALIRUSUARIO.Size = new System.Drawing.Size(100, 31);
            this.BTNSALIRUSUARIO.TabIndex = 15;
            this.BTNSALIRUSUARIO.Text = "SALIR";
            this.BTNSALIRUSUARIO.UseVisualStyleBackColor = false;
            // 
            // BTNINGRESARUSUARIO
            // 
            this.BTNINGRESARUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARUSUARIO.Location = new System.Drawing.Point(295, 482);
            this.BTNINGRESARUSUARIO.Name = "BTNINGRESARUSUARIO";
            this.BTNINGRESARUSUARIO.Size = new System.Drawing.Size(100, 31);
            this.BTNINGRESARUSUARIO.TabIndex = 14;
            this.BTNINGRESARUSUARIO.Text = "INGRESAR";
            this.BTNINGRESARUSUARIO.UseVisualStyleBackColor = false;
            this.BTNINGRESARUSUARIO.Click += new System.EventHandler(this.BTNINGRESARUSUARIO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "LISTADO DE PROVEEDORES";
            // 
            // dataGridViewProveedores
            // 
            this.dataGridViewProveedores.AutoGenerateColumns = false;
            this.dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Identificacion,
            this.Contacto,
            this.Email,
            this.UsuarioCreado,
            this.FechaCrea,
            this.UsuarioModificado,
            this.FechaModifica,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridViewProveedores.DataSource = this.listProveedoresBindingSource2;
            this.dataGridViewProveedores.Location = new System.Drawing.Point(76, 75);
            this.dataGridViewProveedores.MultiSelect = false;
            this.dataGridViewProveedores.Name = "dataGridViewProveedores";
            this.dataGridViewProveedores.ReadOnly = true;
            this.dataGridViewProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProveedores.Size = new System.Drawing.Size(844, 351);
            this.dataGridViewProveedores.TabIndex = 18;
            // 
            // listProveedoresBindingSource2
            // 
            this.listProveedoresBindingSource2.DataSource = typeof(LaConquista_WF.Models.Parciales.Proveedores.listProveedores);
            // 
            // listProveedoresBindingSource1
            // 
            this.listProveedoresBindingSource1.DataSource = typeof(LaConquista_WF.Models.Parciales.Proveedores.listProveedores);
            // 
            // listProveedoresBindingSource
            // 
            this.listProveedoresBindingSource.DataSource = typeof(LaConquista_WF.Models.Parciales.Proveedores.listProveedores);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "Contacto";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // UsuarioCreado
            // 
            this.UsuarioCreado.DataPropertyName = "UsuarioCreado";
            this.UsuarioCreado.HeaderText = "UsuarioCreado";
            this.UsuarioCreado.Name = "UsuarioCreado";
            this.UsuarioCreado.ReadOnly = true;
            // 
            // FechaCrea
            // 
            this.FechaCrea.DataPropertyName = "FechaCrea";
            this.FechaCrea.HeaderText = "FechaCrea";
            this.FechaCrea.Name = "FechaCrea";
            this.FechaCrea.ReadOnly = true;
            // 
            // UsuarioModificado
            // 
            this.UsuarioModificado.DataPropertyName = "UsuarioModificado";
            this.UsuarioModificado.HeaderText = "UsuarioModificado";
            this.UsuarioModificado.Name = "UsuarioModificado";
            this.UsuarioModificado.ReadOnly = true;
            // 
            // FechaModifica
            // 
            this.FechaModifica.DataPropertyName = "FechaModifica";
            this.FechaModifica.HeaderText = "FechaModifica";
            this.FechaModifica.Name = "FechaModifica";
            this.FechaModifica.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ListadoDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1002, 549);
            this.Controls.Add(this.dataGridViewProveedores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.BTNSALIRUSUARIO);
            this.Controls.Add(this.BTNINGRESARUSUARIO);
            this.Controls.Add(this.label1);
            this.Name = "ListadoDeProveedores";
            this.Text = "ListadoDeProveedores";
            this.Load += new System.EventHandler(this.ListadoDeProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProveedoresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BTNSALIRUSUARIO;
        private System.Windows.Forms.Button BTNINGRESARUSUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProveedores;
        private System.Windows.Forms.BindingSource listProveedoresBindingSource;
        private System.Windows.Forms.BindingSource listProveedoresBindingSource1;
        private System.Windows.Forms.BindingSource listProveedoresBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCreado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioModificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}