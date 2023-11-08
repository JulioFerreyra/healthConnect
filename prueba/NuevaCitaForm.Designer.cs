namespace prueba
{
    partial class NuevaCitaForm
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
            this.dgPodologos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAñadir = new CustomControls.RJControls.RJButton();
            this.tbxSintomas = new prueba.TextBoxD();
            this.tbxTelefono = new prueba.TextBoxD();
            this.tbxApellMat = new prueba.TextBoxD();
            this.tbxApellPat = new prueba.TextBoxD();
            this.tbxNombre = new prueba.TextBoxD();
            this.dtFechaCita = new CustomControls.RJControls.pDatePicker();
            this.cmbxPodologo = new CustomControls.RJControls.pComboBox();
            this.cmbxHora = new CustomControls.RJControls.pComboBox();
            this.cmbxTipoCita = new CustomControls.RJControls.pComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodologos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPodologos
            // 
            this.dgPodologos.AllowUserToAddRows = false;
            this.dgPodologos.AllowUserToDeleteRows = false;
            this.dgPodologos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPodologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPodologos.Location = new System.Drawing.Point(140, 656);
            this.dgPodologos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgPodologos.Name = "dgPodologos";
            this.dgPodologos.ReadOnly = true;
            this.dgPodologos.RowHeadersWidth = 51;
            this.dgPodologos.Size = new System.Drawing.Size(1395, 389);
            this.dgPodologos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(131, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "Crear nueva cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(163, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(559, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(929, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Apellido materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label5.Location = new System.Drawing.Point(163, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label6.Location = new System.Drawing.Point(559, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sintomas";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAñadir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAñadir.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BorderRadius = 10;
            this.btnAñadir.BorderSize = 0;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(1324, 538);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(200, 50);
            this.btnAñadir.TabIndex = 19;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextColor = System.Drawing.Color.White;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // tbxSintomas
            // 
            this.tbxSintomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxSintomas.BorderColor = System.Drawing.Color.Transparent;
            this.tbxSintomas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxSintomas.BorderRadius = 8;
            this.tbxSintomas.BorderSize = 0;
            this.tbxSintomas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSintomas.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSintomas.Location = new System.Drawing.Point(549, 308);
            this.tbxSintomas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxSintomas.MaxLength = 100;
            this.tbxSintomas.Multiline = true;
            this.tbxSintomas.Name = "tbxSintomas";
            this.tbxSintomas.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxSintomas.PasswordChar = false;
            this.tbxSintomas.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxSintomas.PlaceholderText = "";
            this.tbxSintomas.Size = new System.Drawing.Size(704, 176);
            this.tbxSintomas.TabIndex = 17;
            this.tbxSintomas.Texts = "";
            this.tbxSintomas.UnderlineStyle = false;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxTelefono.BorderColor = System.Drawing.Color.Transparent;
            this.tbxTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxTelefono.BorderRadius = 8;
            this.tbxTelefono.BorderSize = 0;
            this.tbxTelefono.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxTelefono.Enabled = false;
            this.tbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxTelefono.Location = new System.Drawing.Point(168, 308);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxTelefono.MaxLength = 10;
            this.tbxTelefono.Multiline = false;
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxTelefono.PasswordChar = false;
            this.tbxTelefono.PlaceholderColor = System.Drawing.Color.White;
            this.tbxTelefono.PlaceholderText = "";
            this.tbxTelefono.Size = new System.Drawing.Size(333, 46);
            this.tbxTelefono.TabIndex = 16;
            this.tbxTelefono.Texts = "";
            this.tbxTelefono.UnderlineStyle = false;
            // 
            // tbxApellMat
            // 
            this.tbxApellMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxApellMat.BorderColor = System.Drawing.Color.Transparent;
            this.tbxApellMat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxApellMat.BorderRadius = 8;
            this.tbxApellMat.BorderSize = 0;
            this.tbxApellMat.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxApellMat.Enabled = false;
            this.tbxApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellMat.ForeColor = System.Drawing.Color.White;
            this.tbxApellMat.Location = new System.Drawing.Point(935, 178);
            this.tbxApellMat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxApellMat.MaxLength = 10;
            this.tbxApellMat.Multiline = false;
            this.tbxApellMat.Name = "tbxApellMat";
            this.tbxApellMat.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxApellMat.PasswordChar = false;
            this.tbxApellMat.PlaceholderColor = System.Drawing.Color.White;
            this.tbxApellMat.PlaceholderText = "";
            this.tbxApellMat.Size = new System.Drawing.Size(333, 46);
            this.tbxApellMat.TabIndex = 15;
            this.tbxApellMat.Texts = "";
            this.tbxApellMat.UnderlineStyle = false;
            // 
            // tbxApellPat
            // 
            this.tbxApellPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxApellPat.BorderColor = System.Drawing.Color.Transparent;
            this.tbxApellPat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxApellPat.BorderRadius = 8;
            this.tbxApellPat.BorderSize = 0;
            this.tbxApellPat.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxApellPat.Enabled = false;
            this.tbxApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellPat.ForeColor = System.Drawing.Color.White;
            this.tbxApellPat.Location = new System.Drawing.Point(549, 178);
            this.tbxApellPat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxApellPat.MaxLength = 10;
            this.tbxApellPat.Multiline = false;
            this.tbxApellPat.Name = "tbxApellPat";
            this.tbxApellPat.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxApellPat.PasswordChar = false;
            this.tbxApellPat.PlaceholderColor = System.Drawing.Color.White;
            this.tbxApellPat.PlaceholderText = "";
            this.tbxApellPat.Size = new System.Drawing.Size(333, 46);
            this.tbxApellPat.TabIndex = 14;
            this.tbxApellPat.Texts = "";
            this.tbxApellPat.UnderlineStyle = false;
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxNombre.BorderColor = System.Drawing.Color.Transparent;
            this.tbxNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxNombre.BorderRadius = 8;
            this.tbxNombre.BorderSize = 0;
            this.tbxNombre.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxNombre.Enabled = false;
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.ForeColor = System.Drawing.Color.White;
            this.tbxNombre.Location = new System.Drawing.Point(168, 178);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxNombre.MaxLength = 10;
            this.tbxNombre.Multiline = false;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxNombre.PasswordChar = false;
            this.tbxNombre.PlaceholderColor = System.Drawing.Color.White;
            this.tbxNombre.PlaceholderText = "";
            this.tbxNombre.Size = new System.Drawing.Size(333, 46);
            this.tbxNombre.TabIndex = 13;
            this.tbxNombre.Texts = "";
            this.tbxNombre.UnderlineStyle = false;
            // 
            // dtFechaCita
            // 
            this.dtFechaCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dtFechaCita.BorderSize = 2;
            this.dtFechaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtFechaCita.Location = new System.Drawing.Point(549, 539);
            this.dtFechaCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaCita.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtFechaCita.Name = "dtFechaCita";
            this.dtFechaCita.Size = new System.Drawing.Size(333, 35);
            this.dtFechaCita.SkinColor = System.Drawing.Color.White;
            this.dtFechaCita.TabIndex = 8;
            this.dtFechaCita.TextColor = System.Drawing.Color.Black;
            this.dtFechaCita.ValueChanged += new System.EventHandler(this.dtFechaCita_ValueChanged);
            // 
            // cmbxPodologo
            // 
            this.cmbxPodologo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxPodologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxPodologo.BorderSize = 1;
            this.cmbxPodologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxPodologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPodologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPodologo.ForeColor = System.Drawing.Color.White;
            this.cmbxPodologo.IconColor = System.Drawing.Color.Black;
            this.cmbxPodologo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxPodologo.ListTextColor = System.Drawing.Color.Black;
            this.cmbxPodologo.Location = new System.Drawing.Point(168, 539);
            this.cmbxPodologo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxPodologo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxPodologo.Name = "cmbxPodologo";
            this.cmbxPodologo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxPodologo.Size = new System.Drawing.Size(333, 50);
            this.cmbxPodologo.TabIndex = 7;
            this.cmbxPodologo.Texts = "Podólogo";
            this.cmbxPodologo.OnSelectedIndexChanged += new System.EventHandler(this.cmbxPodologo_OnSelectedIndexChanged);
            // 
            // cmbxHora
            // 
            this.cmbxHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxHora.BorderSize = 1;
            this.cmbxHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxHora.ForeColor = System.Drawing.Color.White;
            this.cmbxHora.IconColor = System.Drawing.Color.Black;
            this.cmbxHora.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxHora.ListTextColor = System.Drawing.Color.Black;
            this.cmbxHora.Location = new System.Drawing.Point(933, 539);
            this.cmbxHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxHora.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxHora.Name = "cmbxHora";
            this.cmbxHora.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxHora.Size = new System.Drawing.Size(333, 50);
            this.cmbxHora.TabIndex = 6;
            this.cmbxHora.Texts = "Hora";
            // 
            // cmbxTipoCita
            // 
            this.cmbxTipoCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxTipoCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxTipoCita.BorderSize = 1;
            this.cmbxTipoCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipoCita.ForeColor = System.Drawing.Color.White;
            this.cmbxTipoCita.IconColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.Items.AddRange(new object[] {
            "Examen",
            "Limpieza",
            "Consulta General",
            "Otro"});
            this.cmbxTipoCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxTipoCita.ListTextColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.Location = new System.Drawing.Point(168, 412);
            this.cmbxTipoCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxTipoCita.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxTipoCita.Name = "cmbxTipoCita";
            this.cmbxTipoCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxTipoCita.Size = new System.Drawing.Size(333, 50);
            this.cmbxTipoCita.TabIndex = 5;
            this.cmbxTipoCita.Texts = "Tipo de cita";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1293, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 55);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevaCitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 1044);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSintomas);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxApellMat);
            this.Controls.Add(this.tbxApellPat);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgPodologos);
            this.Controls.Add(this.dtFechaCita);
            this.Controls.Add(this.cmbxPodologo);
            this.Controls.Add(this.cmbxHora);
            this.Controls.Add(this.cmbxTipoCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NuevaCitaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaCitaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NuevaCitaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPodologos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.pComboBox cmbxTipoCita;
        private CustomControls.RJControls.pComboBox cmbxHora;
        private CustomControls.RJControls.pComboBox cmbxPodologo;
        private CustomControls.RJControls.pDatePicker dtFechaCita;
        private System.Windows.Forms.DataGridView dgPodologos;
        private System.Windows.Forms.Button button1;
        private TextBoxD tbxNombre;
        private TextBoxD tbxApellPat;
        private TextBoxD tbxApellMat;
        private TextBoxD tbxTelefono;
        private TextBoxD tbxSintomas;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btnAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}