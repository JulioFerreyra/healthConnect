namespace CapaPresentacion
{
    partial class NuevoUsuarioForm
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
            this.btnGuardar = new CustomControls.RJControls.RJButton();
            this.txtConfirmar = new prueba.TextBoxD();
            this.txtContra = new prueba.TextBoxD();
            this.txtNombre = new prueba.TextBoxD();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPuesto = new CustomControls.RJControls.pComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "Agregar nuevo usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGuardar.BorderRadius = 15;
            this.btnGuardar.BorderSize = 5;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 4;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(141, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 50);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtConfirmar.BorderColor = System.Drawing.Color.White;
            this.txtConfirmar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtConfirmar.BorderRadius = 0;
            this.txtConfirmar.BorderSize = 2;
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmar.Location = new System.Drawing.Point(96, 384);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmar.MaxLength = 10;
            this.txtConfirmar.Multiline = false;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmar.PasswordChar = false;
            this.txtConfirmar.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtConfirmar.PlaceholderText = "Confirmar contraseña";
            this.txtConfirmar.Size = new System.Drawing.Size(250, 35);
            this.txtConfirmar.TabIndex = 63;
            this.txtConfirmar.Texts = "";
            this.txtConfirmar.UnderlineStyle = true;
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtContra.BorderColor = System.Drawing.Color.White;
            this.txtContra.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContra.BorderRadius = 0;
            this.txtContra.BorderSize = 2;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.Location = new System.Drawing.Point(96, 300);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.MaxLength = 10;
            this.txtContra.Multiline = false;
            this.txtContra.Name = "txtContra";
            this.txtContra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContra.PasswordChar = false;
            this.txtContra.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtContra.PlaceholderText = "Contraseña";
            this.txtContra.Size = new System.Drawing.Size(250, 35);
            this.txtContra.TabIndex = 62;
            this.txtContra.Texts = "";
            this.txtContra.UnderlineStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(96, 138);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNombre.PlaceholderText = "Usuario";
            this.txtNombre.Size = new System.Drawing.Size(250, 35);
            this.txtNombre.TabIndex = 61;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 37);
            this.panel1.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(392, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 40);
            this.button1.TabIndex = 68;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(90, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Confirmar contraseña";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPuesto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPuesto.BorderSize = 1;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPuesto.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPuesto.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Secretaria",
            "Administrador"});
            this.cmbPuesto.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPuesto.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPuesto.Location = new System.Drawing.Point(94, 220);
            this.cmbPuesto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPuesto.Size = new System.Drawing.Size(250, 30);
            this.cmbPuesto.TabIndex = 71;
            this.cmbPuesto.Texts = "Puesto";
            this.cmbPuesto.OnSelectedIndexChanged += new System.EventHandler(this.cmbPuesto_OnSelectedIndexChanged);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.Black;
            this.lblPuesto.Location = new System.Drawing.Point(92, 190);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(74, 24);
            this.lblPuesto.TabIndex = 69;
            this.lblPuesto.Text = "Puesto";
            // 
            // NuevoUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 498);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuarioForm";
            this.Text = "NuevoUsuarioForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnGuardar;
        private prueba.TextBoxD txtConfirmar;
        private prueba.TextBoxD txtContra;
        private prueba.TextBoxD txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.pComboBox cmbPuesto;
        private System.Windows.Forms.Label lblPuesto;
    }
}