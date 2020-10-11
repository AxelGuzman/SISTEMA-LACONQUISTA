namespace LaConquista_WF.Formularios.Generales
{
    partial class Inhabilitar
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
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_CANCELAR = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desea inhabilitar este registro?";
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.Black;
            this.BTN_GUARDAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GUARDAR.ForeColor = System.Drawing.Color.White;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(100, 247);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(100, 32);
            this.BTN_GUARDAR.TabIndex = 23;
            this.BTN_GUARDAR.Text = "GUARDAR";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackColor = System.Drawing.Color.Black;
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(293, 247);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(100, 32);
            this.BTN_CANCELAR.TabIndex = 24;
            this.BTN_CANCELAR.Text = "CANCELAR";
            this.BTN_CANCELAR.UseVisualStyleBackColor = false;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(116, 148);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(254, 20);
            this.labelRegistro.TabIndex = 25;
            this.labelRegistro.Text = "Desea inhabilitar este registro?";
            // 
            // Inhabilitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(465, 326);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.label1);
            this.Name = "Inhabilitar";
            this.Text = "Inhabilitar";
            this.Load += new System.EventHandler(this.Inhabilitar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_CANCELAR;
        private System.Windows.Forms.Label labelRegistro;
    }
}