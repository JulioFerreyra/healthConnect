namespace CapaPresentacion
{
    partial class PodologoPrincipalForm
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
            this.calendarioCitas = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPodologo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarioCitas
            // 
            this.calendarioCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarioCitas.Location = new System.Drawing.Point(897, 18);
            this.calendarioCitas.MaxSelectionCount = 1;
            this.calendarioCitas.Name = "calendarioCitas";
            this.calendarioCitas.TabIndex = 1;
            this.calendarioCitas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarioCitas_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 675);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblPodologo
            // 
            this.lblPodologo.AutoSize = true;
            this.lblPodologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodologo.ForeColor = System.Drawing.Color.Snow;
            this.lblPodologo.Location = new System.Drawing.Point(62, 153);
            this.lblPodologo.Name = "lblPodologo";
            this.lblPodologo.Size = new System.Drawing.Size(290, 37);
            this.lblPodologo.TabIndex = 20;
            this.lblPodologo.Text = "Citas pendientes: ";
            // 
            // PodologoPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 961);
            this.Controls.Add(this.lblPodologo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.calendarioCitas);
            this.Name = "PodologoPrincipalForm";
            this.Text = "PodologoPrincipalForm";
            this.Load += new System.EventHandler(this.PodologoPrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioCitas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPodologo;
    }
}