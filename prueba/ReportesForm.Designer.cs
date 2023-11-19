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
            this.components = new System.ComponentModel.Container();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtFinal = new CustomControls.RJControls.pDatePicker();
            this.dtInicio = new CustomControls.RJControls.pDatePicker();
            this.cmbTiposCita = new CustomControls.RJControls.pComboBox();
            this.cmbFiltro = new CustomControls.RJControls.pComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbPodologos = new CustomControls.RJControls.pComboBox();
            this.pnlOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlOpciones.Controls.Add(this.cmbPodologos);
            this.pnlOpciones.Controls.Add(this.btnBuscar);
            this.pnlOpciones.Controls.Add(this.dtFinal);
            this.pnlOpciones.Controls.Add(this.dtInicio);
            this.pnlOpciones.Controls.Add(this.cmbTiposCita);
            this.pnlOpciones.Controls.Add(this.cmbFiltro);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(1449, 100);
            this.pnlOpciones.TabIndex = 1;
            this.pnlOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpciones_Paint);
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
            this.rvReportes.LocalReport.ReportEmbeddedResource = "CapaPresentacion.InformeReporte.rdlc";
            this.rvReportes.Location = new System.Drawing.Point(0, 0);
            this.rvReportes.Name = "rvReportes";
            this.rvReportes.ServerReport.BearerToken = null;
            this.rvReportes.Size = new System.Drawing.Size(1449, 620);
            this.rvReportes.TabIndex = 1;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            // 
            // dtFinal
            // 
            this.dtFinal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtFinal.BorderSize = 0;
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtFinal.Location = new System.Drawing.Point(722, 31);
            this.dtFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(200, 35);
            this.dtFinal.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtFinal.TabIndex = 3;
            this.dtFinal.TextColor = System.Drawing.Color.White;
            // 
            // dtInicio
            // 
            this.dtInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtInicio.BorderSize = 0;
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtInicio.Location = new System.Drawing.Point(485, 31);
            this.dtInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 35);
            this.dtInicio.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtInicio.TabIndex = 2;
            this.dtInicio.TextColor = System.Drawing.Color.White;
            // 
            // cmbTiposCita
            // 
            this.cmbTiposCita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTiposCita.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTiposCita.BorderSize = 1;
            this.cmbTiposCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTiposCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTiposCita.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTiposCita.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTiposCita.Items.AddRange(new object[] {
            "Rango de fechas",
            "Tipos de Cita"});
            this.cmbTiposCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTiposCita.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTiposCita.Location = new System.Drawing.Point(485, 36);
            this.cmbTiposCita.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTiposCita.Name = "cmbTiposCita";
            this.cmbTiposCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTiposCita.Size = new System.Drawing.Size(200, 30);
            this.cmbTiposCita.TabIndex = 1;
            this.cmbTiposCita.Texts = "";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbFiltro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbFiltro.BorderSize = 1;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFiltro.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Rango de fechas",
            "Tipos de Cita"});
            this.cmbFiltro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFiltro.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFiltro.Location = new System.Drawing.Point(24, 36);
            this.cmbFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFiltro.Size = new System.Drawing.Size(200, 30);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.Texts = "";
            this.cmbFiltro.OnSelectedIndexChanged += new System.EventHandler(this.cmbFiltro_OnSelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.Location = new System.Drawing.Point(1388, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbPodologos
            // 
            this.cmbPodologos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPodologos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPodologos.BorderSize = 1;
            this.cmbPodologos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPodologos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPodologos.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPodologos.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPodologos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPodologos.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPodologos.Location = new System.Drawing.Point(253, 36);
            this.cmbPodologos.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPodologos.Name = "cmbPodologos";
            this.cmbPodologos.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPodologos.Size = new System.Drawing.Size(200, 30);
            this.cmbPodologos.TabIndex = 5;
            this.cmbPodologos.Texts = "Profesionistas";
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
            this.pnlOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvReportes;
        private System.Windows.Forms.BindingSource dataSetReportesBindingSource;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private CustomControls.RJControls.pComboBox cmbFiltro;
        private CustomControls.RJControls.pComboBox cmbTiposCita;
        private CustomControls.RJControls.pDatePicker dtFinal;
        private CustomControls.RJControls.pDatePicker dtInicio;
        private System.Windows.Forms.Button btnBuscar;
        private CustomControls.RJControls.pComboBox cmbPodologos;
    }
}