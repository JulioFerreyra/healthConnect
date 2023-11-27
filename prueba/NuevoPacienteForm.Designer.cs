namespace prueba
{
    partial class NuevoPacienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPacienteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbxSexo = new CustomControls.RJControls.pComboBox();
            this.dtpFechaNac = new CustomControls.RJControls.pDatePicker();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.txtDireccion = new prueba.TextBoxD();
            this.txtTelefono = new prueba.TextBoxD();
            this.txtApellMat = new prueba.TextBoxD();
            this.txtApellPat = new prueba.TextBoxD();
            this.txtNombre = new prueba.TextBoxD();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 100;
            this.label1.Text = "Agregar nuevo paciente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 37);
            this.panel1.TabIndex = 59;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.btnAyuda.Location = new System.Drawing.Point(284, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 108;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(310, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 37);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbxSexo
            // 
            this.cmbxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxSexo.BorderSize = 1;
            this.cmbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSexo.ForeColor = System.Drawing.Color.White;
            this.cmbxSexo.IconColor = System.Drawing.Color.Black;
            this.cmbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbxSexo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxSexo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbxSexo.Location = new System.Drawing.Point(45, 542);
            this.cmbxSexo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxSexo.Name = "cmbxSexo";
            this.cmbxSexo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxSexo.Size = new System.Drawing.Size(250, 35);
            this.cmbxSexo.TabIndex = 9;
            this.cmbxSexo.Texts = "Sexo";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dtpFechaNac.BorderSize = 1;
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaNac.Location = new System.Drawing.Point(48, 474);
            this.dtpFechaNac.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(247, 35);
            this.dtpFechaNac.SkinColor = System.Drawing.Color.White;
            this.dtpFechaNac.TabIndex = 8;
            this.dtpFechaNac.TextColor = System.Drawing.Color.Black;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 5;
            this.rjButton1.FlatAppearance.BorderSize = 4;
            this.rjButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(87, 600);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(160, 50);
            this.rjButton1.TabIndex = 10;
            this.rjButton1.Text = "Guardar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDireccion.BorderColor = System.Drawing.Color.DimGray;
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtDireccion.BorderRadius = 0;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.Location = new System.Drawing.Point(48, 404);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.White;
            this.txtDireccion.PlaceholderText = "Dirección";
            this.txtDireccion.Size = new System.Drawing.Size(250, 35);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlineStyle = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(48, 334);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.White;
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(250, 35);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlineStyle = true;
            this.txtTelefono._TextChanged += new System.EventHandler(this.txtTelefono__TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtApellMat
            // 
            this.txtApellMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtApellMat.BorderColor = System.Drawing.Color.DimGray;
            this.txtApellMat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtApellMat.BorderRadius = 0;
            this.txtApellMat.BorderSize = 2;
            this.txtApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellMat.Location = new System.Drawing.Point(48, 264);
            this.txtApellMat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellMat.MaxLength = 10;
            this.txtApellMat.Multiline = false;
            this.txtApellMat.Name = "txtApellMat";
            this.txtApellMat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellMat.PasswordChar = false;
            this.txtApellMat.PlaceholderColor = System.Drawing.Color.White;
            this.txtApellMat.PlaceholderText = "Apellido materno";
            this.txtApellMat.Size = new System.Drawing.Size(250, 35);
            this.txtApellMat.TabIndex = 5;
            this.txtApellMat.Texts = "";
            this.txtApellMat.UnderlineStyle = true;
            this.txtApellMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellMat_KeyPress);
            // 
            // txtApellPat
            // 
            this.txtApellPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtApellPat.BorderColor = System.Drawing.Color.DimGray;
            this.txtApellPat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtApellPat.BorderRadius = 0;
            this.txtApellPat.BorderSize = 2;
            this.txtApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellPat.Location = new System.Drawing.Point(48, 194);
            this.txtApellPat.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellPat.MaxLength = 10;
            this.txtApellPat.Multiline = false;
            this.txtApellPat.Name = "txtApellPat";
            this.txtApellPat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellPat.PasswordChar = false;
            this.txtApellPat.PlaceholderColor = System.Drawing.Color.White;
            this.txtApellPat.PlaceholderText = "Apellido paterno";
            this.txtApellPat.Size = new System.Drawing.Size(250, 35);
            this.txtApellPat.TabIndex = 4;
            this.txtApellPat.Texts = "";
            this.txtApellPat.UnderlineStyle = true;
            this.txtApellPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellPat_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(48, 124);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 35);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Nombre*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 102;
            this.label3.Text = "Apellido paterno*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Apellido materno*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 104;
            this.label5.Text = "Teléfono*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(48, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "Dirección*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(49, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 106;
            this.label7.Text = "Fecha de nacimiento*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(49, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 107;
            this.label8.Text = "Sexo*";
            // 
            // NuevoPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 691);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxSexo);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellMat);
            this.Controls.Add(this.txtApellPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoPacienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoPacienteForm";
            this.Load += new System.EventHandler(this.NuevoPacienteForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NuevoPacienteForm_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxD txtNombre;
        private TextBoxD txtApellPat;
        private TextBoxD txtApellMat;
        private TextBoxD txtTelefono;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private TextBoxD txtDireccion;
        private CustomControls.RJControls.pDatePicker dtpFechaNac;
        private CustomControls.RJControls.pComboBox cmbxSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private System.Windows.Forms.ToolTip ttAyuda;
    }
}