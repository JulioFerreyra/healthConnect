﻿namespace prueba
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
            this.cmbxPodologo = new CustomControls.RJControls.pComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgXochitl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgXochitl
            // 
            this.dgXochitl.AllowUserToAddRows = false;
            this.dgXochitl.AllowUserToDeleteRows = false;
            this.dgXochitl.AllowUserToResizeRows = false;
            this.dgXochitl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgXochitl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgXochitl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgXochitl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgXochitl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgXochitl.Location = new System.Drawing.Point(29, 232);
            this.dgXochitl.MultiSelect = false;
            this.dgXochitl.Name = "dgXochitl";
            this.dgXochitl.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgXochitl.RowHeadersWidth = 51;
            this.dgXochitl.Size = new System.Drawing.Size(1082, 532);
            this.dgXochitl.TabIndex = 10;
            this.dgXochitl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgXochitl_CellClick);
            // 
            // CalendarioCitas
            // 
            this.CalendarioCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarioCitas.Location = new System.Drawing.Point(863, 18);
            this.CalendarioCitas.MaxSelectionCount = 1;
            this.CalendarioCitas.Name = "CalendarioCitas";
            this.CalendarioCitas.TabIndex = 1;
            this.CalendarioCitas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioCitas_DateChanged);
            // 
            // cmbxPodologo
            // 
            this.cmbxPodologo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.cmbxPodologo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.cmbxPodologo.BorderSize = 1;
            this.cmbxPodologo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxPodologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPodologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPodologo.ForeColor = System.Drawing.Color.White;
            this.cmbxPodologo.IconColor = System.Drawing.Color.Black;
            this.cmbxPodologo.Items.AddRange(new object[] {
            "Ambos",
            "Ignacio Tello González",
            "Xochitil Tello Gónzalez"});
            this.cmbxPodologo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxPodologo.ListTextColor = System.Drawing.Color.Black;
            this.cmbxPodologo.Location = new System.Drawing.Point(40, 160);
            this.cmbxPodologo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbxPodologo.Name = "cmbxPodologo";
            this.cmbxPodologo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxPodologo.Size = new System.Drawing.Size(218, 44);
            this.cmbxPodologo.TabIndex = 11;
            this.cmbxPodologo.Texts = "Podólogo";
            // 
            // SecretariaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 848);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgXochitl;
        private System.Windows.Forms.MonthCalendar CalendarioCitas;
        private CustomControls.RJControls.pComboBox cmbxPodologo;
    }
}