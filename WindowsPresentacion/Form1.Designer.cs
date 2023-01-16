namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMedico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresoNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(130, 105);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(84, 23);
            this.btnMedico.TabIndex = 0;
            this.btnMedico.Text = "Crear médico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar nombre del médico:";
            // 
            // txtIngresoNombre
            // 
            this.txtIngresoNombre.Location = new System.Drawing.Point(108, 59);
            this.txtIngresoNombre.Name = "txtIngresoNombre";
            this.txtIngresoNombre.Size = new System.Drawing.Size(137, 20);
            this.txtIngresoNombre.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 163);
            this.Controls.Add(this.txtIngresoNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresoNombre;
    }
}

