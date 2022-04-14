namespace Automatizacion
{
    partial class formVersVisual
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVisual2010 = new System.Windows.Forms.Button();
            this.btnVisual2013 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisual2010
            // 
            this.btnVisual2010.Location = new System.Drawing.Point(144, 96);
            this.btnVisual2010.Name = "btnVisual2010";
            this.btnVisual2010.Size = new System.Drawing.Size(75, 23);
            this.btnVisual2010.TabIndex = 0;
            this.btnVisual2010.Text = "Visual 2010";
            this.btnVisual2010.UseVisualStyleBackColor = true;
            // 
            // btnVisual2013
            // 
            this.btnVisual2013.Location = new System.Drawing.Point(144, 174);
            this.btnVisual2013.Name = "btnVisual2013";
            this.btnVisual2013.Size = new System.Drawing.Size(75, 23);
            this.btnVisual2013.TabIndex = 1;
            this.btnVisual2013.Text = "Visual2013";
            this.btnVisual2013.UseVisualStyleBackColor = true;
            this.btnVisual2013.Click += new System.EventHandler(this.btnVisual2013_Click);
            // 
            // formVersVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 504);
            this.Controls.Add(this.btnVisual2013);
            this.Controls.Add(this.btnVisual2010);
            this.Name = "formVersVisual";
            this.Text = "Eleccion de Vers Visual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisual2010;
        private System.Windows.Forms.Button btnVisual2013;
    }
}

