﻿namespace CapaPresentacion
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
            this.txtAceptar = new CustomControls.RJControls.RJButton();
            this.tbxTelefono = new prueba.TextBoxD();
            this.tbxSintomas = new prueba.TextBoxD();
            this.tbxApellMat = new prueba.TextBoxD();
            this.tbxApellPat = new prueba.TextBoxD();
            this.tbxNombre = new prueba.TextBoxD();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.cmbxEstadoCita = new CustomControls.RJControls.pComboBox();
            this.dtFecha = new CustomControls.RJControls.pDatePicker();
            this.CmbxPodologo = new CustomControls.RJControls.pComboBox();
            this.cmbxHora = new CustomControls.RJControls.pComboBox();
            this.cmbxTipoCita = new CustomControls.RJControls.pComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.BuscarUsuario;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1205, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 55);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(848, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Apellido materno";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(477, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido paterno";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(81, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(477, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sintomas";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(81, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(112, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(77, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 46);
            this.label7.TabIndex = 37;
            this.label7.Text = "Editar cita";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.button2.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1303, -4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 49);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 46);
            this.panel1.TabIndex = 56;
            // 
            // txtAceptar
            // 
            this.txtAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.txtAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.txtAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.txtAceptar.BorderRadius = 13;
            this.txtAceptar.BorderSize = 5;
            this.txtAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.txtAceptar.FlatAppearance.BorderSize = 4;
            this.txtAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.txtAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.txtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtAceptar.ForeColor = System.Drawing.Color.White;
            this.txtAceptar.Location = new System.Drawing.Point(961, 578);
            this.txtAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(151, 74);
            this.txtAceptar.TabIndex = 38;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.TextColor = System.Drawing.Color.White;
            this.txtAceptar.UseCompatibleTextRendering = true;
            this.txtAceptar.UseVisualStyleBackColor = false;
            this.txtAceptar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxTelefono.BackColor = System.Drawing.Color.Silver;
            this.tbxTelefono.BorderColor = System.Drawing.Color.Silver;
            this.tbxTelefono.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxTelefono.BorderRadius = 8;
            this.tbxTelefono.BorderSize = 2;
            this.tbxTelefono.Enabled = false;
            this.tbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbxTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.tbxTelefono.Location = new System.Drawing.Point(87, 303);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.tbxTelefono.MaxLength = 10;
            this.tbxTelefono.Multiline = false;
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxTelefono.PasswordChar = false;
            this.tbxTelefono.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxTelefono.PlaceholderText = "";
            this.tbxTelefono.Size = new System.Drawing.Size(333, 46);
            this.tbxTelefono.TabIndex = 30;
            this.tbxTelefono.Texts = "";
            this.tbxTelefono.UnderlineStyle = false;
            // 
            // tbxSintomas
            // 
            this.tbxSintomas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxSintomas.BackColor = System.Drawing.Color.Silver;
            this.tbxSintomas.BorderColor = System.Drawing.Color.Silver;
            this.tbxSintomas.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxSintomas.BorderRadius = 8;
            this.tbxSintomas.BorderSize = 2;
            this.tbxSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbxSintomas.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSintomas.Location = new System.Drawing.Point(461, 303);
            this.tbxSintomas.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSintomas.MaxLength = 10;
            this.tbxSintomas.Multiline = false;
            this.tbxSintomas.Name = "tbxSintomas";
            this.tbxSintomas.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxSintomas.PasswordChar = false;
            this.tbxSintomas.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxSintomas.PlaceholderText = "";
            this.tbxSintomas.Size = new System.Drawing.Size(333, 46);
            this.tbxSintomas.TabIndex = 29;
            this.tbxSintomas.Texts = "";
            this.tbxSintomas.UnderlineStyle = false;
            // 
            // tbxApellMat
            // 
            this.tbxApellMat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxApellMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxApellMat.BorderColor = System.Drawing.Color.Silver;
            this.tbxApellMat.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxApellMat.BorderRadius = 8;
            this.tbxApellMat.BorderSize = 2;
            this.tbxApellMat.Enabled = false;
            this.tbxApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbxApellMat.ForeColor = System.Drawing.Color.DimGray;
            this.tbxApellMat.Location = new System.Drawing.Point(837, 150);
            this.tbxApellMat.Margin = new System.Windows.Forms.Padding(5);
            this.tbxApellMat.MaxLength = 10;
            this.tbxApellMat.Multiline = false;
            this.tbxApellMat.Name = "tbxApellMat";
            this.tbxApellMat.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxApellMat.PasswordChar = false;
            this.tbxApellMat.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxApellMat.PlaceholderText = "";
            this.tbxApellMat.Size = new System.Drawing.Size(333, 46);
            this.tbxApellMat.TabIndex = 27;
            this.tbxApellMat.Texts = "";
            this.tbxApellMat.UnderlineStyle = false;
            // 
            // tbxApellPat
            // 
            this.tbxApellPat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxApellPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxApellPat.BorderColor = System.Drawing.Color.Silver;
            this.tbxApellPat.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxApellPat.BorderRadius = 8;
            this.tbxApellPat.BorderSize = 2;
            this.tbxApellPat.Enabled = false;
            this.tbxApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbxApellPat.ForeColor = System.Drawing.Color.DimGray;
            this.tbxApellPat.Location = new System.Drawing.Point(461, 150);
            this.tbxApellPat.Margin = new System.Windows.Forms.Padding(5);
            this.tbxApellPat.MaxLength = 10;
            this.tbxApellPat.Multiline = false;
            this.tbxApellPat.Name = "tbxApellPat";
            this.tbxApellPat.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxApellPat.PasswordChar = false;
            this.tbxApellPat.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxApellPat.PlaceholderText = "";
            this.tbxApellPat.Size = new System.Drawing.Size(333, 46);
            this.tbxApellPat.TabIndex = 26;
            this.tbxApellPat.Texts = "";
            this.tbxApellPat.UnderlineStyle = false;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tbxNombre.BorderColor = System.Drawing.Color.Silver;
            this.tbxNombre.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxNombre.BorderRadius = 8;
            this.tbxNombre.BorderSize = 2;
            this.tbxNombre.Enabled = false;
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbxNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbxNombre.Location = new System.Drawing.Point(87, 150);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(5);
            this.tbxNombre.MaxLength = 10;
            this.tbxNombre.Multiline = false;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxNombre.PasswordChar = false;
            this.tbxNombre.PlaceholderColor = System.Drawing.Color.Violet;
            this.tbxNombre.PlaceholderText = "";
            this.tbxNombre.Size = new System.Drawing.Size(333, 46);
            this.tbxNombre.TabIndex = 25;
            this.tbxNombre.Texts = "";
            this.tbxNombre.UnderlineStyle = false;
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rjButton4.BorderRadius = 15;
            this.rjButton4.BorderSize = 5;
            this.rjButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton4.FlatAppearance.BorderSize = 4;
            this.rjButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rjButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(461, 583);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(264, 69);
            this.rjButton4.TabIndex = 23;
            this.rjButton4.Text = "Agregar resultado ";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // cmbxEstadoCita
            // 
            this.cmbxEstadoCita.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbxEstadoCita.BackColor = System.Drawing.Color.Transparent;
            this.cmbxEstadoCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.cmbxEstadoCita.BorderSize = 1;
            this.cmbxEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEstadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbxEstadoCita.ForeColor = System.Drawing.Color.Black;
            this.cmbxEstadoCita.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbxEstadoCita.Items.AddRange(new object[] {
            "Pendiente",
            "Finalizada"});
            this.cmbxEstadoCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxEstadoCita.ListTextColor = System.Drawing.Color.Black;
            this.cmbxEstadoCita.Location = new System.Drawing.Point(87, 578);
            this.cmbxEstadoCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxEstadoCita.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxEstadoCita.Name = "cmbxEstadoCita";
            this.cmbxEstadoCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxEstadoCita.Size = new System.Drawing.Size(333, 69);
            this.cmbxEstadoCita.TabIndex = 22;
            this.cmbxEstadoCita.Texts = "Estado de la cita";
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtFecha.BorderColor = System.Drawing.Color.Lime;
            this.dtFecha.BorderSize = 2;
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtFecha.Location = new System.Drawing.Point(88, 436);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(332, 35);
            this.dtFecha.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtFecha.TabIndex = 18;
            this.dtFecha.TextColor = System.Drawing.Color.White;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // CmbxPodologo
            // 
            this.CmbxPodologo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbxPodologo.BackColor = System.Drawing.Color.Transparent;
            this.CmbxPodologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.CmbxPodologo.BorderSize = 1;
            this.CmbxPodologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxPodologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbxPodologo.ForeColor = System.Drawing.Color.Black;
            this.CmbxPodologo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CmbxPodologo.Items.AddRange(new object[] {
            "Xochitl Tello González",
            "Ignacio Tello Gónzález"});
            this.CmbxPodologo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CmbxPodologo.ListTextColor = System.Drawing.Color.Black;
            this.CmbxPodologo.Location = new System.Drawing.Point(461, 436);
            this.CmbxPodologo.Margin = new System.Windows.Forms.Padding(4);
            this.CmbxPodologo.MinimumSize = new System.Drawing.Size(267, 37);
            this.CmbxPodologo.Name = "CmbxPodologo";
            this.CmbxPodologo.Padding = new System.Windows.Forms.Padding(1);
            this.CmbxPodologo.Size = new System.Drawing.Size(333, 69);
            this.CmbxPodologo.TabIndex = 17;
            this.CmbxPodologo.Texts = "Podólogo";
            this.CmbxPodologo.OnSelectedIndexChanged += new System.EventHandler(this.CmbxPodologo_OnSelectedIndexChanged);
            // 
            // cmbxHora
            // 
            this.cmbxHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbxHora.BackColor = System.Drawing.Color.Transparent;
            this.cmbxHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.cmbxHora.BorderSize = 1;
            this.cmbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbxHora.ForeColor = System.Drawing.Color.Black;
            this.cmbxHora.IconColor = System.Drawing.Color.MediumSlateBlue;
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
            this.cmbxHora.Location = new System.Drawing.Point(853, 436);
            this.cmbxHora.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxHora.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxHora.Name = "cmbxHora";
            this.cmbxHora.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxHora.Size = new System.Drawing.Size(333, 69);
            this.cmbxHora.TabIndex = 16;
            this.cmbxHora.Texts = "Hora";
            // 
            // cmbxTipoCita
            // 
            this.cmbxTipoCita.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbxTipoCita.BackColor = System.Drawing.Color.Transparent;
            this.cmbxTipoCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.cmbxTipoCita.BorderSize = 1;
            this.cmbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbxTipoCita.ForeColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbxTipoCita.Items.AddRange(new object[] {
            "Examen",
            "Limpieza",
            "Consulta General",
            "Otro"});
            this.cmbxTipoCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxTipoCita.ListTextColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.Location = new System.Drawing.Point(853, 303);
            this.cmbxTipoCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxTipoCita.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxTipoCita.Name = "cmbxTipoCita";
            this.cmbxTipoCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxTipoCita.Size = new System.Drawing.Size(333, 69);
            this.cmbxTipoCita.TabIndex = 15;
            this.cmbxTipoCita.Texts = "Tipo de cita";
            // 
            // EditarCitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1367, 750);
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
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.cmbxEstadoCita);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.CmbxPodologo);
            this.Controls.Add(this.cmbxHora);
            this.Controls.Add(this.cmbxTipoCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarCitaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCitaForm";
            this.Load += new System.EventHandler(this.EditarCitaForm_Load);
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
        private CustomControls.RJControls.pComboBox cmbxEstadoCita;
        private CustomControls.RJControls.RJButton rjButton4;
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
    }
}