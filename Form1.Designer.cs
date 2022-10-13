
namespace Solidos_en_revolucion
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
            this.dibujar = new System.Windows.Forms.PictureBox();
            this.rotacion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dibujar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dibujar
            // 
            this.dibujar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dibujar.Location = new System.Drawing.Point(0, 0);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(800, 450);
            this.dibujar.TabIndex = 0;
            this.dibujar.TabStop = false;
            this.dibujar.Paint += new System.Windows.Forms.PaintEventHandler(this.dibujar_Paint);
            // 
            // rotacion
            // 
            this.rotacion.Location = new System.Drawing.Point(644, 389);
            this.rotacion.Name = "rotacion";
            this.rotacion.Size = new System.Drawing.Size(120, 20);
            this.rotacion.TabIndex = 1;
            this.rotacion.ValueChanged += new System.EventHandler(this.rotacion_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rotacion);
            this.Controls.Add(this.dibujar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dibujar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dibujar;
        private System.Windows.Forms.NumericUpDown rotacion;
    }
}

