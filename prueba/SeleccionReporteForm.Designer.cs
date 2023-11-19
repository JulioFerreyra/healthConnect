namespace CapaPresentacion
{
    partial class SeleccionReporteForm
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
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.cmbxPodologo = new CustomControls.RJControls.pComboBox();
            this.cmbxTipoCita = new CustomControls.RJControls.pComboBox();
            this.dtFinal = new CustomControls.RJControls.pDatePicker();
            this.dtInicio = new CustomControls.RJControls.pDatePicker();
            this.cmbxSeleccion = new CustomControls.RJControls.pComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbxEstadoCita = new CustomControls.RJControls.pComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(429, 387);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(88, 387);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(200, 49);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Continuar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.cmbxPodologo.IconColor = System.Drawing.Color.Black;
            this.cmbxPodologo.Items.AddRange(new object[] {
            "Ambos",
            "Ignacio Tello González",
            "Xochitil Tello Gónzalez"});
            this.cmbxPodologo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxPodologo.ListTextColor = System.Drawing.Color.Black;
            this.cmbxPodologo.Location = new System.Drawing.Point(379, 190);
            this.cmbxPodologo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxPodologo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxPodologo.Name = "cmbxPodologo";
            this.cmbxPodologo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxPodologo.Size = new System.Drawing.Size(291, 54);
            this.cmbxPodologo.TabIndex = 4;
            this.cmbxPodologo.Texts = "Podólogo";
            this.cmbxPodologo.OnSelectedIndexChanged += new System.EventHandler(this.cmbxPodologo_OnSelectedIndexChanged);
            // 
            // cmbxTipoCita
            // 
            this.cmbxTipoCita.BackColor = System.Drawing.SystemColors.Window;
            this.cmbxTipoCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.cmbxTipoCita.BorderSize = 1;
            this.cmbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipoCita.ForeColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.cmbxTipoCita.Items.AddRange(new object[] {
            "Examen",
            "Limpieza",
            "Consulta General",
            "Otro"});
            this.cmbxTipoCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxTipoCita.ListTextColor = System.Drawing.Color.Black;
            this.cmbxTipoCita.Location = new System.Drawing.Point(36, 473);
            this.cmbxTipoCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxTipoCita.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxTipoCita.Name = "cmbxTipoCita";
            this.cmbxTipoCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxTipoCita.Size = new System.Drawing.Size(267, 43);
            this.cmbxTipoCita.TabIndex = 3;
            this.cmbxTipoCita.Texts = "Tipo Cita";
            // 
            // dtFinal
            // 
            this.dtFinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.dtFinal.BorderSize = 1;
            this.dtFinal.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtFinal.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtFinal.Location = new System.Drawing.Point(684, 466);
            this.dtFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(289, 35);
            this.dtFinal.SkinColor = System.Drawing.Color.White;
            this.dtFinal.TabIndex = 2;
            this.dtFinal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            // 
            // dtInicio
            // 
            this.dtInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.dtInicio.BorderSize = 1;
            this.dtInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtInicio.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtInicio.Location = new System.Drawing.Point(349, 466);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(289, 35);
            this.dtInicio.SkinColor = System.Drawing.Color.White;
            this.dtInicio.TabIndex = 1;
            this.dtInicio.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            // 
            // cmbxSeleccion
            // 
            this.cmbxSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxSeleccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxSeleccion.BorderSize = 1;
            this.cmbxSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSeleccion.ForeColor = System.Drawing.Color.White;
            this.cmbxSeleccion.IconColor = System.Drawing.Color.Black;
            this.cmbxSeleccion.Items.AddRange(new object[] {
            "Tipo Cita",
            "Rango de Fechas"});
            this.cmbxSeleccion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxSeleccion.ListTextColor = System.Drawing.Color.Black;
            this.cmbxSeleccion.Location = new System.Drawing.Point(36, 190);
            this.cmbxSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxSeleccion.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxSeleccion.Name = "cmbxSeleccion";
            this.cmbxSeleccion.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxSeleccion.Size = new System.Drawing.Size(291, 54);
            this.cmbxSeleccion.TabIndex = 0;
            this.cmbxSeleccion.Texts = "Selección";
            this.cmbxSeleccion.OnSelectedIndexChanged += new System.EventHandler(this.cmbxSeleccion_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Seleccionar reporte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 46);
            this.panel1.TabIndex = 55;
            // 
            // cmbxEstadoCita
            // 
            this.cmbxEstadoCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxEstadoCita.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.cmbxEstadoCita.BorderSize = 1;
            this.cmbxEstadoCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEstadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEstadoCita.ForeColor = System.Drawing.Color.White;
            this.cmbxEstadoCita.IconColor = System.Drawing.Color.Black;
            this.cmbxEstadoCita.Items.AddRange(new object[] {
            "Ambos",
            "Finalizada",
            "Pendiente"});
            this.cmbxEstadoCita.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbxEstadoCita.ListTextColor = System.Drawing.Color.Black;
            this.cmbxEstadoCita.Location = new System.Drawing.Point(33, 264);
            this.cmbxEstadoCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxEstadoCita.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbxEstadoCita.Name = "cmbxEstadoCita";
            this.cmbxEstadoCita.Padding = new System.Windows.Forms.Padding(1);
            this.cmbxEstadoCita.Size = new System.Drawing.Size(291, 54);
            this.cmbxEstadoCita.TabIndex = 56;
            this.cmbxEstadoCita.Texts = "Estado Cita";
            this.cmbxEstadoCita.OnSelectedIndexChanged += new System.EventHandler(this.cmbxEstadoCita_OnSelectedIndexChanged);
            // 
            // SeleccionReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(858, 576);
            this.Controls.Add(this.cmbxEstadoCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbxPodologo);
            this.Controls.Add(this.cmbxTipoCita);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.cmbxSeleccion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeleccionReporteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionReporteForm";
            this.Load += new System.EventHandler(this.SeleccionReporteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.pComboBox cmbxSeleccion;
        private CustomControls.RJControls.pDatePicker dtInicio;
        private CustomControls.RJControls.pDatePicker dtFinal;
        private CustomControls.RJControls.pComboBox cmbxTipoCita;
        private CustomControls.RJControls.pComboBox cmbxPodologo;
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.pComboBox cmbxEstadoCita;
    }
}