namespace LaConquista_WF.Formularios.Proveedores
{
    partial class alterarEstado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_REGISTRO = new System.Windows.Forms.Label();
            this.BTNCAMBIAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_ESTASDOACTUAL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alteración del estado\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Registro:";
            // 
            // LBL_REGISTRO
            // 
            this.LBL_REGISTRO.AutoSize = true;
            this.LBL_REGISTRO.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_REGISTRO.Location = new System.Drawing.Point(255, 106);
            this.LBL_REGISTRO.Name = "LBL_REGISTRO";
            this.LBL_REGISTRO.Size = new System.Drawing.Size(72, 20);
            this.LBL_REGISTRO.TabIndex = 16;
            this.LBL_REGISTRO.Text = "Defecto.";
            // 
            // BTNCAMBIAR
            // 
            this.BTNCAMBIAR.BackColor = System.Drawing.Color.Black;
            this.BTNCAMBIAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCAMBIAR.ForeColor = System.Drawing.Color.White;
            this.BTNCAMBIAR.Location = new System.Drawing.Point(55, 262);
            this.BTNCAMBIAR.Name = "BTNCAMBIAR";
            this.BTNCAMBIAR.Size = new System.Drawing.Size(359, 32);
            this.BTNCAMBIAR.TabIndex = 17;
            this.BTNCAMBIAR.Text = "INGRESAR";
            this.BTNCAMBIAR.UseVisualStyleBackColor = false;
            this.BTNCAMBIAR.Click += new System.EventHandler(this.BTNCAMBIAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado actual:";
            // 
            // LBL_ESTASDOACTUAL
            // 
            this.LBL_ESTASDOACTUAL.AutoSize = true;
            this.LBL_ESTASDOACTUAL.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ESTASDOACTUAL.Location = new System.Drawing.Point(255, 165);
            this.LBL_ESTASDOACTUAL.Name = "LBL_ESTASDOACTUAL";
            this.LBL_ESTASDOACTUAL.Size = new System.Drawing.Size(72, 20);
            this.LBL_ESTASDOACTUAL.TabIndex = 19;
            this.LBL_ESTASDOACTUAL.Text = "Defecto.";
            // 
            // alterarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(466, 344);
            this.Controls.Add(this.LBL_ESTASDOACTUAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNCAMBIAR);
            this.Controls.Add(this.LBL_REGISTRO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alterarEstado";
            this.Text = "alterarEstado";
            this.Load += new System.EventHandler(this.alterarEstado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_REGISTRO;
        private System.Windows.Forms.Button BTNCAMBIAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_ESTASDOACTUAL;
    }
}