namespace Test1
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
            this.btnDispositivo = new System.Windows.Forms.Button();
            this.btnComputadora = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDispositivo
            // 
            this.btnDispositivo.Location = new System.Drawing.Point(241, 80);
            this.btnDispositivo.Name = "btnDispositivo";
            this.btnDispositivo.Size = new System.Drawing.Size(114, 59);
            this.btnDispositivo.TabIndex = 0;
            this.btnDispositivo.Text = "Dispositivo";
            this.btnDispositivo.UseVisualStyleBackColor = true;
            this.btnDispositivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComputadora
            // 
            this.btnComputadora.Location = new System.Drawing.Point(241, 145);
            this.btnComputadora.Name = "btnComputadora";
            this.btnComputadora.Size = new System.Drawing.Size(114, 64);
            this.btnComputadora.TabIndex = 1;
            this.btnComputadora.Text = "Computadora";
            this.btnComputadora.UseVisualStyleBackColor = true;
            this.btnComputadora.Click += new System.EventHandler(this.btnComputadora_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.Location = new System.Drawing.Point(241, 215);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(114, 54);
            this.btnLaptop.TabIndex = 2;
            this.btnLaptop.Text = "Laptop";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 442);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.btnComputadora);
            this.Controls.Add(this.btnDispositivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDispositivo;
        private System.Windows.Forms.Button btnComputadora;
        private System.Windows.Forms.Button btnLaptop;
    }
}

