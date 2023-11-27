namespace prueba
{
    partial class SecretariaPrincipalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgXochitl = new System.Windows.Forms.DataGridView();
            this.CalendarioCitas = new System.Windows.Forms.MonthCalendar();
            this.lblCitas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.cmbxPodologo = new CustomControls.RJControls.pComboBox();
            this.btnAyudaGrid = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgXochitl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgXochitl
            // 
            this.dgXochitl.AllowUserToAddRows = false;
            this.dgXochitl.AllowUserToDeleteRows = false;
            this.dgXochitl.AllowUserToResizeRows = false;
            this.dgXochitl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgXochitl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgXochitl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgXochitl.BackgroundColor = System.Drawing.Color.White;
            this.dgXochitl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgXochitl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgXochitl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgXochitl.ColumnHeadersHeight = 30;
            this.dgXochitl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgXochitl.EnableHeadersVisualStyles = false;
            this.dgXochitl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgXochitl.Location = new System.Drawing.Point(40, 262);
            this.dgXochitl.MultiSelect = false;
            this.dgXochitl.Name = "dgXochitl";
            this.dgXochitl.ReadOnly = true;
            this.dgXochitl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgXochitl.RowHeadersVisible = false;
            this.dgXochitl.RowHeadersWidth = 51;
            this.dgXochitl.Size = new System.Drawing.Size(1082, 535);
            this.dgXochitl.TabIndex = 10;
            this.dgXochitl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgXochitl_CellClick);
            this.dgXochitl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgXochitl_CellContentClick);
            this.dgXochitl.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgXochitl_RowsAdded);
            this.dgXochitl.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgXochitl_RowsRemoved);
            // 
            // CalendarioCitas
            // 
            this.CalendarioCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarioCitas.BackColor = System.Drawing.Color.White;
            this.CalendarioCitas.Location = new System.Drawing.Point(874, 40);
            this.CalendarioCitas.MaxSelectionCount = 1;
            this.CalendarioCitas.Name = "CalendarioCitas";
            this.CalendarioCitas.TabIndex = 1;
            this.CalendarioCitas.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CalendarioCitas.TrailingForeColor = System.Drawing.Color.RosyBrown;
            this.CalendarioCitas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioCitas_DateChanged);
            // 
            // lblCitas
            // 
            this.lblCitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(36, 219);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(51, 20);
            this.lblCitas.TabIndex = 12;
            this.lblCitas.Text = "label1";
            this.lblCitas.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Profesionista";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Citas Agendadas";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Citas programadas";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.Black;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 24;
            this.btnAyuda.Location = new System.Drawing.Point(1091, 4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 102;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // cmbxPodologo
            // 
            this.cmbxPodologo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxPodologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxPodologo.BorderSize = 1;
            this.cmbxPodologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxPodologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPodologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPodologo.ForeColor = System.Drawing.Color.White;
            this.cmbxPodologo.IconColor = System.Drawing.Color.Blue;
            this.cmbxPodologo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxPodologo.ListTextColor = System.Drawing.Color.Black;
            this.cmbxPodologo.Location = new System.Drawing.Point(40, 132);
            this.cmbxPodologo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxPodologo.Name = "cmbxPodologo";
            this.cmbxPodologo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxPodologo.Size = new System.Drawing.Size(218, 44);
            this.cmbxPodologo.TabIndex = 11;
            this.cmbxPodologo.Texts = "Podólogo";
            this.cmbxPodologo.OnSelectedIndexChanged += new System.EventHandler(this.cmbxPodologo_OnSelectedIndexChanged);
            // 
            // btnAyudaGrid
            // 
            this.btnAyudaGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyudaGrid.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAyudaGrid.FlatAppearance.BorderSize = 0;
            this.btnAyudaGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudaGrid.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyudaGrid.IconColor = System.Drawing.Color.Black;
            this.btnAyudaGrid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyudaGrid.IconSize = 24;
            this.btnAyudaGrid.Location = new System.Drawing.Point(1091, 225);
            this.btnAyudaGrid.Name = "btnAyudaGrid";
            this.btnAyudaGrid.Size = new System.Drawing.Size(31, 31);
            this.btnAyudaGrid.TabIndex = 103;
            this.btnAyudaGrid.UseVisualStyleBackColor = true;
            this.btnAyudaGrid.Click += new System.EventHandler(this.btnAyudaGrid_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SecretariaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 848);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAyudaGrid);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.cmbxPodologo);
            this.Controls.Add(this.CalendarioCitas);
            this.Controls.Add(this.dgXochitl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecretariaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretariaPrincipalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecretariaPrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgXochitl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgXochitl;
        private System.Windows.Forms.MonthCalendar CalendarioCitas;
        private CustomControls.RJControls.pComboBox cmbxPodologo;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnAyudaGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}