namespace Automatizacion
{
    partial class formAutomatizacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspCmbTipoServicio = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreVariableRequest = new System.Windows.Forms.TextBox();
            this.cmbTipoVariableRequest = new System.Windows.Forms.ComboBox();
            this.dgvVariablesRequest = new System.Windows.Forms.DataGridView();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslAgregarRequest = new System.Windows.Forms.ToolStripLabel();
            this.tslAgregarResponse = new System.Windows.Forms.ToolStripLabel();
            this.tslQuitarRequest = new System.Windows.Forms.ToolStripLabel();
            this.tslQuitarResponse = new System.Windows.Forms.ToolStripLabel();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreMetodo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.dgvVariablesResponse = new System.Windows.Forms.DataGridView();
            this.cbmTipoVariableResponse = new System.Windows.Forms.ComboBox();
            this.txtNombreVariableResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreClaseResponse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreClaseRequest = new System.Windows.Forms.TextBox();
            this.btnGenerarCodigo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRequest = new System.Windows.Forms.TabPage();
            this.txtClaseRequest = new System.Windows.Forms.TextBox();
            this.tabResponse = new System.Windows.Forms.TabPage();
            this.txtClaseResponse = new System.Windows.Forms.TextBox();
            this.tabMetodoConsumo = new System.Windows.Forms.TabPage();
            this.txtMetodoConsumo = new System.Windows.Forms.TextBox();
            this.gbVariableListaRequest = new System.Windows.Forms.GroupBox();
            this.btnAgregarVariablesListRequest = new System.Windows.Forms.Button();
            this.dgvVariablesListaRequest = new System.Windows.Forms.DataGridView();
            this.cmbTipoVariableListaRequest = new System.Windows.Forms.ComboBox();
            this.txtNombreVariableListaRequest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbVariableListaResponse = new System.Windows.Forms.GroupBox();
            this.btnAgregarVariablesListResponse = new System.Windows.Forms.Button();
            this.dgvVariablesListaResponse = new System.Windows.Forms.DataGridView();
            this.cmbTipoVariableListaResponse = new System.Windows.Forms.ComboBox();
            this.txtNombreVariablesListaResponse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddVariablesRequestMasivo = new System.Windows.Forms.Button();
            this.btnAddVariablesResponseMasivo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesRequest)).BeginInit();
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesResponse)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabResponse.SuspendLayout();
            this.tabMetodoConsumo.SuspendLayout();
            this.gbVariableListaRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesListaRequest)).BeginInit();
            this.gbVariableListaResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesListaResponse)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspCmbTipoServicio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1619, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspCmbTipoServicio
            // 
            this.tspCmbTipoServicio.AutoCompleteCustomSource.AddRange(new string[] {
            "DATAPOWER",
            "REST",
            "STORE-PROCEDURE"});
            this.tspCmbTipoServicio.Items.AddRange(new object[] {
            "API_REST",
            "DATAPOWER",
            "SP"});
            this.tspCmbTipoServicio.Name = "tspCmbTipoServicio";
            this.tspCmbTipoServicio.Size = new System.Drawing.Size(121, 27);
            this.tspCmbTipoServicio.Text = "Seleccione Tipo de Consumo de Datos";
            this.tspCmbTipoServicio.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "Nombre de Variable";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "TipoVariable";
            // 
            // txtNombreVariableRequest
            // 
            this.txtNombreVariableRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVariableRequest.Location = new System.Drawing.Point(167, 133);
            this.txtNombreVariableRequest.Name = "txtNombreVariableRequest";
            this.txtNombreVariableRequest.Size = new System.Drawing.Size(144, 28);
            this.txtNombreVariableRequest.TabIndex = 2;
            // 
            // cmbTipoVariableRequest
            // 
            this.cmbTipoVariableRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVariableRequest.FormattingEnabled = true;
            this.cmbTipoVariableRequest.Items.AddRange(new object[] {
            "String",
            "Int",
            "List",
            "Object",
            "Double",
            "Float"});
            this.cmbTipoVariableRequest.Location = new System.Drawing.Point(167, 173);
            this.cmbTipoVariableRequest.Name = "cmbTipoVariableRequest";
            this.cmbTipoVariableRequest.Size = new System.Drawing.Size(144, 30);
            this.cmbTipoVariableRequest.TabIndex = 3;
            // 
            // dgvVariablesRequest
            // 
            this.dgvVariablesRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariablesRequest.Location = new System.Drawing.Point(10, 212);
            this.dgvVariablesRequest.Name = "dgvVariablesRequest";
            this.dgvVariablesRequest.Size = new System.Drawing.Size(282, 150);
            this.dgvVariablesRequest.TabIndex = 104;
            this.dgvVariablesRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVariablesRequest_CellContentClick);
            // 
            // tsmMenu
            // 
            this.tsmMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAgregarRequest,
            this.tslAgregarResponse,
            this.tslQuitarRequest,
            this.tslQuitarResponse});
            this.tsmMenu.Location = new System.Drawing.Point(0, 31);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(1619, 28);
            this.tsmMenu.TabIndex = 6;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslAgregarRequest
            // 
            this.tslAgregarRequest.Name = "tslAgregarRequest";
            this.tslAgregarRequest.Size = new System.Drawing.Size(246, 25);
            this.tslAgregarRequest.Text = "Agregar Variables Request";
            this.tslAgregarRequest.Click += new System.EventHandler(this.tslAgregar_Click);
            // 
            // tslAgregarResponse
            // 
            this.tslAgregarResponse.Name = "tslAgregarResponse";
            this.tslAgregarResponse.Size = new System.Drawing.Size(259, 25);
            this.tslAgregarResponse.Text = "Agregar Variables Response";
            this.tslAgregarResponse.Click += new System.EventHandler(this.tslAgregarResponse_Click);
            // 
            // tslQuitarRequest
            // 
            this.tslQuitarRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tslQuitarRequest.Name = "tslQuitarRequest";
            this.tslQuitarRequest.Size = new System.Drawing.Size(0, 25);
            this.tslQuitarRequest.Text = "QuitarVariableRequest";
            this.tslQuitarRequest.Click += new System.EventHandler(this.tslQuitar_Click);
            // 
            // tslQuitarResponse
            // 
            this.tslQuitarResponse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tslQuitarResponse.Name = "tslQuitarResponse";
            this.tslQuitarResponse.Size = new System.Drawing.Size(0, 25);
            this.tslQuitarResponse.Text = "QuitarVariableResponse";
            this.tslQuitarResponse.Click += new System.EventHandler(this.tslQuitarResponse_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "Nombre del metodo";
            // 
            // txtNombreMetodo
            // 
            this.txtNombreMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMetodo.Location = new System.Drawing.Point(892, 63);
            this.txtNombreMetodo.Name = "txtNombreMetodo";
            this.txtNombreMetodo.Size = new System.Drawing.Size(144, 28);
            this.txtNombreMetodo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seleccione Ruta Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivo.Location = new System.Drawing.Point(892, 104);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(144, 28);
            this.txtRutaArchivo.TabIndex = 9;
            // 
            // dgvVariablesResponse
            // 
            this.dgvVariablesResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariablesResponse.Location = new System.Drawing.Point(10, 594);
            this.dgvVariablesResponse.Name = "dgvVariablesResponse";
            this.dgvVariablesResponse.Size = new System.Drawing.Size(282, 150);
            this.dgvVariablesResponse.TabIndex = 112;
            this.dgvVariablesResponse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVariablesResponse_CellContentClick);
            // 
            // cbmTipoVariableResponse
            // 
            this.cbmTipoVariableResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmTipoVariableResponse.FormattingEnabled = true;
            this.cbmTipoVariableResponse.Items.AddRange(new object[] {
            "String",
            "Int",
            "List",
            "Double",
            "Float"});
            this.cbmTipoVariableResponse.Location = new System.Drawing.Point(181, 555);
            this.cbmTipoVariableResponse.Name = "cbmTipoVariableResponse";
            this.cbmTipoVariableResponse.Size = new System.Drawing.Size(144, 30);
            this.cbmTipoVariableResponse.TabIndex = 6;
            this.cbmTipoVariableResponse.SelectedIndexChanged += new System.EventHandler(this.cbmTipoVariableResponse_SelectedIndexChanged);
            // 
            // txtNombreVariableResponse
            // 
            this.txtNombreVariableResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVariableResponse.Location = new System.Drawing.Point(181, 514);
            this.txtNombreVariableResponse.Name = "txtNombreVariableResponse";
            this.txtNombreVariableResponse.Size = new System.Drawing.Size(144, 28);
            this.txtNombreVariableResponse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 108;
            this.label4.Text = "TipoVariable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "Nombre de Variable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 110;
            this.label6.Text = "Variables Request";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(26, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 24);
            this.label7.TabIndex = 105;
            this.label7.Text = "Variables Response";
            // 
            // txtNombreClaseResponse
            // 
            this.txtNombreClaseResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClaseResponse.Location = new System.Drawing.Point(181, 468);
            this.txtNombreClaseResponse.Name = "txtNombreClaseResponse";
            this.txtNombreClaseResponse.Size = new System.Drawing.Size(144, 28);
            this.txtNombreClaseResponse.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 106;
            this.label8.Text = "Nombre de Clase";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 101;
            this.label9.Text = "Nombre de Clase";
            // 
            // txtNombreClaseRequest
            // 
            this.txtNombreClaseRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClaseRequest.Location = new System.Drawing.Point(167, 89);
            this.txtNombreClaseRequest.Name = "txtNombreClaseRequest";
            this.txtNombreClaseRequest.Size = new System.Drawing.Size(144, 28);
            this.txtNombreClaseRequest.TabIndex = 1;
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.Location = new System.Drawing.Point(1055, 63);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(166, 75);
            this.btnGenerarCodigo.TabIndex = 113;
            this.btnGenerarCodigo.Text = "Generar Codigo";
            this.btnGenerarCodigo.UseVisualStyleBackColor = true;
            this.btnGenerarCodigo.Click += new System.EventHandler(this.btnGenerarCodigo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRequest);
            this.tabControl1.Controls.Add(this.tabResponse);
            this.tabControl1.Controls.Add(this.tabMetodoConsumo);
            this.tabControl1.Location = new System.Drawing.Point(669, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 488);
            this.tabControl1.TabIndex = 114;
            // 
            // tabRequest
            // 
            this.tabRequest.Controls.Add(this.txtClaseRequest);
            this.tabRequest.Location = new System.Drawing.Point(4, 22);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequest.Size = new System.Drawing.Size(908, 462);
            this.tabRequest.TabIndex = 0;
            this.tabRequest.Text = "Clase Request";
            this.tabRequest.UseVisualStyleBackColor = true;
            // 
            // txtClaseRequest
            // 
            this.txtClaseRequest.Location = new System.Drawing.Point(3, 6);
            this.txtClaseRequest.Multiline = true;
            this.txtClaseRequest.Name = "txtClaseRequest";
            this.txtClaseRequest.ReadOnly = true;
            this.txtClaseRequest.Size = new System.Drawing.Size(899, 447);
            this.txtClaseRequest.TabIndex = 0;
            // 
            // tabResponse
            // 
            this.tabResponse.Controls.Add(this.txtClaseResponse);
            this.tabResponse.Location = new System.Drawing.Point(4, 22);
            this.tabResponse.Name = "tabResponse";
            this.tabResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabResponse.Size = new System.Drawing.Size(908, 462);
            this.tabResponse.TabIndex = 1;
            this.tabResponse.Text = "Clase Response";
            this.tabResponse.UseVisualStyleBackColor = true;
            // 
            // txtClaseResponse
            // 
            this.txtClaseResponse.Location = new System.Drawing.Point(6, 6);
            this.txtClaseResponse.Multiline = true;
            this.txtClaseResponse.Name = "txtClaseResponse";
            this.txtClaseResponse.ReadOnly = true;
            this.txtClaseResponse.Size = new System.Drawing.Size(1040, 444);
            this.txtClaseResponse.TabIndex = 0;
            // 
            // tabMetodoConsumo
            // 
            this.tabMetodoConsumo.Controls.Add(this.txtMetodoConsumo);
            this.tabMetodoConsumo.Location = new System.Drawing.Point(4, 22);
            this.tabMetodoConsumo.Name = "tabMetodoConsumo";
            this.tabMetodoConsumo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetodoConsumo.Size = new System.Drawing.Size(908, 462);
            this.tabMetodoConsumo.TabIndex = 2;
            this.tabMetodoConsumo.Text = "Metodo Consumo";
            this.tabMetodoConsumo.UseVisualStyleBackColor = true;
            // 
            // txtMetodoConsumo
            // 
            this.txtMetodoConsumo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMetodoConsumo.Location = new System.Drawing.Point(6, 8);
            this.txtMetodoConsumo.Multiline = true;
            this.txtMetodoConsumo.Name = "txtMetodoConsumo";
            this.txtMetodoConsumo.ReadOnly = true;
            this.txtMetodoConsumo.Size = new System.Drawing.Size(1040, 447);
            this.txtMetodoConsumo.TabIndex = 0;
            // 
            // gbVariableListaRequest
            // 
            this.gbVariableListaRequest.Controls.Add(this.btnAgregarVariablesListRequest);
            this.gbVariableListaRequest.Controls.Add(this.dgvVariablesListaRequest);
            this.gbVariableListaRequest.Controls.Add(this.cmbTipoVariableListaRequest);
            this.gbVariableListaRequest.Controls.Add(this.txtNombreVariableListaRequest);
            this.gbVariableListaRequest.Controls.Add(this.label11);
            this.gbVariableListaRequest.Controls.Add(this.label12);
            this.gbVariableListaRequest.Location = new System.Drawing.Point(297, 212);
            this.gbVariableListaRequest.Margin = new System.Windows.Forms.Padding(2);
            this.gbVariableListaRequest.Name = "gbVariableListaRequest";
            this.gbVariableListaRequest.Padding = new System.Windows.Forms.Padding(2);
            this.gbVariableListaRequest.Size = new System.Drawing.Size(367, 246);
            this.gbVariableListaRequest.TabIndex = 115;
            this.gbVariableListaRequest.TabStop = false;
            this.gbVariableListaRequest.Text = "Variables Lista Resquest";
            this.gbVariableListaRequest.Visible = false;
            // 
            // btnAgregarVariablesListRequest
            // 
            this.btnAgregarVariablesListRequest.Location = new System.Drawing.Point(9, 89);
            this.btnAgregarVariablesListRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVariablesListRequest.Name = "btnAgregarVariablesListRequest";
            this.btnAgregarVariablesListRequest.Size = new System.Drawing.Size(135, 31);
            this.btnAgregarVariablesListRequest.TabIndex = 113;
            this.btnAgregarVariablesListRequest.Text = "Agregar Variables";
            this.btnAgregarVariablesListRequest.UseVisualStyleBackColor = true;
            this.btnAgregarVariablesListRequest.Click += new System.EventHandler(this.btnAgregarVariablesListRequest_Click);
            // 
            // dgvVariablesListaRequest
            // 
            this.dgvVariablesListaRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariablesListaRequest.Location = new System.Drawing.Point(9, 126);
            this.dgvVariablesListaRequest.Name = "dgvVariablesListaRequest";
            this.dgvVariablesListaRequest.Size = new System.Drawing.Size(335, 121);
            this.dgvVariablesListaRequest.TabIndex = 111;
            this.dgvVariablesListaRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVariablesListaRequest_CellContentClick);
            // 
            // cmbTipoVariableListaRequest
            // 
            this.cmbTipoVariableListaRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVariableListaRequest.FormattingEnabled = true;
            this.cmbTipoVariableListaRequest.Items.AddRange(new object[] {
            "String",
            "Int",
            "Double",
            "Float"});
            this.cmbTipoVariableListaRequest.Location = new System.Drawing.Point(224, 58);
            this.cmbTipoVariableListaRequest.Name = "cmbTipoVariableListaRequest";
            this.cmbTipoVariableListaRequest.Size = new System.Drawing.Size(104, 30);
            this.cmbTipoVariableListaRequest.TabIndex = 107;
            // 
            // txtNombreVariableListaRequest
            // 
            this.txtNombreVariableListaRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVariableListaRequest.Location = new System.Drawing.Point(224, 23);
            this.txtNombreVariableListaRequest.Name = "txtNombreVariableListaRequest";
            this.txtNombreVariableListaRequest.Size = new System.Drawing.Size(104, 28);
            this.txtNombreVariableListaRequest.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 24);
            this.label11.TabIndex = 110;
            this.label11.Text = "TipoVariable Lista";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 24);
            this.label12.TabIndex = 109;
            this.label12.Text = "Nombre de Variable Lista";
            // 
            // gbVariableListaResponse
            // 
            this.gbVariableListaResponse.Controls.Add(this.btnAgregarVariablesListResponse);
            this.gbVariableListaResponse.Controls.Add(this.dgvVariablesListaResponse);
            this.gbVariableListaResponse.Controls.Add(this.cmbTipoVariableListaResponse);
            this.gbVariableListaResponse.Controls.Add(this.txtNombreVariablesListaResponse);
            this.gbVariableListaResponse.Controls.Add(this.label14);
            this.gbVariableListaResponse.Controls.Add(this.label15);
            this.gbVariableListaResponse.Location = new System.Drawing.Point(297, 594);
            this.gbVariableListaResponse.Margin = new System.Windows.Forms.Padding(2);
            this.gbVariableListaResponse.Name = "gbVariableListaResponse";
            this.gbVariableListaResponse.Padding = new System.Windows.Forms.Padding(2);
            this.gbVariableListaResponse.Size = new System.Drawing.Size(367, 253);
            this.gbVariableListaResponse.TabIndex = 116;
            this.gbVariableListaResponse.TabStop = false;
            this.gbVariableListaResponse.Text = "Variables Lista Response";
            this.gbVariableListaResponse.Visible = false;
            // 
            // btnAgregarVariablesListResponse
            // 
            this.btnAgregarVariablesListResponse.Location = new System.Drawing.Point(9, 98);
            this.btnAgregarVariablesListResponse.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVariablesListResponse.Name = "btnAgregarVariablesListResponse";
            this.btnAgregarVariablesListResponse.Size = new System.Drawing.Size(135, 31);
            this.btnAgregarVariablesListResponse.TabIndex = 112;
            this.btnAgregarVariablesListResponse.Text = "Agregar Variables";
            this.btnAgregarVariablesListResponse.UseVisualStyleBackColor = true;
            this.btnAgregarVariablesListResponse.Click += new System.EventHandler(this.btnAgregarVariablesListResponse_Click);
            // 
            // dgvVariablesListaResponse
            // 
            this.dgvVariablesListaResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariablesListaResponse.Location = new System.Drawing.Point(9, 134);
            this.dgvVariablesListaResponse.Name = "dgvVariablesListaResponse";
            this.dgvVariablesListaResponse.Size = new System.Drawing.Size(335, 106);
            this.dgvVariablesListaResponse.TabIndex = 111;
            this.dgvVariablesListaResponse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVariablesListaResponse_CellContentClick);
            // 
            // cmbTipoVariableListaResponse
            // 
            this.cmbTipoVariableListaResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVariableListaResponse.FormattingEnabled = true;
            this.cmbTipoVariableListaResponse.Items.AddRange(new object[] {
            "String",
            "Int",
            "Double",
            "Float"});
            this.cmbTipoVariableListaResponse.Location = new System.Drawing.Point(224, 63);
            this.cmbTipoVariableListaResponse.Name = "cmbTipoVariableListaResponse";
            this.cmbTipoVariableListaResponse.Size = new System.Drawing.Size(105, 30);
            this.cmbTipoVariableListaResponse.TabIndex = 107;
            // 
            // txtNombreVariablesListaResponse
            // 
            this.txtNombreVariablesListaResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVariablesListaResponse.Location = new System.Drawing.Point(224, 24);
            this.txtNombreVariablesListaResponse.Name = "txtNombreVariablesListaResponse";
            this.txtNombreVariablesListaResponse.Size = new System.Drawing.Size(105, 28);
            this.txtNombreVariablesListaResponse.TabIndex = 106;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 24);
            this.label14.TabIndex = 110;
            this.label14.Text = "TipoVariable Lista";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 24);
            this.label15.TabIndex = 109;
            this.label15.Text = "Nombre de Variable Lista";
            // 
            // btnAddVariablesRequestMasivo
            // 
            this.btnAddVariablesRequestMasivo.Location = new System.Drawing.Point(10, 378);
            this.btnAddVariablesRequestMasivo.Name = "btnAddVariablesRequestMasivo";
            this.btnAddVariablesRequestMasivo.Size = new System.Drawing.Size(133, 23);
            this.btnAddVariablesRequestMasivo.TabIndex = 117;
            this.btnAddVariablesRequestMasivo.Text = "Agregar variables masivo";
            this.btnAddVariablesRequestMasivo.UseVisualStyleBackColor = true;
            this.btnAddVariablesRequestMasivo.Click += new System.EventHandler(this.btnAddVariablesRequestMasivo_Click);
            // 
            // btnAddVariablesResponseMasivo
            // 
            this.btnAddVariablesResponseMasivo.Location = new System.Drawing.Point(10, 759);
            this.btnAddVariablesResponseMasivo.Name = "btnAddVariablesResponseMasivo";
            this.btnAddVariablesResponseMasivo.Size = new System.Drawing.Size(133, 23);
            this.btnAddVariablesResponseMasivo.TabIndex = 118;
            this.btnAddVariablesResponseMasivo.Text = "Agregar variables masivo";
            this.btnAddVariablesResponseMasivo.UseVisualStyleBackColor = true;
            this.btnAddVariablesResponseMasivo.Click += new System.EventHandler(this.btnAddVariablesResponseMasivo_Click);
            // 
            // formAutomatizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1638, 624);
            this.Controls.Add(this.btnAddVariablesResponseMasivo);
            this.Controls.Add(this.btnAddVariablesRequestMasivo);
            this.Controls.Add(this.gbVariableListaResponse);
            this.Controls.Add(this.gbVariableListaRequest);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGenerarCodigo);
            this.Controls.Add(this.txtNombreClaseRequest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNombreClaseResponse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvVariablesResponse);
            this.Controls.Add(this.cbmTipoVariableResponse);
            this.Controls.Add(this.txtNombreVariableResponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombreMetodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.dgvVariablesRequest);
            this.Controls.Add(this.cmbTipoVariableRequest);
            this.Controls.Add(this.txtNombreVariableRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formAutomatizacion";
            this.RightToLeftLayout = true;
            this.Text = "Automatizacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAutomatizacion_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesRequest)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesResponse)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabRequest.PerformLayout();
            this.tabResponse.ResumeLayout(false);
            this.tabResponse.PerformLayout();
            this.tabMetodoConsumo.ResumeLayout(false);
            this.tabMetodoConsumo.PerformLayout();
            this.gbVariableListaRequest.ResumeLayout(false);
            this.gbVariableListaRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesListaRequest)).EndInit();
            this.gbVariableListaResponse.ResumeLayout(false);
            this.gbVariableListaResponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesListaResponse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox tspCmbTipoServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreVariableRequest;
        private System.Windows.Forms.ComboBox cmbTipoVariableRequest;
        private System.Windows.Forms.DataGridView dgvVariablesRequest;
        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslAgregarRequest;
        private System.Windows.Forms.ToolStripLabel tslQuitarRequest;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreMetodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.DataGridView dgvVariablesResponse;
        private System.Windows.Forms.ComboBox cbmTipoVariableResponse;
        private System.Windows.Forms.TextBox txtNombreVariableResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripLabel tslQuitarResponse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreClaseResponse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerarCodigo;
        private System.Windows.Forms.TextBox txtNombreClaseRequest;
        private System.Windows.Forms.ToolStripLabel tslAgregarResponse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRequest;
        private System.Windows.Forms.TextBox txtClaseRequest;
        private System.Windows.Forms.TabPage tabResponse;
        private System.Windows.Forms.TextBox txtClaseResponse;
        private System.Windows.Forms.TabPage tabMetodoConsumo;
        private System.Windows.Forms.TextBox txtMetodoConsumo;
        private System.Windows.Forms.GroupBox gbVariableListaResponse;
        private System.Windows.Forms.Button btnAgregarVariablesListResponse;
        private System.Windows.Forms.DataGridView dgvVariablesListaResponse;
        private System.Windows.Forms.ComboBox cmbTipoVariableListaResponse;
        private System.Windows.Forms.TextBox txtNombreVariablesListaResponse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbVariableListaRequest;
        private System.Windows.Forms.Button btnAgregarVariablesListRequest;
        private System.Windows.Forms.DataGridView dgvVariablesListaRequest;
        private System.Windows.Forms.ComboBox cmbTipoVariableListaRequest;
        private System.Windows.Forms.TextBox txtNombreVariableListaRequest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddVariablesRequestMasivo;
        private System.Windows.Forms.Button btnAddVariablesResponseMasivo;
    }
}