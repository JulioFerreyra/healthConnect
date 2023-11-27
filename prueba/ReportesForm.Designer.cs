﻿namespace CapaPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.cmbPodologos = new CustomControls.RJControls.pComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtFinal = new CustomControls.RJControls.pDatePicker();
            this.cmbTiposCita = new CustomControls.RJControls.pComboBox();
            this.cmbFiltro = new CustomControls.RJControls.pComboBox();
            this.dtInicio = new CustomControls.RJControls.pDatePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.White;
            this.pnlOpciones.Controls.Add(this.btnAyuda);
            this.pnlOpciones.Controls.Add(this.cmbPodologos);
            this.pnlOpciones.Controls.Add(this.btnBuscar);
            this.pnlOpciones.Controls.Add(this.dtFinal);
            this.pnlOpciones.Controls.Add(this.cmbTiposCita);
            this.pnlOpciones.Controls.Add(this.cmbFiltro);
            this.pnlOpciones.Controls.Add(this.dtInicio);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(1118, 81);
            this.pnlOpciones.TabIndex = 1;
            this.pnlOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpciones_Paint);
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
            this.btnAyuda.Location = new System.Drawing.Point(1084, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 102;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // cmbPodologos
            // 
            this.cmbPodologos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbPodologos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbPodologos.BorderSize = 1;
            this.cmbPodologos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPodologos.Enabled = false;
            this.cmbPodologos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPodologos.ForeColor = System.Drawing.Color.White;
            this.cmbPodologos.IconColor = System.Drawing.Color.MediumBlue;
            this.cmbPodologos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPodologos.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPodologos.Location = new System.Drawing.Point(249, 29);
            this.cmbPodologos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPodologos.MinimumSize = new System.Drawing.Size(150, 24);
            this.cmbPodologos.Name = "cmbPodologos";
            this.cmbPodologos.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPodologos.Size = new System.Drawing.Size(212, 38);
            this.cmbPodologos.TabIndex = 5;
            this.cmbPodologos.Texts = "Profesionistas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1025, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 38);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dtFinal.BorderSize = 3;
            this.dtFinal.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtFinal.Location = new System.Drawing.Point(734, 32);
            this.dtFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(251, 35);
            this.dtFinal.SkinColor = System.Drawing.Color.White;
            this.dtFinal.TabIndex = 3;
            this.dtFinal.TextColor = System.Drawing.Color.Black;
            // 
            // cmbTiposCita
            // 
            this.cmbTiposCita.BackColor = System.Drawing.Color.White;
            this.cmbTiposCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbTiposCita.BorderSize = 1;
            this.cmbTiposCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTiposCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposCita.ForeColor = System.Drawing.Color.Black;
            this.cmbTiposCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbTiposCita.Items.AddRange(new object[] {
            "Todas"});
            this.cmbTiposCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTiposCita.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTiposCita.Location = new System.Drawing.Point(489, 29);
            this.cmbTiposCita.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTiposCita.MinimumSize = new System.Drawing.Size(150, 24);
            this.cmbTiposCita.Name = "cmbTiposCita";
            this.cmbTiposCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTiposCita.Size = new System.Drawing.Size(212, 38);
            this.cmbTiposCita.TabIndex = 1;
            this.cmbTiposCita.Texts = "Tipo de Cita";
            this.cmbTiposCita.OnSelectedIndexChanged += new System.EventHandler(this.cmbTiposCita_OnSelectedIndexChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbFiltro.BorderSize = 1;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.White;
            this.cmbFiltro.IconColor = System.Drawing.Color.MediumBlue;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Rango de fechas",
            "Tipos de Cita"});
            this.cmbFiltro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbFiltro.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbFiltro.Location = new System.Drawing.Point(11, 29);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltro.MinimumSize = new System.Drawing.Size(150, 24);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Padding = new System.Windows.Forms.Padding(1);
            this.cmbFiltro.Size = new System.Drawing.Size(212, 38);
            this.cmbFiltro.TabIndex = 0;
            this.cmbFiltro.Texts = "Filtro";
            this.cmbFiltro.OnSelectedIndexChanged += new System.EventHandler(this.cmbFiltro_OnSelectedIndexChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dtInicio.BorderSize = 3;
            this.dtInicio.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtInicio.Location = new System.Drawing.Point(489, 32);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(212, 35);
            this.dtInicio.SkinColor = System.Drawing.Color.White;
            this.dtInicio.TabIndex = 2;
            this.dtInicio.TextColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rvReportes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 658);
            this.panel1.TabIndex = 2;
            // 
            // rvReportes
            // 
            this.rvReportes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvReportes.LocalReport.ReportEmbeddedResource = "CapaPresentacion.InformeReporte.rdlc";
            this.rvReportes.Location = new System.Drawing.Point(0, 0);
            this.rvReportes.Margin = new System.Windows.Forms.Padding(2);
            this.rvReportes.Name = "rvReportes";
            this.rvReportes.ServerReport.BearerToken = null;
            this.rvReportes.Size = new System.Drawing.Size(1118, 658);
            this.rvReportes.TabIndex = 1;
            this.rvReportes.Load += new System.EventHandler(this.rvReportes_Load);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOpciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
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
        private FontAwesome.Sharp.IconButton btnAyuda;
    }
}