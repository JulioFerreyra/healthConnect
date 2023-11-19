namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.VerContraseñaCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarProfesionsitas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgProfesionistas = new System.Windows.Forms.DataGridView();
            this.textBoxD1 = new prueba.TextBoxD();
            this.txtBuscar = new prueba.TextBoxD();
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
            this.label7.Location = new System.Drawing.Point(696, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 46);
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
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.usuarioCol,
            this.PuestoCol,
            this.EliminarCol,
            this.VerContraseñaCol});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsuarios.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgUsuarios.Location = new System.Drawing.Point(163, 219);
            this.dgUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.Size = new System.Drawing.Size(1265, 287);
            this.dgUsuarios.TabIndex = 41;
            this.dgUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgUsuarios_CellMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1579, 46);
            this.panel1.TabIndex = 74;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarUsuario.Image = global::CapaPresentacion.Properties.Resources.add_user;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(1364, 153);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(64, 57);
            this.btnAgregarUsuario.TabIndex = 75;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1079, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 55);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProfesionsitas
            // 
            this.btnAgregarProfesionsitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProfesionsitas.FlatAppearance.BorderSize = 0;
            this.btnAgregarProfesionsitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProfesionsitas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarProfesionsitas.Image = global::CapaPresentacion.Properties.Resources.add_user;
            this.btnAgregarProfesionsitas.Location = new System.Drawing.Point(1364, 612);
            this.btnAgregarProfesionsitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarProfesionsitas.Name = "btnAgregarProfesionsitas";
            this.btnAgregarProfesionsitas.Size = new System.Drawing.Size(64, 57);
            this.btnAgregarProfesionsitas.TabIndex = 80;
            this.btnAgregarProfesionsitas.UseVisualStyleBackColor = true;
            this.btnAgregarProfesionsitas.Click += new System.EventHandler(this.btnAgregarProfesionsitas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(645, 562);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 79;
            this.label1.Text = "Profesionistas";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1079, 613);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 55);
            this.button3.TabIndex = 78;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgProfesionistas
            // 
            this.dgProfesionistas.AllowUserToAddRows = false;
            this.dgProfesionistas.AllowUserToDeleteRows = false;
            this.dgProfesionistas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProfesionistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfesionistas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProfesionistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProfesionistas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgProfesionistas.Location = new System.Drawing.Point(163, 678);
            this.dgProfesionistas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgProfesionistas.Name = "dgProfesionistas";
            this.dgProfesionistas.ReadOnly = true;
            this.dgProfesionistas.RowHeadersWidth = 51;
            this.dgProfesionistas.Size = new System.Drawing.Size(1265, 287);
            this.dgProfesionistas.TabIndex = 76;
            this.dgProfesionistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesionistas_CellClick);
            this.dgProfesionistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesionistas_CellContentClick);
            // 
            // textBoxD1
            // 
            this.textBoxD1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBoxD1.BorderColor = System.Drawing.Color.Silver;
            this.textBoxD1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxD1.BorderRadius = 10;
            this.textBoxD1.BorderSize = 2;
            this.textBoxD1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxD1.ForeColor = System.Drawing.Color.White;
            this.textBoxD1.Location = new System.Drawing.Point(477, 613);
            this.textBoxD1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxD1.MaxLength = 10;
            this.textBoxD1.Multiline = false;
            this.textBoxD1.Name = "textBoxD1";
            this.textBoxD1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.textBoxD1.PasswordChar = false;
            this.textBoxD1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.textBoxD1.PlaceholderText = "Buscar";
            this.textBoxD1.Size = new System.Drawing.Size(592, 58);
            this.textBoxD1.TabIndex = 77;
            this.textBoxD1.Texts = "";
            this.textBoxD1.UnderlineStyle = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.BorderSize = 2;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(475, 154);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBuscar.MaxLength = 10;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBuscar.PasswordChar = false;
            this.txtBuscar.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBuscar.PlaceholderText = "Buscar";
            this.txtBuscar.Size = new System.Drawing.Size(592, 58);
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.Texts = "";
            this.txtBuscar.UnderlineStyle = false;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1579, 1026);
            this.Controls.Add(this.btnAgregarProfesionsitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxD1);
            this.Controls.Add(this.dgProfesionistas);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
        private prueba.TextBoxD txtBuscar;
        private System.Windows.Forms.Button btnAgregarProfesionsitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private prueba.TextBoxD textBoxD1;
        private System.Windows.Forms.DataGridView dgProfesionistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoCol;
        private System.Windows.Forms.DataGridViewImageColumn EliminarCol;
        private System.Windows.Forms.DataGridViewImageColumn VerContraseñaCol;
    }
}