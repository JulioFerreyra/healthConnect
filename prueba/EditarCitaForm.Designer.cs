namespace CapaPresentacion
{
    partial class EditarCitaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCitaForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.txtAceptar = new CustomControls.RJControls.RJButton();
            this.tbxTelefono = new prueba.TextBoxD();
            this.tbxSintomas = new prueba.TextBoxD();
            this.tbxApellMat = new prueba.TextBoxD();
            this.tbxApellPat = new prueba.TextBoxD();
            this.tbxNombre = new prueba.TextBoxD();
            this.btnFinalizar = new CustomControls.RJControls.RJButton();
            this.dtFecha = new CustomControls.RJControls.pDatePicker();
            this.CmbxPodologo = new CustomControls.RJControls.pComboBox();
            this.cmbxHora = new CustomControls.RJControls.pComboBox();
            this.cmbxTipoCita = new CustomControls.RJControls.pComboBox();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1124, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(575, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Apellido materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(300, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label6.Location = new System.Drawing.Point(38, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sintomas*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label5.Location = new System.Drawing.Point(857, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(255, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label7.Location = new System.Drawing.Point(27, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 37);
            this.label7.TabIndex = 37;
            this.label7.Text = "Editar cita";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1155, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 34);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 37);
            this.panel1.TabIndex = 56;
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
            this.btnAyuda.Location = new System.Drawing.Point(1108, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 101;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // txtAceptar
            // 
            this.txtAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtAceptar.BorderRadius = 13;
            this.txtAceptar.BorderSize = 5;
            this.txtAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAceptar.FlatAppearance.BorderSize = 4;
            this.txtAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.txtAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.txtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAceptar.ForeColor = System.Drawing.Color.White;
            this.txtAceptar.Location = new System.Drawing.Point(911, 297);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(190, 56);
            this.txtAceptar.TabIndex = 7;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.TextColor = System.Drawing.Color.White;
            this.txtAceptar.UseCompatibleTextRendering = true;
            this.txtAceptar.UseVisualStyleBackColor = false;
            this.txtAceptar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.BackColor = System.Drawing.Color.Silver;
            this.tbxTelefono.BorderColor = System.Drawing.Color.Silver;
            this.tbxTelefono.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxTelefono.BorderRadius = 8;
            this.tbxTelefono.BorderSize = 2;
            this.tbxTelefono.Enabled = false;
            this.tbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxTelefono.Location = new System.Drawing.Point(851, 123);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTelefono.MaxLength = 10;
            this.tbxTelefono.Multiline = false;
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxTelefono.PasswordChar = false;
            this.tbxTelefono.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxTelefono.PlaceholderText = "";
            this.tbxTelefono.Size = new System.Drawing.Size(250, 33);
            this.tbxTelefono.TabIndex = 100;
            this.tbxTelefono.Texts = "";
            this.tbxTelefono.UnderlineStyle = false;
            // 
            // tbxSintomas
            // 
            this.tbxSintomas.BackColor = System.Drawing.Color.LightGray;
            this.tbxSintomas.BorderColor = System.Drawing.Color.Silver;
            this.tbxSintomas.BorderFocusColor = System.Drawing.Color.White;
            this.tbxSintomas.BorderRadius = 8;
            this.tbxSintomas.BorderSize = 2;
            this.tbxSintomas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSintomas.ForeColor = System.Drawing.Color.Black;
            this.tbxSintomas.Location = new System.Drawing.Point(40, 297);
            this.tbxSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSintomas.MaxLength = 10;
            this.tbxSintomas.Multiline = true;
            this.tbxSintomas.Name = "tbxSintomas";
            this.tbxSintomas.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxSintomas.PasswordChar = false;
            this.tbxSintomas.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxSintomas.PlaceholderText = "";
            this.tbxSintomas.Size = new System.Drawing.Size(789, 204);
            this.tbxSintomas.TabIndex = 6;
            this.tbxSintomas.Texts = "";
            this.tbxSintomas.UnderlineStyle = false;
            // 
            // tbxApellMat
            // 
            this.tbxApellMat.BackColor = System.Drawing.Color.Silver;
            this.tbxApellMat.BorderColor = System.Drawing.Color.Silver;
            this.tbxApellMat.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxApellMat.BorderRadius = 8;
            this.tbxApellMat.BorderSize = 2;
            this.tbxApellMat.Enabled = false;
            this.tbxApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellMat.ForeColor = System.Drawing.Color.DimGray;
            this.tbxApellMat.Location = new System.Drawing.Point(579, 123);
            this.tbxApellMat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxApellMat.MaxLength = 10;
            this.tbxApellMat.Multiline = false;
            this.tbxApellMat.Name = "tbxApellMat";
            this.tbxApellMat.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxApellMat.PasswordChar = false;
            this.tbxApellMat.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxApellMat.PlaceholderText = "";
            this.tbxApellMat.Size = new System.Drawing.Size(250, 33);
            this.tbxApellMat.TabIndex = 100;
            this.tbxApellMat.Texts = "";
            this.tbxApellMat.UnderlineStyle = false;
            // 
            // tbxApellPat
            // 
            this.tbxApellPat.BackColor = System.Drawing.Color.Silver;
            this.tbxApellPat.BorderColor = System.Drawing.Color.Silver;
            this.tbxApellPat.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxApellPat.BorderRadius = 8;
            this.tbxApellPat.BorderSize = 2;
            this.tbxApellPat.Enabled = false;
            this.tbxApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellPat.ForeColor = System.Drawing.Color.DimGray;
            this.tbxApellPat.Location = new System.Drawing.Point(305, 123);
            this.tbxApellPat.Margin = new System.Windows.Forms.Padding(4);
            this.tbxApellPat.MaxLength = 10;
            this.tbxApellPat.Multiline = false;
            this.tbxApellPat.Name = "tbxApellPat";
            this.tbxApellPat.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxApellPat.PasswordChar = false;
            this.tbxApellPat.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxApellPat.PlaceholderText = "";
            this.tbxApellPat.Size = new System.Drawing.Size(250, 33);
            this.tbxApellPat.TabIndex = 100;
            this.tbxApellPat.Texts = "";
            this.tbxApellPat.UnderlineStyle = false;
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.Silver;
            this.tbxNombre.BorderColor = System.Drawing.Color.Silver;
            this.tbxNombre.BorderFocusColor = System.Drawing.Color.White;
            this.tbxNombre.BorderRadius = 8;
            this.tbxNombre.BorderSize = 2;
            this.tbxNombre.Enabled = false;
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbxNombre.Location = new System.Drawing.Point(33, 123);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.MaxLength = 10;
            this.tbxNombre.Multiline = false;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxNombre.PasswordChar = false;
            this.tbxNombre.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxNombre.PlaceholderText = "";
            this.tbxNombre.Size = new System.Drawing.Size(250, 33);
            this.tbxNombre.TabIndex = 100;
            this.tbxNombre.Texts = "";
            this.tbxNombre.UnderlineStyle = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnFinalizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnFinalizar.BorderColor = System.Drawing.Color.White;
            this.btnFinalizar.BorderRadius = 15;
            this.btnFinalizar.BorderSize = 5;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 4;
            this.btnFinalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(40, 534);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(144, 45);
            this.btnFinalizar.TabIndex = 100;
            this.btnFinalizar.Text = "Finalizar Cita";
            this.btnFinalizar.TextColor = System.Drawing.Color.White;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dtFecha.BorderSize = 2;
            this.dtFecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFecha.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtFecha.Location = new System.Drawing.Point(305, 200);
            this.dtFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(250, 35);
            this.dtFecha.SkinColor = System.Drawing.Color.White;
            this.dtFecha.TabIndex = 3;
            this.dtFecha.TextColor = System.Drawing.Color.Black;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // CmbxPodologo
            // 
            this.CmbxPodologo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.CmbxPodologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CmbxPodologo.BorderSize = 1;
            this.CmbxPodologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbxPodologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxPodologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbxPodologo.ForeColor = System.Drawing.Color.White;
            this.CmbxPodologo.IconColor = System.Drawing.Color.Blue;
            this.CmbxPodologo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CmbxPodologo.ListTextColor = System.Drawing.Color.Black;
            this.CmbxPodologo.Location = new System.Drawing.Point(40, 200);
            this.CmbxPodologo.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbxPodologo.Name = "CmbxPodologo";
            this.CmbxPodologo.Padding = new System.Windows.Forms.Padding(1);
            this.CmbxPodologo.Size = new System.Drawing.Size(243, 35);
            this.CmbxPodologo.TabIndex = 2;
            this.CmbxPodologo.Texts = "Podólogo";
            this.CmbxPodologo.OnSelectedIndexChanged += new System.EventHandler(this.CmbxPodologo_OnSelectedIndexChanged);
            // 
            // cmbxHora
            // 
            this.cmbxHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cmbxHora.BorderSize = 1;
            this.cmbxHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxHora.ForeColor = System.Drawing.Color.White;
            this.cmbxHora.IconColor = System.Drawing.Color.Blue;
            this.cmbxHora.Items.AddRange(new object[] {
            "8:00",
            "8:15",
            "8:30",
            "8:45",
            "9:00",
            "9:15",
            "9:30",
            "9:45",
            "10:00"});
            this.cmbxHora.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxHora.ListTextColor = System.Drawing.Color.Black;
            this.cmbxHora.Location = new System.Drawing.Point(579, 200);
            this.cmbxHora.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxHora.Name = "cmbxHora";
            this.cmbxHora.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxHora.Size = new System.Drawing.Size(250, 35);
            this.cmbxHora.TabIndex = 3;
            this.cmbxHora.Texts = "Hora";
            // 
            // cmbxTipoCita
            // 
            this.cmbxTipoCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxTipoCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cmbxTipoCita.BorderSize = 1;
            this.cmbxTipoCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipoCita.ForeColor = System.Drawing.Color.White;
            this.cmbxTipoCita.IconColor = System.Drawing.Color.Blue;
            this.cmbxTipoCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxTipoCita.ListTextColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.Location = new System.Drawing.Point(851, 200);
            this.cmbxTipoCita.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxTipoCita.Name = "cmbxTipoCita";
            this.cmbxTipoCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxTipoCita.Size = new System.Drawing.Size(250, 35);
            this.cmbxTipoCita.TabIndex = 5;
            this.cmbxTipoCita.Texts = "Tipo de cita";
            // 
            // EditarCitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1196, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxSintomas);
            this.Controls.Add(this.tbxApellMat);
            this.Controls.Add(this.tbxApellPat);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.CmbxPodologo);
            this.Controls.Add(this.cmbxHora);
            this.Controls.Add(this.cmbxTipoCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarCitaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCitaForm";
            this.Load += new System.EventHandler(this.EditarCitaForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditarCitaForm_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.pDatePicker dtFecha;
        private CustomControls.RJControls.pComboBox CmbxPodologo;
        private CustomControls.RJControls.pComboBox cmbxHora;
        private CustomControls.RJControls.pComboBox cmbxTipoCita;
        private System.Windows.Forms.Button button1;
        private prueba.TextBoxD tbxNombre;
        private prueba.TextBoxD tbxApellPat;
        private prueba.TextBoxD tbxApellMat;
        private prueba.TextBoxD tbxSintomas;
        private prueba.TextBoxD tbxTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJButton txtAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnFinalizar;
        private System.Windows.Forms.ToolTip ttAyuda;
        private FontAwesome.Sharp.IconButton btnAyuda;
    }
}