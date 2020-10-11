namespace LaConquista_WF.Formularios.Proveedores
{
    partial class inhabilitar
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
            this.BTN_CANCELAR = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desea inhabilitar este registro?";
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackColor = System.Drawing.Color.Black;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(363, 193);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(100, 32);
            this.BTN_CANCELAR.TabIndex = 26;
            this.BTN_CANCELAR.Text = "CANCELAR";
            this.BTN_CANCELAR.UseVisualStyleBackColor = false;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.Black;
            this.BTN_GUARDAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GUARDAR.ForeColor = System.Drawing.Color.White;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(170, 193);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(100, 32);
            this.BTN_GUARDAR.TabIndex = 25;
            this.BTN_GUARDAR.Text = "GUARDAR";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(248, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = ":";
            // 
            // inhabilitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(624, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.label1);
            this.Name = "inhabilitar";
            this.Text = "inhabilitar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CANCELAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Label label2;
    }
}