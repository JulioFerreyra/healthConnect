namespace CapaPresentacion
{
    partial class FormPanelSecretaria
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
            this.btnPrincipal = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Panelformularios = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnNuevaCita = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.btnCitasConfirmar = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnInicioUsuario = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnCitasConfirmar);
            this.panel1.Controls.Add(this.btnPacientes);
            this.panel1.Controls.Add(this.btnNuevaCita);
            this.panel1.Controls.Add(this.btnPrincipal);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 1055);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnPrincipal.IconColor = System.Drawing.Color.White;
            this.btnPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrincipal.IconSize = 55;
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 319);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(415, 80);
            this.btnPrincipal.TabIndex = 14;
            this.btnPrincipal.Text = "Pantalla Principal";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2023_10_24_at_9_19_07_PM;
            this.pictureBox1.Location = new System.Drawing.Point(36, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.btnInicioUsuario);
            this.panel3.Controls.Add(this.pnlMenu);
            this.panel3.Controls.Add(this.iconCurrentChildForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(415, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1509, 96);
            this.panel3.TabIndex = 8;
            // 
            // Panelformularios
            // 
            this.Panelformularios.AutoSize = true;
            this.Panelformularios.BackColor = System.Drawing.Color.White;
            this.Panelformularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelformularios.Location = new System.Drawing.Point(415, 96);
            this.Panelformularios.Margin = new System.Windows.Forms.Padding(4);
            this.Panelformularios.Name = "Panelformularios";
            this.Panelformularios.Size = new System.Drawing.Size(1509, 959);
            this.Panelformularios.TabIndex = 1;
            this.Panelformularios.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelformularios_Paint);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 49;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 25);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(65, 49);
            this.iconCurrentChildForm.TabIndex = 15;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCita.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnNuevaCita.IconColor = System.Drawing.Color.White;
            this.btnNuevaCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaCita.IconSize = 55;
            this.btnNuevaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.Location = new System.Drawing.Point(0, 403);
            this.btnNuevaCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(415, 80);
            this.btnNuevaCita.TabIndex = 15;
            this.btnNuevaCita.Text = "Nueva Cita";
            this.btnNuevaCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnPacientes.IconColor = System.Drawing.Color.White;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.IconSize = 55;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 487);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(415, 80);
            this.btnPacientes.TabIndex = 16;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // btnCitasConfirmar
            // 
            this.btnCitasConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnCitasConfirmar.FlatAppearance.BorderSize = 0;
            this.btnCitasConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitasConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnCitasConfirmar.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnCitasConfirmar.IconColor = System.Drawing.Color.White;
            this.btnCitasConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitasConfirmar.IconSize = 55;
            this.btnCitasConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitasConfirmar.Location = new System.Drawing.Point(0, 571);
            this.btnCitasConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCitasConfirmar.Name = "btnCitasConfirmar";
            this.btnCitasConfirmar.Size = new System.Drawing.Size(415, 80);
            this.btnCitasConfirmar.TabIndex = 17;
            this.btnCitasConfirmar.Text = "Citas por confirmar";
            this.btnCitasConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitasConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitasConfirmar.UseVisualStyleBackColor = false;
            this.btnCitasConfirmar.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.Black;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 20;
            this.btnAyuda.Location = new System.Drawing.Point(-1, -1);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(136, 30);
            this.btnAyuda.TabIndex = 16;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnAyuda);
            this.pnlMenu.Location = new System.Drawing.Point(1295, 39);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(138, 54);
            this.pnlMenu.TabIndex = 17;
            this.pnlMenu.Visible = false;
            // 
            // btnInicioUsuario
            // 
            this.btnInicioUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnInicioUsuario.FlatAppearance.BorderSize = 0;
            this.btnInicioUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnInicioUsuario.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnInicioUsuario.IconColor = System.Drawing.Color.Black;
            this.btnInicioUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicioUsuario.IconSize = 30;
            this.btnInicioUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicioUsuario.Location = new System.Drawing.Point(1234, 4);
            this.btnInicioUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioUsuario.Name = "btnInicioUsuario";
            this.btnInicioUsuario.Size = new System.Drawing.Size(253, 30);
            this.btnInicioUsuario.TabIndex = 3;
            this.btnInicioUsuario.Text = "Nombre de usuario";
            this.btnInicioUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicioUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInicioUsuario.UseVisualStyleBackColor = false;
            this.btnInicioUsuario.Click += new System.EventHandler(this.btnInicioUsuario_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 20;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1, 29);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(136, 30);
            this.btnCerrarSesion.TabIndex = 17;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Visible = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(78, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 36);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "d";
            // 
            // FormPanelSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Panelformularios);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPanelSecretaria";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel Panelformularios;
        private FontAwesome.Sharp.IconButton btnPrincipal;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnCitasConfirmar;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnNuevaCita;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnInicioUsuario;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Label lblTitulo;
    }
}