namespace Automatizacion
{
    partial class InputJson
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
            this.txtJsonVariables = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarVariables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJsonVariables
            // 
            this.txtJsonVariables.Location = new System.Drawing.Point(12, 53);
            this.txtJsonVariables.Multiline = true;
            this.txtJsonVariables.Name = "txtJsonVariables";
            this.txtJsonVariables.Size = new System.Drawing.Size(383, 325);
            this.txtJsonVariables.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese JSON válido";
            // 
            // btnAgregarVariables
            // 
            this.btnAgregarVariables.Location = new System.Drawing.Point(148, 396);
            this.btnAgregarVariables.Name = "btnAgregarVariables";
            this.btnAgregarVariables.Size = new System.Drawing.Size(114, 23);
            this.btnAgregarVariables.TabIndex = 2;
            this.btnAgregarVariables.Text = "Agregar";
            this.btnAgregarVariables.UseVisualStyleBackColor = true;
            this.btnAgregarVariables.Click += new System.EventHandler(this.btnAgregarVariables_Click);
            // 
            // InputJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 452);
            this.Controls.Add(this.btnAgregarVariables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJsonVariables);
            this.Name = "InputJson";
            this.Text = "InputJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJsonVariables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarVariables;
    }
}