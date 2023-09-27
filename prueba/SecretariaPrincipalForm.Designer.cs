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
            this.dgXochitl = new System.Windows.Forms.DataGridView();
            this.dtIgnacio = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalendarioCitas = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgXochitl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIgnacio)).BeginInit();
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
            this.dgXochitl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgXochitl.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgXochitl.Location = new System.Drawing.Point(109, 242);
            this.dgXochitl.Margin = new System.Windows.Forms.Padding(4);
            this.dgXochitl.MultiSelect = false;
            this.dgXochitl.Name = "dgXochitl";
            this.dgXochitl.ReadOnly = true;
            this.dgXochitl.RowHeadersWidth = 51;
            this.dgXochitl.Size = new System.Drawing.Size(1443, 320);
            this.dgXochitl.TabIndex = 10;
            this.dgXochitl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgXochitl_CellClick);
            // 
            // dtIgnacio
            // 
            this.dtIgnacio.AllowUserToAddRows = false;
            this.dtIgnacio.AllowUserToDeleteRows = false;
            this.dtIgnacio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIgnacio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtIgnacio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtIgnacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtIgnacio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtIgnacio.Location = new System.Drawing.Point(109, 742);
            this.dtIgnacio.Margin = new System.Windows.Forms.Padding(4);
            this.dtIgnacio.MultiSelect = false;
            this.dtIgnacio.Name = "dtIgnacio";
            this.dtIgnacio.ReadOnly = true;
            this.dtIgnacio.RowHeadersWidth = 51;
            this.dtIgnacio.Size = new System.Drawing.Size(1443, 320);
            this.dtIgnacio.TabIndex = 11;
            this.dtIgnacio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtIgnacio_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(552, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "Xochitl Tello González";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(573, 623);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ignacio Tello González";
            // 
            // CalendarioCitas
            // 
            this.CalendarioCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarioCitas.Location = new System.Drawing.Point(1221, 22);
            this.CalendarioCitas.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.CalendarioCitas.MaxSelectionCount = 1;
            this.CalendarioCitas.Name = "CalendarioCitas";
            this.CalendarioCitas.TabIndex = 1;
            this.CalendarioCitas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioCitas_DateChanged);
            // 
            // SecretariaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 1102);
            this.Controls.Add(this.CalendarioCitas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtIgnacio);
            this.Controls.Add(this.dgXochitl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SecretariaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretariaPrincipalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecretariaPrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgXochitl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIgnacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgXochitl;
        private System.Windows.Forms.DataGridView dtIgnacio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar CalendarioCitas;
    }
}