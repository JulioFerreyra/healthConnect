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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlPat = new System.Windows.Forms.Panel();
            this.lblPatologicos = new System.Windows.Forms.Label();
            this.txtInterv = new System.Windows.Forms.TextBox();
            this.BtnGuPat = new CustomControls.RJControls.RJButton();
            this.lblQMed = new System.Windows.Forms.Label();
            this.lblTipIn = new System.Windows.Forms.Label();
            this.lblMedic = new System.Windows.Forms.TextBox();
            this.BtnEdPat = new CustomControls.RJControls.RJButton();
            this.cmbCardiopatias = new CustomControls.RJControls.pComboBox();
            this.cmbHepatitis = new CustomControls.RJControls.pComboBox();
            this.cmbTiroides = new CustomControls.RJControls.pComboBox();
            this.cmbNeoplasia = new CustomControls.RJControls.pComboBox();
            this.cmbTension = new CustomControls.RJControls.pComboBox();
            this.cmbDiabetes = new CustomControls.RJControls.pComboBox();
            this.pnlNoPat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuNoPat = new CustomControls.RJControls.RJButton();
            this.cmbDrogas = new CustomControls.RJControls.pComboBox();
            this.cmbFrecActFis = new CustomControls.RJControls.pComboBox();
            this.cmbActFis = new CustomControls.RJControls.pComboBox();
            this.BtnEdNoPat = new CustomControls.RJControls.RJButton();
            this.cmbFrecAlc = new CustomControls.RJControls.pComboBox();
            this.cmbAlc = new CustomControls.RJControls.pComboBox();
            this.cmbFrecTab = new CustomControls.RJControls.pComboBox();
            this.cmbHiperlax = new CustomControls.RJControls.pComboBox();
            this.cmbTabaco = new CustomControls.RJControls.pComboBox();
            this.cmbParto = new CustomControls.RJControls.pComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApePat = new System.Windows.Forms.Label();
            this.lblApeMat = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbTipoPat = new CustomControls.RJControls.pComboBox();
            this.txtNombre = new prueba.TextBoxD();
            this.txtApePat = new prueba.TextBoxD();
            this.txtApeMat = new prueba.TextBoxD();
            this.txtEdad = new prueba.TextBoxD();
            this.txtSexo = new prueba.TextBoxD();
            this.txtTelf = new prueba.TextBoxD();
            this.panel1.SuspendLayout();
            this.pnlPat.SuspendLayout();
            this.pnlNoPat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 37);
            this.panel1.TabIndex = 74;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.btnCancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(763, -3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 40);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlPat
            // 
            this.pnlPat.Controls.Add(this.lblPatologicos);
            this.pnlPat.Controls.Add(this.txtInterv);
            this.pnlPat.Controls.Add(this.BtnGuPat);
            this.pnlPat.Controls.Add(this.lblQMed);
            this.pnlPat.Controls.Add(this.lblTipIn);
            this.pnlPat.Controls.Add(this.lblMedic);
            this.pnlPat.Controls.Add(this.BtnEdPat);
            this.pnlPat.Controls.Add(this.cmbCardiopatias);
            this.pnlPat.Controls.Add(this.cmbHepatitis);
            this.pnlPat.Controls.Add(this.cmbTiroides);
            this.pnlPat.Controls.Add(this.cmbNeoplasia);
            this.pnlPat.Controls.Add(this.cmbTension);
            this.pnlPat.Controls.Add(this.cmbDiabetes);
            this.pnlPat.Location = new System.Drawing.Point(33, 320);
            this.pnlPat.Name = "pnlPat";
            this.pnlPat.Size = new System.Drawing.Size(645, 528);
            this.pnlPat.TabIndex = 75;
            // 
            // lblPatologicos
            // 
            this.lblPatologicos.AutoSize = true;
            this.lblPatologicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPatologicos.Location = new System.Drawing.Point(12, 0);
            this.lblPatologicos.Name = "lblPatologicos";
            this.lblPatologicos.Size = new System.Drawing.Size(156, 24);
            this.lblPatologicos.TabIndex = 91;
            this.lblPatologicos.Text = "PATOLOGICOS";
            // 
            // txtInterv
            // 
            this.txtInterv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtInterv.Location = new System.Drawing.Point(27, 361);
            this.txtInterv.Name = "txtInterv";
            this.txtInterv.Size = new System.Drawing.Size(346, 22);
            this.txtInterv.TabIndex = 87;
            // 
            // BtnGuPat
            // 
            this.BtnGuPat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGuPat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnGuPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuPat.BorderRadius = 17;
            this.BtnGuPat.BorderSize = 0;
            this.BtnGuPat.FlatAppearance.BorderSize = 0;
            this.BtnGuPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuPat.ForeColor = System.Drawing.Color.White;
            this.BtnGuPat.Location = new System.Drawing.Point(489, 438);
            this.BtnGuPat.Name = "BtnGuPat";
            this.BtnGuPat.Size = new System.Drawing.Size(150, 40);
            this.BtnGuPat.TabIndex = 85;
            this.BtnGuPat.Text = "GUARDAR";
            this.BtnGuPat.TextColor = System.Drawing.Color.White;
            this.BtnGuPat.UseVisualStyleBackColor = false;
            // 
            // lblQMed
            // 
            this.lblQMed.AutoSize = true;
            this.lblQMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblQMed.Location = new System.Drawing.Point(23, 409);
            this.lblQMed.Name = "lblQMed";
            this.lblQMed.Size = new System.Drawing.Size(265, 24);
            this.lblQMed.TabIndex = 84;
            this.lblQMed.Text = "¿Qué medicamentos toma?";
            // 
            // lblTipIn
            // 
            this.lblTipIn.AutoSize = true;
            this.lblTipIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTipIn.Location = new System.Drawing.Point(22, 321);
            this.lblTipIn.Name = "lblTipIn";
            this.lblTipIn.Size = new System.Drawing.Size(513, 24);
            this.lblTipIn.TabIndex = 83;
            this.lblTipIn.Text = "¿Qué tipo de intervenciones ha tenido anteriormente?";
            // 
            // lblMedic
            // 
            this.lblMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMedic.Location = new System.Drawing.Point(27, 451);
            this.lblMedic.Name = "lblMedic";
            this.lblMedic.Size = new System.Drawing.Size(346, 22);
            this.lblMedic.TabIndex = 82;
            // 
            // BtnEdPat
            // 
            this.BtnEdPat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEdPat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEdPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEdPat.BorderRadius = 17;
            this.BtnEdPat.BorderSize = 0;
            this.BtnEdPat.FlatAppearance.BorderSize = 0;
            this.BtnEdPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdPat.ForeColor = System.Drawing.Color.White;
            this.BtnEdPat.Location = new System.Drawing.Point(492, 485);
            this.BtnEdPat.Name = "BtnEdPat";
            this.BtnEdPat.Size = new System.Drawing.Size(150, 40);
            this.BtnEdPat.TabIndex = 7;
            this.BtnEdPat.Text = "EDITAR";
            this.BtnEdPat.TextColor = System.Drawing.Color.White;
            this.BtnEdPat.UseVisualStyleBackColor = false;
            // 
            // cmbCardiopatias
            // 
            this.cmbCardiopatias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCardiopatias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCardiopatias.BorderSize = 1;
            this.cmbCardiopatias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCardiopatias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbCardiopatias.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCardiopatias.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCardiopatias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCardiopatias.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCardiopatias.Location = new System.Drawing.Point(316, 263);
            this.cmbCardiopatias.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCardiopatias.Name = "cmbCardiopatias";
            this.cmbCardiopatias.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCardiopatias.Size = new System.Drawing.Size(241, 33);
            this.cmbCardiopatias.TabIndex = 5;
            this.cmbCardiopatias.Texts = "CARDIOPATIAS";
            // 
            // cmbHepatitis
            // 
            this.cmbHepatitis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbHepatitis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbHepatitis.BorderSize = 1;
            this.cmbHepatitis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbHepatitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbHepatitis.ForeColor = System.Drawing.Color.DimGray;
            this.cmbHepatitis.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbHepatitis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbHepatitis.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbHepatitis.Location = new System.Drawing.Point(26, 263);
            this.cmbHepatitis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbHepatitis.Name = "cmbHepatitis";
            this.cmbHepatitis.Padding = new System.Windows.Forms.Padding(1);
            this.cmbHepatitis.Size = new System.Drawing.Size(241, 33);
            this.cmbHepatitis.TabIndex = 4;
            this.cmbHepatitis.Texts = "HEPATITITS";
            // 
            // cmbTiroides
            // 
            this.cmbTiroides.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTiroides.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTiroides.BorderSize = 1;
            this.cmbTiroides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTiroides.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbTiroides.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTiroides.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTiroides.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTiroides.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTiroides.Location = new System.Drawing.Point(316, 158);
            this.cmbTiroides.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTiroides.Name = "cmbTiroides";
            this.cmbTiroides.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTiroides.Size = new System.Drawing.Size(241, 33);
            this.cmbTiroides.TabIndex = 3;
            this.cmbTiroides.Texts = "TIROIDES";
            // 
            // cmbNeoplasia
            // 
            this.cmbNeoplasia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNeoplasia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbNeoplasia.BorderSize = 1;
            this.cmbNeoplasia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbNeoplasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbNeoplasia.ForeColor = System.Drawing.Color.DimGray;
            this.cmbNeoplasia.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbNeoplasia.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbNeoplasia.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbNeoplasia.Location = new System.Drawing.Point(316, 71);
            this.cmbNeoplasia.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbNeoplasia.Name = "cmbNeoplasia";
            this.cmbNeoplasia.Padding = new System.Windows.Forms.Padding(1);
            this.cmbNeoplasia.Size = new System.Drawing.Size(241, 33);
            this.cmbNeoplasia.TabIndex = 2;
            this.cmbNeoplasia.Texts = "NEOPLASIA";
            // 
            // cmbTension
            // 
            this.cmbTension.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTension.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTension.BorderSize = 1;
            this.cmbTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbTension.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTension.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTension.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTension.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTension.Location = new System.Drawing.Point(26, 158);
            this.cmbTension.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTension.Name = "cmbTension";
            this.cmbTension.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTension.Size = new System.Drawing.Size(241, 33);
            this.cmbTension.TabIndex = 1;
            this.cmbTension.Texts = "TENSIÓN";
            // 
            // cmbDiabetes
            // 
            this.cmbDiabetes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDiabetes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDiabetes.BorderSize = 1;
            this.cmbDiabetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbDiabetes.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDiabetes.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDiabetes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbDiabetes.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbDiabetes.Location = new System.Drawing.Point(27, 71);
            this.cmbDiabetes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDiabetes.Name = "cmbDiabetes";
            this.cmbDiabetes.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDiabetes.Size = new System.Drawing.Size(241, 33);
            this.cmbDiabetes.TabIndex = 0;
            this.cmbDiabetes.Texts = "DIABETES";
            // 
            // pnlNoPat
            // 
            this.pnlNoPat.Controls.Add(this.label1);
            this.pnlNoPat.Controls.Add(this.btnGuNoPat);
            this.pnlNoPat.Controls.Add(this.cmbDrogas);
            this.pnlNoPat.Controls.Add(this.cmbFrecActFis);
            this.pnlNoPat.Controls.Add(this.cmbActFis);
            this.pnlNoPat.Controls.Add(this.BtnEdNoPat);
            this.pnlNoPat.Controls.Add(this.cmbFrecAlc);
            this.pnlNoPat.Controls.Add(this.cmbAlc);
            this.pnlNoPat.Controls.Add(this.cmbFrecTab);
            this.pnlNoPat.Controls.Add(this.cmbHiperlax);
            this.pnlNoPat.Controls.Add(this.cmbTabaco);
            this.pnlNoPat.Controls.Add(this.cmbParto);
            this.pnlNoPat.Location = new System.Drawing.Point(33, 320);
            this.pnlNoPat.Name = "pnlNoPat";
            this.pnlNoPat.Size = new System.Drawing.Size(750, 528);
            this.pnlNoPat.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "NO PATOLOGICOS";
            // 
            // btnGuNoPat
            // 
            this.btnGuNoPat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuNoPat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuNoPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuNoPat.BorderRadius = 17;
            this.btnGuNoPat.BorderSize = 0;
            this.btnGuNoPat.FlatAppearance.BorderSize = 0;
            this.btnGuNoPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuNoPat.ForeColor = System.Drawing.Color.White;
            this.btnGuNoPat.Location = new System.Drawing.Point(487, 412);
            this.btnGuNoPat.Name = "btnGuNoPat";
            this.btnGuNoPat.Size = new System.Drawing.Size(150, 40);
            this.btnGuNoPat.TabIndex = 11;
            this.btnGuNoPat.Text = "GUARDAR";
            this.btnGuNoPat.TextColor = System.Drawing.Color.White;
            this.btnGuNoPat.UseVisualStyleBackColor = false;
            this.btnGuNoPat.Click += new System.EventHandler(this.btnGuNoPat_Click);
            // 
            // cmbDrogas
            // 
            this.cmbDrogas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDrogas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDrogas.BorderSize = 1;
            this.cmbDrogas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbDrogas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbDrogas.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDrogas.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDrogas.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbDrogas.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbDrogas.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbDrogas.Location = new System.Drawing.Point(49, 356);
            this.cmbDrogas.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDrogas.Name = "cmbDrogas";
            this.cmbDrogas.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDrogas.Size = new System.Drawing.Size(241, 33);
            this.cmbDrogas.TabIndex = 10;
            this.cmbDrogas.Texts = "DROGAS";
            // 
            // cmbFrecActFis
            // 
            this.cmbFrecActFis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFrecActFis.BorderColor = System.Drawing.Color.Navy;
            this.cmbFrecActFis.BorderSize = 1;
            this.cmbFrecActFis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFrecActFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbFrecActFis.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFrecActFis.IconColor = System.Drawing.Color.Navy;
            this.cmbFrecActFis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFrecActFis.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFrecActFis.Location = new System.Drawing.Point(365, 284);
            this.cmbFrecActFis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFrecActFis.Name = "cmbFrecActFis";
            this.cmbFrecActFis.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFrecActFis.Size = new System.Drawing.Size(241, 33);
            this.cmbFrecActFis.TabIndex = 9;
            this.cmbFrecActFis.Texts = "FRECUENCIA";
            this.cmbFrecActFis.Visible = false;
            // 
            // cmbActFis
            // 
            this.cmbActFis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbActFis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbActFis.BorderSize = 1;
            this.cmbActFis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbActFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbActFis.ForeColor = System.Drawing.Color.DimGray;
            this.cmbActFis.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbActFis.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbActFis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbActFis.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbActFis.Location = new System.Drawing.Point(49, 284);
            this.cmbActFis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbActFis.Name = "cmbActFis";
            this.cmbActFis.Padding = new System.Windows.Forms.Padding(1);
            this.cmbActFis.Size = new System.Drawing.Size(241, 33);
            this.cmbActFis.TabIndex = 8;
            this.cmbActFis.Texts = "ACTIVIDAD FISICA";
            // 
            // BtnEdNoPat
            // 
            this.BtnEdNoPat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEdNoPat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnEdNoPat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEdNoPat.BorderRadius = 17;
            this.BtnEdNoPat.BorderSize = 0;
            this.BtnEdNoPat.FlatAppearance.BorderSize = 0;
            this.BtnEdNoPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdNoPat.ForeColor = System.Drawing.Color.White;
            this.BtnEdNoPat.Location = new System.Drawing.Point(487, 462);
            this.BtnEdNoPat.Name = "BtnEdNoPat";
            this.BtnEdNoPat.Size = new System.Drawing.Size(150, 40);
            this.BtnEdNoPat.TabIndex = 7;
            this.BtnEdNoPat.Text = "EDITAR";
            this.BtnEdNoPat.TextColor = System.Drawing.Color.White;
            this.BtnEdNoPat.UseVisualStyleBackColor = false;
            this.BtnEdNoPat.Click += new System.EventHandler(this.BtnEdNoPat_Click);
            // 
            // cmbFrecAlc
            // 
            this.cmbFrecAlc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFrecAlc.BorderColor = System.Drawing.Color.Navy;
            this.cmbFrecAlc.BorderSize = 1;
            this.cmbFrecAlc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFrecAlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbFrecAlc.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFrecAlc.IconColor = System.Drawing.Color.Navy;
            this.cmbFrecAlc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFrecAlc.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFrecAlc.Location = new System.Drawing.Point(365, 212);
            this.cmbFrecAlc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFrecAlc.Name = "cmbFrecAlc";
            this.cmbFrecAlc.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFrecAlc.Size = new System.Drawing.Size(241, 33);
            this.cmbFrecAlc.TabIndex = 5;
            this.cmbFrecAlc.Texts = "FRECUENCIA";
            this.cmbFrecAlc.Visible = false;
            // 
            // cmbAlc
            // 
            this.cmbAlc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbAlc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbAlc.BorderSize = 1;
            this.cmbAlc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbAlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbAlc.ForeColor = System.Drawing.Color.DimGray;
            this.cmbAlc.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbAlc.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbAlc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbAlc.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbAlc.Location = new System.Drawing.Point(49, 212);
            this.cmbAlc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbAlc.Name = "cmbAlc";
            this.cmbAlc.Padding = new System.Windows.Forms.Padding(1);
            this.cmbAlc.Size = new System.Drawing.Size(241, 33);
            this.cmbAlc.TabIndex = 4;
            this.cmbAlc.Texts = "ALCOHOL";
            // 
            // cmbFrecTab
            // 
            this.cmbFrecTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFrecTab.BorderColor = System.Drawing.Color.Navy;
            this.cmbFrecTab.BorderSize = 1;
            this.cmbFrecTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFrecTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbFrecTab.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFrecTab.IconColor = System.Drawing.Color.Navy;
            this.cmbFrecTab.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFrecTab.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFrecTab.Location = new System.Drawing.Point(365, 140);
            this.cmbFrecTab.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFrecTab.Name = "cmbFrecTab";
            this.cmbFrecTab.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFrecTab.Size = new System.Drawing.Size(241, 33);
            this.cmbFrecTab.TabIndex = 3;
            this.cmbFrecTab.Texts = "FRECUENCIA";
            this.cmbFrecTab.Visible = false;
            // 
            // cmbHiperlax
            // 
            this.cmbHiperlax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbHiperlax.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbHiperlax.BorderSize = 1;
            this.cmbHiperlax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbHiperlax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbHiperlax.ForeColor = System.Drawing.Color.DimGray;
            this.cmbHiperlax.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbHiperlax.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbHiperlax.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbHiperlax.Location = new System.Drawing.Point(365, 68);
            this.cmbHiperlax.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbHiperlax.Name = "cmbHiperlax";
            this.cmbHiperlax.Padding = new System.Windows.Forms.Padding(1);
            this.cmbHiperlax.Size = new System.Drawing.Size(241, 33);
            this.cmbHiperlax.TabIndex = 2;
            this.cmbHiperlax.Texts = "HIPERLAXITUD";
            // 
            // cmbTabaco
            // 
            this.cmbTabaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTabaco.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTabaco.BorderSize = 1;
            this.cmbTabaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTabaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbTabaco.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTabaco.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTabaco.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbTabaco.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTabaco.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTabaco.Location = new System.Drawing.Point(49, 140);
            this.cmbTabaco.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTabaco.Name = "cmbTabaco";
            this.cmbTabaco.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTabaco.Size = new System.Drawing.Size(241, 33);
            this.cmbTabaco.TabIndex = 1;
            this.cmbTabaco.Texts = "TABACO";
            // 
            // cmbParto
            // 
            this.cmbParto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbParto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbParto.BorderSize = 1;
            this.cmbParto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbParto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbParto.ForeColor = System.Drawing.Color.DimGray;
            this.cmbParto.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbParto.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.cmbParto.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbParto.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbParto.Location = new System.Drawing.Point(49, 68);
            this.cmbParto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbParto.Name = "cmbParto";
            this.cmbParto.Padding = new System.Windows.Forms.Padding(1);
            this.cmbParto.Size = new System.Drawing.Size(241, 33);
            this.cmbParto.TabIndex = 0;
            this.cmbParto.Texts = "PARTO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(33, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 24);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApePat
            // 
            this.lblApePat.AutoSize = true;
            this.lblApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApePat.Location = new System.Drawing.Point(276, 49);
            this.lblApePat.Name = "lblApePat";
            this.lblApePat.Size = new System.Drawing.Size(213, 24);
            this.lblApePat.TabIndex = 86;
            this.lblApePat.Text = "APELLIDO PATERNO";
            // 
            // lblApeMat
            // 
            this.lblApeMat.AutoSize = true;
            this.lblApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApeMat.Location = new System.Drawing.Point(539, 49);
            this.lblApeMat.Name = "lblApeMat";
            this.lblApeMat.Size = new System.Drawing.Size(217, 24);
            this.lblApeMat.TabIndex = 87;
            this.lblApeMat.Text = "APELLIDO MATERNO";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEdad.Location = new System.Drawing.Point(33, 138);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(66, 24);
            this.lblEdad.TabIndex = 88;
            this.lblEdad.Text = "EDAD";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSexo.Location = new System.Drawing.Point(174, 138);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(68, 24);
            this.lblSexo.TabIndex = 89;
            this.lblSexo.Text = "SEXO";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(314, 138);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(122, 24);
            this.lblTelefono.TabIndex = 90;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // cmbTipoPat
            // 
            this.cmbTipoPat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipoPat.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipoPat.BorderSize = 1;
            this.cmbTipoPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTipoPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbTipoPat.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoPat.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipoPat.Items.AddRange(new object[] {
            "NO PATOLÓGICO",
            "PATOLÓGICO"});
            this.cmbTipoPat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoPat.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoPat.Location = new System.Drawing.Point(33, 259);
            this.cmbTipoPat.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipoPat.Name = "cmbTipoPat";
            this.cmbTipoPat.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoPat.Size = new System.Drawing.Size(241, 33);
            this.cmbTipoPat.TabIndex = 88;
            this.cmbTipoPat.Texts = "NO PATOLOGICOS";
            this.cmbTipoPat.OnSelectedIndexChanged += new System.EventHandler(this.cmbTipoPat_OnSelectedIndexChanged);
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
            this.txtNombre.Location = new System.Drawing.Point(33, 75);
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
            // txtApePat
            // 
            this.txtApePat.BackColor = System.Drawing.SystemColors.Window;
            this.txtApePat.BorderColor = System.Drawing.Color.Silver;
            this.txtApePat.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtApePat.BorderRadius = 12;
            this.txtApePat.BorderSize = 2;
            this.txtApePat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApePat.Location = new System.Drawing.Point(280, 76);
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
            this.txtApeMat.Location = new System.Drawing.Point(525, 76);
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
            this.txtEdad.Location = new System.Drawing.Point(33, 161);
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
            this.txtSexo.Location = new System.Drawing.Point(174, 166);
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
            this.txtTelf.Location = new System.Drawing.Point(308, 166);
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
            // HistorialClinicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(811, 903);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pnlNoPat);
            this.Controls.Add(this.cmbTipoPat);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApeMat);
            this.Controls.Add(this.lblApePat);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlPat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialClinicoForm";
            this.Text = "HistorialClinicoForm";
            this.Load += new System.EventHandler(this.HistorialClinicoForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlPat.ResumeLayout(false);
            this.pnlPat.PerformLayout();
            this.pnlNoPat.ResumeLayout(false);
            this.pnlNoPat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlPat;
        private CustomControls.RJControls.pComboBox cmbDiabetes;
        private CustomControls.RJControls.pComboBox cmbTension;
        private CustomControls.RJControls.pComboBox cmbCardiopatias;
        private CustomControls.RJControls.pComboBox cmbHepatitis;
        private CustomControls.RJControls.pComboBox cmbTiroides;
        private CustomControls.RJControls.pComboBox cmbNeoplasia;
        private CustomControls.RJControls.RJButton BtnEdPat;
        private System.Windows.Forms.Label lblQMed;
        private System.Windows.Forms.Label lblTipIn;
        private System.Windows.Forms.TextBox lblMedic;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApePat;
        private CustomControls.RJControls.RJButton BtnGuPat;
        private CustomControls.RJControls.pComboBox cmbParto;
        private CustomControls.RJControls.pComboBox cmbTabaco;
        private CustomControls.RJControls.pComboBox cmbHiperlax;
        private CustomControls.RJControls.pComboBox cmbFrecTab;
        private CustomControls.RJControls.pComboBox cmbAlc;
        private CustomControls.RJControls.pComboBox cmbFrecAlc;
        private CustomControls.RJControls.RJButton BtnEdNoPat;
        private System.Windows.Forms.Panel pnlNoPat;
        private CustomControls.RJControls.RJButton btnGuNoPat;
        private CustomControls.RJControls.pComboBox cmbDrogas;
        private CustomControls.RJControls.pComboBox cmbFrecActFis;
        private CustomControls.RJControls.pComboBox cmbActFis;
        private System.Windows.Forms.TextBox txtInterv;
        private System.Windows.Forms.Label lblApeMat;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPatologicos;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.pComboBox cmbTipoPat;
        private prueba.TextBoxD txtNombre;
        private prueba.TextBoxD txtApePat;
        private prueba.TextBoxD txtApeMat;
        private prueba.TextBoxD txtEdad;
        private prueba.TextBoxD txtSexo;
        private prueba.TextBoxD txtTelf;
    }
}