namespace CapaPresentacion
{
    partial class EditarPacienteForm
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
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxSexo = new CustomControls.RJControls.pComboBox();
            this.dtpFechaNac = new CustomControls.RJControls.pDatePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombre = new prueba.TextBoxD();
            this.txtApellPat = new prueba.TextBoxD();
            this.txtApellMat = new prueba.TextBoxD();
            this.txtTelefono = new prueba.TextBoxD();
            this.txtDireccion = new prueba.TextBoxD();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnAceptar.BorderRadius = 15;
            this.btnAceptar.BorderSize = 5;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.btnAceptar.FlatAppearance.BorderSize = 4;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(112, 550);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(213, 62);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(71, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Editar paciente";
            // 
            // cmbxSexo
            // 
            this.cmbxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(181)))), ((int)(((byte)(216)))));
            this.cmbxSexo.BorderSize = 1;
            this.cmbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxSexo.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSexo.ForeColor = System.Drawing.Color.White;
            this.cmbxSexo.IconColor = System.Drawing.Color.Blue;
            this.cmbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbxSexo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxSexo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbxSexo.Location = new System.Drawing.Point(70, 488);
            this.cmbxSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxSexo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxSexo.Name = "cmbxSexo";
            this.cmbxSexo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxSexo.Size = new System.Drawing.Size(302, 43);
            this.cmbxSexo.TabIndex = 64;
            this.cmbxSexo.Texts = "Sexo";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dtpFechaNac.BorderSize = 1;
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaNac.Location = new System.Drawing.Point(66, 440);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNac.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(306, 35);
            this.dtpFechaNac.SkinColor = System.Drawing.Color.White;
            this.dtpFechaNac.TabIndex = 63;
            this.dtpFechaNac.TextColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 46);
            this.panel1.TabIndex = 65;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnCancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(399, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 42);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.button2.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1303, -4);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 49);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(66, 135);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(306, 48);
            this.txtNombre.TabIndex = 71;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellPat
            // 
            this.txtApellPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtApellPat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtApellPat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtApellPat.BorderRadius = 0;
            this.txtApellPat.BorderSize = 2;
            this.txtApellPat.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPat.ForeColor = System.Drawing.Color.White;
            this.txtApellPat.Location = new System.Drawing.Point(66, 196);
            this.txtApellPat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellPat.MaxLength = 10;
            this.txtApellPat.Multiline = false;
            this.txtApellPat.Name = "txtApellPat";
            this.txtApellPat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellPat.PasswordChar = false;
            this.txtApellPat.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtApellPat.PlaceholderText = "";
            this.txtApellPat.Size = new System.Drawing.Size(306, 48);
            this.txtApellPat.TabIndex = 72;
            this.txtApellPat.Texts = "";
            this.txtApellPat.UnderlineStyle = false;
            this.txtApellPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellPat_KeyPress_1);
            // 
            // txtApellMat
            // 
            this.txtApellMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtApellMat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtApellMat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtApellMat.BorderRadius = 0;
            this.txtApellMat.BorderSize = 2;
            this.txtApellMat.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMat.ForeColor = System.Drawing.Color.White;
            this.txtApellMat.Location = new System.Drawing.Point(66, 257);
            this.txtApellMat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellMat.MaxLength = 10;
            this.txtApellMat.Multiline = false;
            this.txtApellMat.Name = "txtApellMat";
            this.txtApellMat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellMat.PasswordChar = false;
            this.txtApellMat.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtApellMat.PlaceholderText = "";
            this.txtApellMat.Size = new System.Drawing.Size(306, 48);
            this.txtApellMat.TabIndex = 73;
            this.txtApellMat.Texts = "";
            this.txtApellMat.UnderlineStyle = false;
            this.txtApellMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellMat_KeyPress_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(66, 318);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(306, 48);
            this.txtTelefono.TabIndex = 74;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlineStyle = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDireccion.BorderRadius = 0;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(66, 379);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 10;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.Size = new System.Drawing.Size(306, 48);
            this.txtDireccion.TabIndex = 75;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlineStyle = false;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // EditarPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(452, 631);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellMat);
            this.Controls.Add(this.txtApellPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbxSexo);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarPacienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPacienteForm";
            this.Load += new System.EventHandler(this.EditarPacienteForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnAceptar;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.pComboBox cmbxSexo;
        private CustomControls.RJControls.pDatePicker dtpFechaNac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelar;
        private prueba.TextBoxD txtNombre;
        private prueba.TextBoxD txtApellPat;
        private prueba.TextBoxD txtApellMat;
        private prueba.TextBoxD txtTelefono;
        private prueba.TextBoxD txtDireccion;
    }
}