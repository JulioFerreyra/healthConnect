namespace CapaPresentacion
{
    partial class ReportesForm
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
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(1449, 100);
            this.pnlOpciones.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rvReportes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 620);
            this.panel1.TabIndex = 2;
            // 
            // rvReportes
            // 
            this.rvReportes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvReportes.Location = new System.Drawing.Point(0, 0);
            this.rvReportes.Name = "rvReportes";
            this.rvReportes.ServerReport.BearerToken = null;
            this.rvReportes.Size = new System.Drawing.Size(1449, 620);
            this.rvReportes.TabIndex = 1;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOpciones);
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvReportes;
    }
}