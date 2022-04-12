namespace GENCODE
{
    partial class Form1
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
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMejora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVariable = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtWB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBL = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBERest = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtBEDatos = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textaspx = new System.Windows.Forms.TextBox();
            this.cboLimpiar = new System.Windows.Forms.Button();
            this.btnExpBEDatos = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto";
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(67, 6);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(100, 20);
            this.txtProyecto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Service";
            // 
            // cboService
            // 
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "StoreProcedure",
            "RestService",
            "DataPower"});
            this.cboService.Location = new System.Drawing.Point(246, 6);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(121, 21);
            this.cboService.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mejora";
            // 
            // txtMejora
            // 
            this.txtMejora.Location = new System.Drawing.Point(418, 7);
            this.txtMejora.Name = "txtMejora";
            this.txtMejora.Size = new System.Drawing.Size(100, 20);
            this.txtMejora.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Metodo";
            // 
            // btnVariable
            // 
            this.btnVariable.Location = new System.Drawing.Point(717, 6);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(147, 23);
            this.btnVariable.TabIndex = 9;
            this.btnVariable.Text = "Variables";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 448);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtWB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WB";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtWB
            // 
            this.txtWB.Location = new System.Drawing.Point(0, 0);
            this.txtWB.Multiline = true;
            this.txtWB.Name = "txtWB";
            this.txtWB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWB.Size = new System.Drawing.Size(695, 426);
            this.txtWB.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBL
            // 
            this.txtBL.Location = new System.Drawing.Point(-4, 0);
            this.txtBL.Multiline = true;
            this.txtBL.Name = "txtBL";
            this.txtBL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBL.Size = new System.Drawing.Size(695, 426);
            this.txtBL.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBERest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(691, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Request";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBERest
            // 
            this.txtBERest.Location = new System.Drawing.Point(-4, 0);
            this.txtBERest.Multiline = true;
            this.txtBERest.Name = "txtBERest";
            this.txtBERest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBERest.Size = new System.Drawing.Size(695, 426);
            this.txtBERest.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtConsumo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(691, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Response";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(-1, 0);
            this.txtConsumo.Multiline = true;
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsumo.Size = new System.Drawing.Size(692, 426);
            this.txtConsumo.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtBEDatos);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(691, 422);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "BEDatos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtBEDatos
            // 
            this.txtBEDatos.Location = new System.Drawing.Point(-2, -2);
            this.txtBEDatos.Multiline = true;
            this.txtBEDatos.Name = "txtBEDatos";
            this.txtBEDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBEDatos.Size = new System.Drawing.Size(695, 426);
            this.txtBEDatos.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textaspx);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(691, 422);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Aspx";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textaspx
            // 
            this.textaspx.Location = new System.Drawing.Point(-1, 0);
            this.textaspx.Multiline = true;
            this.textaspx.Name = "textaspx";
            this.textaspx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textaspx.Size = new System.Drawing.Size(692, 426);
            this.textaspx.TabIndex = 0;
            // 
            // cboLimpiar
            // 
            this.cboLimpiar.Location = new System.Drawing.Point(717, 320);
            this.cboLimpiar.Name = "cboLimpiar";
            this.cboLimpiar.Size = new System.Drawing.Size(147, 23);
            this.cboLimpiar.TabIndex = 11;
            this.cboLimpiar.Text = "Limpiar";
            this.cboLimpiar.UseVisualStyleBackColor = true;
            this.cboLimpiar.Click += new System.EventHandler(this.cboLimpiar_Click);
            // 
            // btnExpBEDatos
            // 
            this.btnExpBEDatos.Location = new System.Drawing.Point(718, 349);
            this.btnExpBEDatos.Name = "btnExpBEDatos";
            this.btnExpBEDatos.Size = new System.Drawing.Size(147, 23);
            this.btnExpBEDatos.TabIndex = 16;
            this.btnExpBEDatos.Text = "Exportar";
            this.btnExpBEDatos.UseVisualStyleBackColor = true;
            this.btnExpBEDatos.Click += new System.EventHandler(this.btnExpBEDatos_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(717, 291);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(147, 23);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(589, 7);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 20;
            // 
            // txtPagina
            // 
            this.txtPagina.Location = new System.Drawing.Point(765, 111);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(100, 20);
            this.txtPagina.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pagina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 506);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnExpBEDatos);
            this.Controls.Add(this.cboLimpiar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMejora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GENCODE V1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMejora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtWB;
        private System.Windows.Forms.TextBox txtBL;
        private System.Windows.Forms.TextBox txtBERest;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtBEDatos;
        public System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Button cboLimpiar;
        private System.Windows.Forms.Button btnExpBEDatos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textaspx;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.Label label5;
    }
}

