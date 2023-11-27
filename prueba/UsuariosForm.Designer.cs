﻿namespace CapaPresentacion
{
    partial class UsuariosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.VerContraseñaCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarProfesionsitas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProfesionistas = new System.Windows.Forms.DataGridView();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnAyudaProf = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesionistas)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label7.Location = new System.Drawing.Point(504, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 37);
            this.label7.TabIndex = 44;
            this.label7.Text = "Usuarios";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.usuarioCol,
            this.PuestoCol,
            this.sucursalCol,
            this.EliminarCol,
            this.VerContraseñaCol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgUsuarios.EnableHeadersVisualStyles = false;
            this.dgUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgUsuarios.Location = new System.Drawing.Point(122, 178);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgUsuarios.RowHeadersVisible = false;
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.Size = new System.Drawing.Size(949, 233);
            this.dgUsuarios.TabIndex = 41;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // usuarioCol
            // 
            this.usuarioCol.HeaderText = "Usuario";
            this.usuarioCol.MinimumWidth = 6;
            this.usuarioCol.Name = "usuarioCol";
            this.usuarioCol.ReadOnly = true;
            // 
            // PuestoCol
            // 
            this.PuestoCol.HeaderText = "Puesto";
            this.PuestoCol.MinimumWidth = 6;
            this.PuestoCol.Name = "PuestoCol";
            this.PuestoCol.ReadOnly = true;
            // 
            // sucursalCol
            // 
            this.sucursalCol.HeaderText = "Sucursal";
            this.sucursalCol.MinimumWidth = 6;
            this.sucursalCol.Name = "sucursalCol";
            this.sucursalCol.ReadOnly = true;
            // 
            // EliminarCol
            // 
            this.EliminarCol.HeaderText = "Eliminar";
            this.EliminarCol.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.EliminarCol.MinimumWidth = 6;
            this.EliminarCol.Name = "EliminarCol";
            this.EliminarCol.ReadOnly = true;
            // 
            // VerContraseñaCol
            // 
            this.VerContraseñaCol.HeaderText = "Ver Contraseña";
            this.VerContraseñaCol.Image = global::CapaPresentacion.Properties.Resources.detalles;
            this.VerContraseñaCol.MinimumWidth = 6;
            this.VerContraseñaCol.Name = "VerContraseñaCol";
            this.VerContraseñaCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 37);
            this.panel1.TabIndex = 74;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(995, 126);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(48, 46);
            this.btnAgregarUsuario.TabIndex = 75;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnAgregarProfesionsitas
            // 
            this.btnAgregarProfesionsitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProfesionsitas.FlatAppearance.BorderSize = 0;
            this.btnAgregarProfesionsitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProfesionsitas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarProfesionsitas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProfesionsitas.Image")));
            this.btnAgregarProfesionsitas.Location = new System.Drawing.Point(995, 506);
            this.btnAgregarProfesionsitas.Name = "btnAgregarProfesionsitas";
            this.btnAgregarProfesionsitas.Size = new System.Drawing.Size(48, 46);
            this.btnAgregarProfesionsitas.TabIndex = 80;
            this.btnAgregarProfesionsitas.UseVisualStyleBackColor = true;
            this.btnAgregarProfesionsitas.Click += new System.EventHandler(this.btnAgregarProfesionsitas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(461, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 79;
            this.label1.Text = "Profesionistas";
            // 
            // dgProfesionistas
            // 
            this.dgProfesionistas.AllowUserToAddRows = false;
            this.dgProfesionistas.AllowUserToDeleteRows = false;
            this.dgProfesionistas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProfesionistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfesionistas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProfesionistas.BackgroundColor = System.Drawing.Color.White;
            this.dgProfesionistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProfesionistas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProfesionistas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProfesionistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgProfesionistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProfesionistas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgProfesionistas.EnableHeadersVisualStyles = false;
            this.dgProfesionistas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgProfesionistas.Location = new System.Drawing.Point(122, 551);
            this.dgProfesionistas.Name = "dgProfesionistas";
            this.dgProfesionistas.ReadOnly = true;
            this.dgProfesionistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProfesionistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgProfesionistas.RowHeadersVisible = false;
            this.dgProfesionistas.RowHeadersWidth = 51;
            this.dgProfesionistas.Size = new System.Drawing.Size(949, 233);
            this.dgProfesionistas.TabIndex = 76;
            this.dgProfesionistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesionistas_CellClick);
            this.dgProfesionistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesionistas_CellContentClick);
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
            this.btnAyuda.Location = new System.Drawing.Point(1049, 141);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 102;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAyudaProf
            // 
            this.btnAyudaProf.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAyudaProf.FlatAppearance.BorderSize = 0;
            this.btnAyudaProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudaProf.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyudaProf.IconColor = System.Drawing.Color.Black;
            this.btnAyudaProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyudaProf.IconSize = 24;
            this.btnAyudaProf.Location = new System.Drawing.Point(1049, 514);
            this.btnAyudaProf.Name = "btnAyudaProf";
            this.btnAyudaProf.Size = new System.Drawing.Size(31, 31);
            this.btnAyudaProf.TabIndex = 103;
            this.btnAyudaProf.UseVisualStyleBackColor = true;
            this.btnAyudaProf.Click += new System.EventHandler(this.btnAyudaProf_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 834);
            this.Controls.Add(this.btnAyudaProf);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnAgregarProfesionsitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProfesionistas);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesionistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnAgregarProfesionsitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProfesionistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalCol;
        private System.Windows.Forms.DataGridViewImageColumn EliminarCol;
        private System.Windows.Forms.DataGridViewImageColumn VerContraseñaCol;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnAyudaProf;
    }
}