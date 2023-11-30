namespace CapaPresentacion
{
    partial class HistorialClinicoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialClinicoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApePat = new System.Windows.Forms.Label();
            this.lblApeMat = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tabHistorial = new System.Windows.Forms.TabControl();
            this.tabAntPat = new System.Windows.Forms.TabPage();
            this.ayudaPat = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.txtInterv = new System.Windows.Forms.TextBox();
            this.lblQMed = new System.Windows.Forms.Label();
            this.lblTipIn = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.cmbCardiopatias = new CustomControls.RJControls.pComboBox();
            this.cmbHepatitis = new CustomControls.RJControls.pComboBox();
            this.cmbTiroides = new CustomControls.RJControls.pComboBox();
            this.cmbNeoplasia = new CustomControls.RJControls.pComboBox();
            this.cmbTension = new CustomControls.RJControls.pComboBox();
            this.cmbDiabetes = new CustomControls.RJControls.pComboBox();
            this.BtnGuPat = new CustomControls.RJControls.RJButton();
            this.BtnEdPat = new CustomControls.RJControls.RJButton();
            this.tabNoPat = new System.Windows.Forms.TabPage();
            this.ayudaNoPat = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFrecAct = new System.Windows.Forms.Label();
            this.lblFrecAlc = new System.Windows.Forms.Label();
            this.lblFrecTab = new System.Windows.Forms.Label();
            this.numFrecAct = new System.Windows.Forms.NumericUpDown();
            this.numFrecAlc = new System.Windows.Forms.NumericUpDown();
            this.numFrecTab = new System.Windows.Forms.NumericUpDown();
            this.btnGuNoPat = new CustomControls.RJControls.RJButton();
            this.cmbDrogas = new CustomControls.RJControls.pComboBox();
            this.cmbActFis = new CustomControls.RJControls.pComboBox();
            this.BtnEdNoPat = new CustomControls.RJControls.RJButton();
            this.cmbAlc = new CustomControls.RJControls.pComboBox();
            this.cmbHiperlax = new CustomControls.RJControls.pComboBox();
            this.cmbTabaco = new CustomControls.RJControls.pComboBox();
            this.cmbParto = new CustomControls.RJControls.pComboBox();
            this.tabCitas = new System.Windows.Forms.TabPage();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.dgDiagnosticos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFicha = new System.Windows.Forms.Label();
            this.txtApeMat = new prueba.TextBoxD();
            this.txtTelf = new prueba.TextBoxD();
            this.txtSexo = new prueba.TextBoxD();
            this.txtEdad = new prueba.TextBoxD();
            this.txtApePat = new prueba.TextBoxD();
            this.txtNombre = new prueba.TextBoxD();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet11 = new CapaPresentacion.DataSet1();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            this.tabAntPat.SuspendLayout();
            this.tabNoPat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecAlc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecTab)).BeginInit();
            this.tabCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnosticos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 37);
            this.panel1.TabIndex = 74;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Help;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(859, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(31, 31);
            this.iconButton1.TabIndex = 102;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnCancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(896, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(38, 31);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(21, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 24);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApePat
            // 
            this.lblApePat.AutoSize = true;
            this.lblApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApePat.Location = new System.Drawing.Point(274, 24);
            this.lblApePat.Name = "lblApePat";
            this.lblApePat.Size = new System.Drawing.Size(165, 24);
            this.lblApePat.TabIndex = 86;
            this.lblApePat.Text = "Apellido Paterno";
            // 
            // lblApeMat
            // 
            this.lblApeMat.AutoSize = true;
            this.lblApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApeMat.Location = new System.Drawing.Point(518, 24);
            this.lblApeMat.Name = "lblApeMat";
            this.lblApeMat.Size = new System.Drawing.Size(169, 24);
            this.lblApeMat.TabIndex = 87;
            this.lblApeMat.Text = "Apellido materno";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEdad.Location = new System.Drawing.Point(23, 114);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(59, 24);
            this.lblEdad.TabIndex = 88;
            this.lblEdad.Text = "Edad";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSexo.Location = new System.Drawing.Point(166, 114);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 24);
            this.lblSexo.TabIndex = 89;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(304, 114);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(93, 24);
            this.lblTelefono.TabIndex = 90;
            this.lblTelefono.Text = "Teléfono";
            // 
            // tabHistorial
            // 
            this.tabHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHistorial.Controls.Add(this.tabAntPat);
            this.tabHistorial.Controls.Add(this.tabNoPat);
            this.tabHistorial.Controls.Add(this.tabCitas);
            this.tabHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistorial.Location = new System.Drawing.Point(78, 359);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.SelectedIndex = 0;
            this.tabHistorial.Size = new System.Drawing.Size(682, 635);
            this.tabHistorial.TabIndex = 97;
            this.tabHistorial.SelectedIndexChanged += new System.EventHandler(this.tabHistorial_SelectedIndexChanged);
            // 
            // tabAntPat
            // 
            this.tabAntPat.Controls.Add(this.ayudaPat);
            this.tabAntPat.Controls.Add(this.label8);
            this.tabAntPat.Controls.Add(this.label7);
            this.tabAntPat.Controls.Add(this.label6);
            this.tabAntPat.Controls.Add(this.label5);
            this.tabAntPat.Controls.Add(this.label4);
            this.tabAntPat.Controls.Add(this.label3);
            this.tabAntPat.Controls.Add(this.label2);
            this.tabAntPat.Controls.Add(this.txtAlergias);
            this.tabAntPat.Controls.Add(this.txtInterv);
            this.tabAntPat.Controls.Add(this.lblQMed);
            this.tabAntPat.Controls.Add(this.lblTipIn);
            this.tabAntPat.Controls.Add(this.txtMed);
            this.tabAntPat.Controls.Add(this.cmbCardiopatias);
            this.tabAntPat.Controls.Add(this.cmbHepatitis);
            this.tabAntPat.Controls.Add(this.cmbTiroides);
            this.tabAntPat.Controls.Add(this.cmbNeoplasia);
            this.tabAntPat.Controls.Add(this.cmbTension);
            this.tabAntPat.Controls.Add(this.cmbDiabetes);
            this.tabAntPat.Controls.Add(this.BtnGuPat);
            this.tabAntPat.Controls.Add(this.BtnEdPat);
            this.tabAntPat.Location = new System.Drawing.Point(4, 22);
            this.tabAntPat.Margin = new System.Windows.Forms.Padding(2);
            this.tabAntPat.Name = "tabAntPat";
            this.tabAntPat.Padding = new System.Windows.Forms.Padding(2);
            this.tabAntPat.Size = new System.Drawing.Size(674, 609);
            this.tabAntPat.TabIndex = 0;
            this.tabAntPat.Text = "Antecedentes Patológicos";
            this.tabAntPat.UseVisualStyleBackColor = true;
            // 
            // ayudaPat
            // 
            this.ayudaPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ayudaPat.Cursor = System.Windows.Forms.Cursors.Help;
            this.ayudaPat.FlatAppearance.BorderSize = 0;
            this.ayudaPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayudaPat.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ayudaPat.IconColor = System.Drawing.Color.Black;
            this.ayudaPat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ayudaPat.IconSize = 24;
            this.ayudaPat.Location = new System.Drawing.Point(640, 5);
            this.ayudaPat.Name = "ayudaPat";
            this.ayudaPat.Size = new System.Drawing.Size(31, 31);
            this.ayudaPat.TabIndex = 103;
            this.ayudaPat.UseVisualStyleBackColor = true;
            this.ayudaPat.Click += new System.EventHandler(this.ayudaPat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(350, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 104;
            this.label8.Text = "Cardiopatias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(61, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 103;
            this.label7.Text = "Hepatitis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(350, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 102;
            this.label6.Text = "Tiroides";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(62, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 101;
            this.label5.Text = "Tensión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(350, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 100;
            this.label4.Text = "Neoplasia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 99;
            this.label3.Text = "Diabetes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "¿Tiene alguna alergía?";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAlergias.Location = new System.Drawing.Point(66, 472);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(529, 22);
            this.txtAlergias.TabIndex = 98;
            // 
            // txtInterv
            // 
            this.txtInterv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtInterv.Location = new System.Drawing.Point(66, 308);
            this.txtInterv.Name = "txtInterv";
            this.txtInterv.Size = new System.Drawing.Size(529, 22);
            this.txtInterv.TabIndex = 97;
            // 
            // lblQMed
            // 
            this.lblQMed.AutoSize = true;
            this.lblQMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblQMed.Location = new System.Drawing.Point(62, 356);
            this.lblQMed.Name = "lblQMed";
            this.lblQMed.Size = new System.Drawing.Size(265, 24);
            this.lblQMed.TabIndex = 96;
            this.lblQMed.Text = "¿Qué medicamentos toma?";
            // 
            // lblTipIn
            // 
            this.lblTipIn.AutoSize = true;
            this.lblTipIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTipIn.Location = new System.Drawing.Point(61, 268);
            this.lblTipIn.Name = "lblTipIn";
            this.lblTipIn.Size = new System.Drawing.Size(513, 24);
            this.lblTipIn.TabIndex = 95;
            this.lblTipIn.Text = "¿Qué tipo de intervenciones ha tenido anteriormente?";
            // 
            // txtMed
            // 
            this.txtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMed.Location = new System.Drawing.Point(65, 394);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(530, 22);
            this.txtMed.TabIndex = 94;
            // 
            // cmbCardiopatias
            // 
            this.cmbCardiopatias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbCardiopatias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCardiopatias.BorderSize = 1;
            this.cmbCardiopatias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCardiopatias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbCardiopatias.ForeColor = System.Drawing.Color.White;
            this.cmbCardiopatias.IconColor = System.Drawing.Color.Blue;
            this.cmbCardiopatias.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbCardiopatias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCardiopatias.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCardiopatias.Location = new System.Drawing.Point(353, 202);
            this.cmbCardiopatias.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCardiopatias.Name = "cmbCardiopatias";
            this.cmbCardiopatias.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCardiopatias.Size = new System.Drawing.Size(241, 30);
            this.cmbCardiopatias.TabIndex = 93;
            this.cmbCardiopatias.Texts = "CARDIOPATIAS";
            // 
            // cmbHepatitis
            // 
            this.cmbHepatitis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbHepatitis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbHepatitis.BorderSize = 1;
            this.cmbHepatitis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbHepatitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbHepatitis.ForeColor = System.Drawing.Color.White;
            this.cmbHepatitis.IconColor = System.Drawing.Color.Blue;
            this.cmbHepatitis.Items.AddRange(new object[] {
            "Ninguna",
            "Tipo A",
            "Tipo B",
            "Tipo C",
            "Tipo D",
            "Tipo E"});
            this.cmbHepatitis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbHepatitis.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbHepatitis.Location = new System.Drawing.Point(63, 202);
            this.cmbHepatitis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbHepatitis.Name = "cmbHepatitis";
            this.cmbHepatitis.Padding = new System.Windows.Forms.Padding(1);
            this.cmbHepatitis.Size = new System.Drawing.Size(241, 30);
            this.cmbHepatitis.TabIndex = 92;
            this.cmbHepatitis.Texts = "HEPATITITS";
            // 
            // cmbTiroides
            // 
            this.cmbTiroides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbTiroides.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTiroides.BorderSize = 1;
            this.cmbTiroides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTiroides.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTiroides.ForeColor = System.Drawing.Color.White;
            this.cmbTiroides.IconColor = System.Drawing.Color.Blue;
            this.cmbTiroides.Items.AddRange(new object[] {
            "Hipotiroidismo",
            "Ninguna",
            "Hipertiroidismo"});
            this.cmbTiroides.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTiroides.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTiroides.Location = new System.Drawing.Point(353, 115);
            this.cmbTiroides.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTiroides.Name = "cmbTiroides";
            this.cmbTiroides.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTiroides.Size = new System.Drawing.Size(241, 30);
            this.cmbTiroides.TabIndex = 91;
            this.cmbTiroides.Texts = "TIROIDES";
            // 
            // cmbNeoplasia
            // 
            this.cmbNeoplasia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbNeoplasia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbNeoplasia.BorderSize = 1;
            this.cmbNeoplasia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbNeoplasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbNeoplasia.ForeColor = System.Drawing.Color.White;
            this.cmbNeoplasia.IconColor = System.Drawing.Color.Blue;
            this.cmbNeoplasia.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbNeoplasia.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbNeoplasia.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbNeoplasia.Location = new System.Drawing.Point(353, 36);
            this.cmbNeoplasia.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbNeoplasia.Name = "cmbNeoplasia";
            this.cmbNeoplasia.Padding = new System.Windows.Forms.Padding(1);
            this.cmbNeoplasia.Size = new System.Drawing.Size(241, 30);
            this.cmbNeoplasia.TabIndex = 90;
            this.cmbNeoplasia.Texts = "NEOPLASIA";
            // 
            // cmbTension
            // 
            this.cmbTension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbTension.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTension.BorderSize = 1;
            this.cmbTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbTension.ForeColor = System.Drawing.Color.White;
            this.cmbTension.IconColor = System.Drawing.Color.Blue;
            this.cmbTension.Items.AddRange(new object[] {
            "Hipotensión",
            "Normal",
            "Hipertensión"});
            this.cmbTension.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTension.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTension.Location = new System.Drawing.Point(63, 115);
            this.cmbTension.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTension.Name = "cmbTension";
            this.cmbTension.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTension.Size = new System.Drawing.Size(241, 30);
            this.cmbTension.TabIndex = 89;
            this.cmbTension.Texts = "TENSIÓN";
            // 
            // cmbDiabetes
            // 
            this.cmbDiabetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbDiabetes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDiabetes.BorderSize = 1;
            this.cmbDiabetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbDiabetes.ForeColor = System.Drawing.Color.White;
            this.cmbDiabetes.IconColor = System.Drawing.Color.Blue;
            this.cmbDiabetes.Items.AddRange(new object[] {
            "Ninguna",
            "Tipo 1",
            "Tipo 2",
            "Gestacional",
            "LADA"});
            this.cmbDiabetes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbDiabetes.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbDiabetes.Location = new System.Drawing.Point(64, 36);
            this.cmbDiabetes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDiabetes.Name = "cmbDiabetes";
            this.cmbDiabetes.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDiabetes.Size = new System.Drawing.Size(241, 30);
            this.cmbDiabetes.TabIndex = 88;
            this.cmbDiabetes.Texts = "DIABETES";
            this.cmbDiabetes.OnSelectedIndexChanged += new System.EventHandler(this.cmbDiabetes_OnSelectedIndexChanged);
            // 
            // BtnGuPat
            // 
            this.BtnGuPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.BtnGuPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.BtnGuPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuPat.BorderRadius = 17;
            this.BtnGuPat.BorderSize = 0;
            this.BtnGuPat.FlatAppearance.BorderSize = 0;
            this.BtnGuPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnGuPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuPat.ForeColor = System.Drawing.Color.White;
            this.BtnGuPat.Location = new System.Drawing.Point(277, 524);
            this.BtnGuPat.Name = "BtnGuPat";
            this.BtnGuPat.Size = new System.Drawing.Size(150, 40);
            this.BtnGuPat.TabIndex = 85;
            this.BtnGuPat.Text = "GUARDAR";
            this.BtnGuPat.TextColor = System.Drawing.Color.White;
            this.BtnGuPat.UseVisualStyleBackColor = false;
            this.BtnGuPat.Click += new System.EventHandler(this.BtnGuPat_Click);
            // 
            // BtnEdPat
            // 
            this.BtnEdPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.BtnEdPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.BtnEdPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEdPat.BorderRadius = 17;
            this.BtnEdPat.BorderSize = 0;
            this.BtnEdPat.FlatAppearance.BorderSize = 0;
            this.BtnEdPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEdPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEdPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdPat.ForeColor = System.Drawing.Color.White;
            this.BtnEdPat.Location = new System.Drawing.Point(444, 524);
            this.BtnEdPat.Name = "BtnEdPat";
            this.BtnEdPat.Size = new System.Drawing.Size(150, 40);
            this.BtnEdPat.TabIndex = 7;
            this.BtnEdPat.Text = "EDITAR";
            this.BtnEdPat.TextColor = System.Drawing.Color.White;
            this.BtnEdPat.UseVisualStyleBackColor = false;
            this.BtnEdPat.Click += new System.EventHandler(this.BtnEdPat_Click);
            // 
            // tabNoPat
            // 
            this.tabNoPat.Controls.Add(this.ayudaNoPat);
            this.tabNoPat.Controls.Add(this.label14);
            this.tabNoPat.Controls.Add(this.label13);
            this.tabNoPat.Controls.Add(this.label12);
            this.tabNoPat.Controls.Add(this.label11);
            this.tabNoPat.Controls.Add(this.label10);
            this.tabNoPat.Controls.Add(this.label9);
            this.tabNoPat.Controls.Add(this.lblFrecAct);
            this.tabNoPat.Controls.Add(this.lblFrecAlc);
            this.tabNoPat.Controls.Add(this.lblFrecTab);
            this.tabNoPat.Controls.Add(this.numFrecAct);
            this.tabNoPat.Controls.Add(this.numFrecAlc);
            this.tabNoPat.Controls.Add(this.numFrecTab);
            this.tabNoPat.Controls.Add(this.btnGuNoPat);
            this.tabNoPat.Controls.Add(this.cmbDrogas);
            this.tabNoPat.Controls.Add(this.cmbActFis);
            this.tabNoPat.Controls.Add(this.BtnEdNoPat);
            this.tabNoPat.Controls.Add(this.cmbAlc);
            this.tabNoPat.Controls.Add(this.cmbHiperlax);
            this.tabNoPat.Controls.Add(this.cmbTabaco);
            this.tabNoPat.Controls.Add(this.cmbParto);
            this.tabNoPat.Location = new System.Drawing.Point(4, 22);
            this.tabNoPat.Margin = new System.Windows.Forms.Padding(2);
            this.tabNoPat.Name = "tabNoPat";
            this.tabNoPat.Padding = new System.Windows.Forms.Padding(2);
            this.tabNoPat.Size = new System.Drawing.Size(691, 609);
            this.tabNoPat.TabIndex = 1;
            this.tabNoPat.Text = "Antecedentes no Patológicos";
            this.tabNoPat.UseVisualStyleBackColor = true;
            // 
            // ayudaNoPat
            // 
            this.ayudaNoPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ayudaNoPat.Cursor = System.Windows.Forms.Cursors.Help;
            this.ayudaNoPat.FlatAppearance.BorderSize = 0;
            this.ayudaNoPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayudaNoPat.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ayudaNoPat.IconColor = System.Drawing.Color.Black;
            this.ayudaNoPat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ayudaNoPat.IconSize = 24;
            this.ayudaNoPat.Location = new System.Drawing.Point(689, 5);
            this.ayudaNoPat.Name = "ayudaNoPat";
            this.ayudaNoPat.Size = new System.Drawing.Size(31, 31);
            this.ayudaNoPat.TabIndex = 116;
            this.ayudaNoPat.UseVisualStyleBackColor = true;
            this.ayudaNoPat.Click += new System.EventHandler(this.ayudaNoPat_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(400, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 24);
            this.label14.TabIndex = 115;
            this.label14.Text = "Hiperlaxitud";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(60, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 114;
            this.label13.Text = "Drogas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(64, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 24);
            this.label12.TabIndex = 113;
            this.label12.Text = "Actividad física";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(64, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 112;
            this.label11.Text = "Alcohol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(64, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 111;
            this.label10.Text = "Tabaco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(64, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 99;
            this.label9.Text = "Parto";
            // 
            // lblFrecAct
            // 
            this.lblFrecAct.AutoSize = true;
            this.lblFrecAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecAct.Location = new System.Drawing.Point(417, 301);
            this.lblFrecAct.Name = "lblFrecAct";
            this.lblFrecAct.Size = new System.Drawing.Size(230, 18);
            this.lblFrecAct.TabIndex = 110;
            this.lblFrecAct.Text = "Frecuencia de actividad física";
            // 
            // lblFrecAlc
            // 
            this.lblFrecAlc.AutoSize = true;
            this.lblFrecAlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecAlc.Location = new System.Drawing.Point(417, 227);
            this.lblFrecAlc.Name = "lblFrecAlc";
            this.lblFrecAlc.Size = new System.Drawing.Size(174, 18);
            this.lblFrecAlc.TabIndex = 109;
            this.lblFrecAlc.Text = "Frecuencia de alcohol";
            // 
            // lblFrecTab
            // 
            this.lblFrecTab.AutoSize = true;
            this.lblFrecTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecTab.Location = new System.Drawing.Point(416, 154);
            this.lblFrecTab.Name = "lblFrecTab";
            this.lblFrecTab.Size = new System.Drawing.Size(170, 18);
            this.lblFrecTab.TabIndex = 108;
            this.lblFrecTab.Text = "Frecuencia de tabaco";
            // 
            // numFrecAct
            // 
            this.numFrecAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.numFrecAct.Enabled = false;
            this.numFrecAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFrecAct.ForeColor = System.Drawing.Color.White;
            this.numFrecAct.Location = new System.Drawing.Point(418, 326);
            this.numFrecAct.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numFrecAct.Name = "numFrecAct";
            this.numFrecAct.Size = new System.Drawing.Size(120, 26);
            this.numFrecAct.TabIndex = 105;
            this.numFrecAct.Visible = false;
            // 
            // numFrecAlc
            // 
            this.numFrecAlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.numFrecAlc.Enabled = false;
            this.numFrecAlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFrecAlc.ForeColor = System.Drawing.Color.White;
            this.numFrecAlc.Location = new System.Drawing.Point(418, 253);
            this.numFrecAlc.Name = "numFrecAlc";
            this.numFrecAlc.Size = new System.Drawing.Size(120, 26);
            this.numFrecAlc.TabIndex = 106;
            this.numFrecAlc.Visible = false;
            // 
            // numFrecTab
            // 
            this.numFrecTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.numFrecTab.Enabled = false;
            this.numFrecTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFrecTab.ForeColor = System.Drawing.Color.White;
            this.numFrecTab.Location = new System.Drawing.Point(418, 181);
            this.numFrecTab.Name = "numFrecTab";
            this.numFrecTab.Size = new System.Drawing.Size(120, 26);
            this.numFrecTab.TabIndex = 107;
            this.numFrecTab.Visible = false;
            // 
            // btnGuNoPat
            // 
            this.btnGuNoPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnGuNoPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnGuNoPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuNoPat.BorderRadius = 17;
            this.btnGuNoPat.BorderSize = 0;
            this.btnGuNoPat.FlatAppearance.BorderSize = 0;
            this.btnGuNoPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuNoPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuNoPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuNoPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuNoPat.ForeColor = System.Drawing.Color.White;
            this.btnGuNoPat.Location = new System.Drawing.Point(272, 482);
            this.btnGuNoPat.Name = "btnGuNoPat";
            this.btnGuNoPat.Size = new System.Drawing.Size(150, 40);
            this.btnGuNoPat.TabIndex = 104;
            this.btnGuNoPat.Text = "GUARDAR";
            this.btnGuNoPat.TextColor = System.Drawing.Color.White;
            this.btnGuNoPat.UseVisualStyleBackColor = false;
            this.btnGuNoPat.Click += new System.EventHandler(this.btnGuNoPat_Click);
            // 
            // cmbDrogas
            // 
            this.cmbDrogas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbDrogas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDrogas.BorderSize = 1;
            this.cmbDrogas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbDrogas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrogas.ForeColor = System.Drawing.Color.White;
            this.cmbDrogas.IconColor = System.Drawing.Color.Blue;
            this.cmbDrogas.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbDrogas.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbDrogas.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbDrogas.Location = new System.Drawing.Point(64, 390);
            this.cmbDrogas.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDrogas.Name = "cmbDrogas";
            this.cmbDrogas.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDrogas.Size = new System.Drawing.Size(241, 39);
            this.cmbDrogas.TabIndex = 103;
            this.cmbDrogas.Texts = "DROGAS";
            // 
            // cmbActFis
            // 
            this.cmbActFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbActFis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbActFis.BorderSize = 1;
            this.cmbActFis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbActFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActFis.ForeColor = System.Drawing.Color.White;
            this.cmbActFis.IconColor = System.Drawing.Color.Blue;
            this.cmbActFis.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbActFis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbActFis.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbActFis.Location = new System.Drawing.Point(64, 318);
            this.cmbActFis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbActFis.Name = "cmbActFis";
            this.cmbActFis.Padding = new System.Windows.Forms.Padding(1);
            this.cmbActFis.Size = new System.Drawing.Size(241, 39);
            this.cmbActFis.TabIndex = 102;
            this.cmbActFis.Texts = "ACTIVIDAD FISICA";
            this.cmbActFis.OnSelectedIndexChanged += new System.EventHandler(this.cmbActFis_OnSelectedIndexChanged);
            // 
            // BtnEdNoPat
            // 
            this.BtnEdNoPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.BtnEdNoPat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.BtnEdNoPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEdNoPat.BorderRadius = 17;
            this.BtnEdNoPat.BorderSize = 0;
            this.BtnEdNoPat.FlatAppearance.BorderSize = 0;
            this.BtnEdNoPat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEdNoPat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEdNoPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdNoPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdNoPat.ForeColor = System.Drawing.Color.White;
            this.BtnEdNoPat.Location = new System.Drawing.Point(448, 482);
            this.BtnEdNoPat.Name = "BtnEdNoPat";
            this.BtnEdNoPat.Size = new System.Drawing.Size(150, 40);
            this.BtnEdNoPat.TabIndex = 101;
            this.BtnEdNoPat.Text = "EDITAR";
            this.BtnEdNoPat.TextColor = System.Drawing.Color.White;
            this.BtnEdNoPat.UseVisualStyleBackColor = false;
            this.BtnEdNoPat.Click += new System.EventHandler(this.BtnEdNoPat_Click);
            // 
            // cmbAlc
            // 
            this.cmbAlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbAlc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbAlc.BorderSize = 1;
            this.cmbAlc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbAlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlc.ForeColor = System.Drawing.Color.White;
            this.cmbAlc.IconColor = System.Drawing.Color.Blue;
            this.cmbAlc.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbAlc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbAlc.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbAlc.Location = new System.Drawing.Point(64, 246);
            this.cmbAlc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbAlc.Name = "cmbAlc";
            this.cmbAlc.Padding = new System.Windows.Forms.Padding(1);
            this.cmbAlc.Size = new System.Drawing.Size(241, 39);
            this.cmbAlc.TabIndex = 100;
            this.cmbAlc.Texts = "ALCOHOL";
            this.cmbAlc.OnSelectedIndexChanged += new System.EventHandler(this.cmbAlc_OnSelectedIndexChanged);
            // 
            // cmbHiperlax
            // 
            this.cmbHiperlax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbHiperlax.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbHiperlax.BorderSize = 1;
            this.cmbHiperlax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbHiperlax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHiperlax.ForeColor = System.Drawing.Color.White;
            this.cmbHiperlax.IconColor = System.Drawing.Color.Blue;
            this.cmbHiperlax.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbHiperlax.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbHiperlax.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbHiperlax.Location = new System.Drawing.Point(404, 103);
            this.cmbHiperlax.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbHiperlax.Name = "cmbHiperlax";
            this.cmbHiperlax.Padding = new System.Windows.Forms.Padding(1);
            this.cmbHiperlax.Size = new System.Drawing.Size(241, 39);
            this.cmbHiperlax.TabIndex = 99;
            this.cmbHiperlax.Texts = "HIPERLAXITUD";
            // 
            // cmbTabaco
            // 
            this.cmbTabaco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbTabaco.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTabaco.BorderSize = 1;
            this.cmbTabaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTabaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabaco.ForeColor = System.Drawing.Color.White;
            this.cmbTabaco.IconColor = System.Drawing.Color.Blue;
            this.cmbTabaco.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbTabaco.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTabaco.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTabaco.Location = new System.Drawing.Point(64, 175);
            this.cmbTabaco.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTabaco.Name = "cmbTabaco";
            this.cmbTabaco.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTabaco.Size = new System.Drawing.Size(241, 39);
            this.cmbTabaco.TabIndex = 98;
            this.cmbTabaco.Texts = "TABACO";
            this.cmbTabaco.OnSelectedIndexChanged += new System.EventHandler(this.cmbTabaco_OnSelectedIndexChanged);
            // 
            // cmbParto
            // 
            this.cmbParto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbParto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbParto.BorderSize = 1;
            this.cmbParto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbParto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParto.ForeColor = System.Drawing.Color.White;
            this.cmbParto.IconColor = System.Drawing.Color.Blue;
            this.cmbParto.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbParto.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbParto.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbParto.Location = new System.Drawing.Point(64, 102);
            this.cmbParto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbParto.Name = "cmbParto";
            this.cmbParto.Padding = new System.Windows.Forms.Padding(1);
            this.cmbParto.Size = new System.Drawing.Size(241, 39);
            this.cmbParto.TabIndex = 97;
            this.cmbParto.Texts = "PARTO";
            // 
            // tabCitas
            // 
            this.tabCitas.Controls.Add(this.iconButton4);
            this.tabCitas.Controls.Add(this.btnAyuda);
            this.tabCitas.Controls.Add(this.dgDiagnosticos);
            this.tabCitas.Location = new System.Drawing.Point(4, 22);
            this.tabCitas.Margin = new System.Windows.Forms.Padding(2);
            this.tabCitas.Name = "tabCitas";
            this.tabCitas.Padding = new System.Windows.Forms.Padding(2);
            this.tabCitas.Size = new System.Drawing.Size(691, 609);
            this.tabCitas.TabIndex = 2;
            this.tabCitas.Text = "Historial de Citas";
            this.tabCitas.UseVisualStyleBackColor = true;
            this.tabCitas.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Help;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 24;
            this.iconButton4.Location = new System.Drawing.Point(720, 11);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(31, 31);
            this.iconButton4.TabIndex = 104;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.Black;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 24;
            this.btnAyuda.Location = new System.Drawing.Point(717, 11);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 102;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // dgDiagnosticos
            // 
            this.dgDiagnosticos.BackgroundColor = System.Drawing.Color.White;
            this.dgDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDiagnosticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDiagnosticos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDiagnosticos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiagnosticos.EnableHeadersVisualStyles = false;
            this.dgDiagnosticos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgDiagnosticos.Location = new System.Drawing.Point(4, 125);
            this.dgDiagnosticos.Margin = new System.Windows.Forms.Padding(2);
            this.dgDiagnosticos.Name = "dgDiagnosticos";
            this.dgDiagnosticos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDiagnosticos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDiagnosticos.RowHeadersVisible = false;
            this.dgDiagnosticos.RowHeadersWidth = 51;
            this.dgDiagnosticos.RowTemplate.Height = 24;
            this.dgDiagnosticos.Size = new System.Drawing.Size(751, 389);
            this.dgDiagnosticos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblFicha);
            this.groupBox1.Controls.Add(this.txtApeMat);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtTelf);
            this.groupBox1.Controls.Add(this.lblApePat);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.lblApeMat);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.txtApePat);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(682, 269);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // lblFicha
            // 
            this.lblFicha.AutoSize = true;
            this.lblFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFicha.Location = new System.Drawing.Point(498, 148);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(107, 24);
            this.lblFicha.TabIndex = 99;
            this.lblFicha.Text = "No. Ficha ";
            // 
            // txtApeMat
            // 
            this.txtApeMat.BackColor = System.Drawing.SystemColors.Window;
            this.txtApeMat.BorderColor = System.Drawing.Color.Silver;
            this.txtApeMat.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtApeMat.BorderRadius = 12;
            this.txtApeMat.BorderSize = 2;
            this.txtApeMat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtApeMat.Enabled = false;
            this.txtApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApeMat.Location = new System.Drawing.Point(513, 52);
            this.txtApeMat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApeMat.MaxLength = 10;
            this.txtApeMat.Multiline = false;
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApeMat.PasswordChar = false;
            this.txtApeMat.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtApeMat.PlaceholderText = "";
            this.txtApeMat.Size = new System.Drawing.Size(224, 35);
            this.txtApeMat.TabIndex = 93;
            this.txtApeMat.Texts = "";
            this.txtApeMat.UnderlineStyle = false;
            this.txtApeMat.UseWaitCursor = true;
            // 
            // txtTelf
            // 
            this.txtTelf.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelf.BorderColor = System.Drawing.Color.Silver;
            this.txtTelf.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtTelf.BorderRadius = 12;
            this.txtTelf.BorderSize = 2;
            this.txtTelf.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtTelf.Enabled = false;
            this.txtTelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelf.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelf.Location = new System.Drawing.Point(296, 141);
            this.txtTelf.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelf.MaxLength = 10;
            this.txtTelf.Multiline = false;
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelf.PasswordChar = false;
            this.txtTelf.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtTelf.PlaceholderText = "";
            this.txtTelf.Size = new System.Drawing.Size(178, 35);
            this.txtTelf.TabIndex = 96;
            this.txtTelf.Texts = "";
            this.txtTelf.UnderlineStyle = false;
            this.txtTelf.UseWaitCursor = true;
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSexo.BorderColor = System.Drawing.Color.Silver;
            this.txtSexo.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtSexo.BorderRadius = 12;
            this.txtSexo.BorderSize = 2;
            this.txtSexo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.DimGray;
            this.txtSexo.Location = new System.Drawing.Point(162, 141);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.MaxLength = 10;
            this.txtSexo.Multiline = false;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSexo.PasswordChar = false;
            this.txtSexo.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtSexo.PlaceholderText = "";
            this.txtSexo.Size = new System.Drawing.Size(100, 35);
            this.txtSexo.TabIndex = 95;
            this.txtSexo.Texts = "";
            this.txtSexo.UnderlineStyle = false;
            this.txtSexo.UseWaitCursor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.BorderColor = System.Drawing.Color.Silver;
            this.txtEdad.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtEdad.BorderRadius = 12;
            this.txtEdad.BorderSize = 2;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.Location = new System.Drawing.Point(21, 136);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MaxLength = 10;
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEdad.PasswordChar = false;
            this.txtEdad.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtEdad.PlaceholderText = "";
            this.txtEdad.Size = new System.Drawing.Size(100, 35);
            this.txtEdad.TabIndex = 94;
            this.txtEdad.Texts = "";
            this.txtEdad.UnderlineStyle = false;
            this.txtEdad.UseWaitCursor = true;
            // 
            // txtApePat
            // 
            this.txtApePat.BackColor = System.Drawing.SystemColors.Window;
            this.txtApePat.BorderColor = System.Drawing.Color.Silver;
            this.txtApePat.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtApePat.BorderRadius = 12;
            this.txtApePat.BorderSize = 2;
            this.txtApePat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtApePat.Enabled = false;
            this.txtApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApePat.Location = new System.Drawing.Point(268, 52);
            this.txtApePat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApePat.MaxLength = 10;
            this.txtApePat.Multiline = false;
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApePat.PasswordChar = false;
            this.txtApePat.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtApePat.PlaceholderText = "";
            this.txtApePat.Size = new System.Drawing.Size(224, 35);
            this.txtApePat.TabIndex = 92;
            this.txtApePat.Texts = "";
            this.txtApePat.UnderlineStyle = false;
            this.txtApePat.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtNombre.BorderRadius = 12;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(21, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(224, 35);
            this.txtNombre.TabIndex = 91;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = false;
            this.txtNombre.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 98;
            this.label1.Text = "Antecedentes";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HistorialClinicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(954, 894);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabHistorial);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialClinicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Clinico";
            this.Load += new System.EventHandler(this.HistorialClinicoForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HistorialClinicoForm_Paint);
            this.panel1.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            this.tabAntPat.ResumeLayout(false);
            this.tabAntPat.PerformLayout();
            this.tabNoPat.ResumeLayout(false);
            this.tabNoPat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecAlc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecTab)).EndInit();
            this.tabCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnosticos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApePat;
        private System.Windows.Forms.Label lblApeMat;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefono;
        private prueba.TextBoxD txtNombre;
        private prueba.TextBoxD txtApePat;
        private prueba.TextBoxD txtApeMat;
        private prueba.TextBoxD txtEdad;
        private prueba.TextBoxD txtSexo;
        private prueba.TextBoxD txtTelf;
        private System.Windows.Forms.TabControl tabHistorial;
        private System.Windows.Forms.TabPage tabAntPat;
        private CustomControls.RJControls.RJButton BtnGuPat;
        private CustomControls.RJControls.RJButton BtnEdPat;
        private System.Windows.Forms.TabPage tabNoPat;
        private System.Windows.Forms.TextBox txtInterv;
        private System.Windows.Forms.Label lblQMed;
        private System.Windows.Forms.Label lblTipIn;
        private System.Windows.Forms.TextBox txtMed;
        private CustomControls.RJControls.pComboBox cmbCardiopatias;
        private CustomControls.RJControls.pComboBox cmbHepatitis;
        private CustomControls.RJControls.pComboBox cmbTiroides;
        private CustomControls.RJControls.pComboBox cmbNeoplasia;
        private CustomControls.RJControls.pComboBox cmbTension;
        private CustomControls.RJControls.pComboBox cmbDiabetes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFrecAct;
        private System.Windows.Forms.Label lblFrecAlc;
        private System.Windows.Forms.Label lblFrecTab;
        private System.Windows.Forms.NumericUpDown numFrecAct;
        private System.Windows.Forms.NumericUpDown numFrecAlc;
        private System.Windows.Forms.NumericUpDown numFrecTab;
        private CustomControls.RJControls.RJButton btnGuNoPat;
        private CustomControls.RJControls.pComboBox cmbDrogas;
        private CustomControls.RJControls.pComboBox cmbActFis;
        private CustomControls.RJControls.RJButton BtnEdNoPat;
        private CustomControls.RJControls.pComboBox cmbAlc;
        private CustomControls.RJControls.pComboBox cmbHiperlax;
        private CustomControls.RJControls.pComboBox cmbTabaco;
        private CustomControls.RJControls.pComboBox cmbParto;
        private System.Windows.Forms.TabPage tabCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlergias;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dgDiagnosticos;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private System.Windows.Forms.ToolTip ttAyuda;
        private FontAwesome.Sharp.IconButton ayudaPat;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton ayudaNoPat;
    }
}