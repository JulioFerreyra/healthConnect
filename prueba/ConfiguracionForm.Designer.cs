namespace CapaPresentacion
{
    partial class ConfiguracionForm
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
            this.SelectorDeColor = new System.Windows.Forms.ColorDialog();
            this.tagControl = new System.Windows.Forms.TabControl();
            this.TabPersonalizar = new System.Windows.Forms.TabPage();
            this.spConfiguración = new System.Windows.Forms.SplitContainer();
            this.btnAplicar = new CustomControls.RJControls.RJButton();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblTiposCita = new System.Windows.Forms.Label();
            this.txtHoras = new prueba.TextBoxD();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.lblLogs = new System.Windows.Forms.Label();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.txtTiposCita = new prueba.TextBoxD();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tagControl.SuspendLayout();
            this.TabPersonalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConfiguración)).BeginInit();
            this.spConfiguración.Panel1.SuspendLayout();
            this.spConfiguración.SuspendLayout();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tagControl
            // 
            this.tagControl.Controls.Add(this.TabPersonalizar);
            this.tagControl.Controls.Add(this.tabLogs);
            this.tagControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagControl.Location = new System.Drawing.Point(0, 0);
            this.tagControl.Name = "tagControl";
            this.tagControl.SelectedIndex = 0;
            this.tagControl.Size = new System.Drawing.Size(1086, 846);
            this.tagControl.TabIndex = 0;
            this.tagControl.SelectedIndexChanged += new System.EventHandler(this.tagControl_SelectedIndexChanged);
            // 
            // TabPersonalizar
            // 
            this.TabPersonalizar.Controls.Add(this.spConfiguración);
            this.TabPersonalizar.Location = new System.Drawing.Point(4, 22);
            this.TabPersonalizar.Name = "TabPersonalizar";
            this.TabPersonalizar.Padding = new System.Windows.Forms.Padding(3);
            this.TabPersonalizar.Size = new System.Drawing.Size(1078, 820);
            this.TabPersonalizar.TabIndex = 0;
            this.TabPersonalizar.Text = "Personalización";
            this.TabPersonalizar.UseVisualStyleBackColor = true;
            // 
            // spConfiguración
            // 
            this.spConfiguración.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spConfiguración.Location = new System.Drawing.Point(3, 3);
            this.spConfiguración.Name = "spConfiguración";
            this.spConfiguración.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spConfiguración.Panel1
            // 
            this.spConfiguración.Panel1.AutoScroll = true;
            this.spConfiguración.Panel1.Controls.Add(this.richTextBox1);
            this.spConfiguración.Panel1.Controls.Add(this.btnAplicar);
            this.spConfiguración.Panel1.Controls.Add(this.btnEditar);
            this.spConfiguración.Panel1.Controls.Add(this.lblHoras);
            this.spConfiguración.Panel1.Controls.Add(this.lblTiposCita);
            this.spConfiguración.Panel1.Controls.Add(this.txtHoras);
            this.spConfiguración.Panel1.Controls.Add(this.txtTiposCita);
            this.spConfiguración.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.spConfiguración.Panel2Collapsed = true;
            this.spConfiguración.Size = new System.Drawing.Size(1072, 814);
            this.spConfiguración.SplitterDistance = 520;
            this.spConfiguración.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAplicar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAplicar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAplicar.BorderRadius = 0;
            this.btnAplicar.BorderSize = 0;
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(346, 510);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(150, 37);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Guardar";
            this.btnAplicar.TextColor = System.Drawing.Color.White;
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(514, 510);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 37);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(24, 286);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(113, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horario (Uno por linea)";
            // 
            // lblTiposCita
            // 
            this.lblTiposCita.AutoSize = true;
            this.lblTiposCita.Location = new System.Drawing.Point(24, 34);
            this.lblTiposCita.Name = "lblTiposCita";
            this.lblTiposCita.Size = new System.Drawing.Size(180, 13);
            this.lblTiposCita.TabIndex = 2;
            this.lblTiposCita.Text = "Agregar Tipos de cita (Uno por linea)";
            // 
            // txtHoras
            // 
            this.txtHoras.AutoScroll = true;
            this.txtHoras.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoras.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtHoras.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtHoras.BorderRadius = 0;
            this.txtHoras.BorderSize = 2;
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.ForeColor = System.Drawing.Color.Black;
            this.txtHoras.Location = new System.Drawing.Point(27, 303);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoras.MaxLength = 10;
            this.txtHoras.Multiline = true;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHoras.PasswordChar = false;
            this.txtHoras.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtHoras.PlaceholderText = "";
            this.txtHoras.Size = new System.Drawing.Size(637, 184);
            this.txtHoras.TabIndex = 1;
            this.txtHoras.Texts = "";
            this.txtHoras.UnderlineStyle = false;
            this.txtHoras._TextChanged += new System.EventHandler(this.textBoxD1__TextChanged);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.lblLogs);
            this.tabLogs.Controls.Add(this.dgLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1078, 820);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(76, 131);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(30, 13);
            this.lblLogs.TabIndex = 8;
            this.lblLogs.Text = "Logs";
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.Location = new System.Drawing.Point(79, 147);
            this.dgLogs.MultiSelect = false;
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            this.dgLogs.Size = new System.Drawing.Size(917, 359);
            this.dgLogs.TabIndex = 7;
            // 
            // txtTiposCita
            // 
            this.txtTiposCita.AutoScroll = true;
            this.txtTiposCita.BackColor = System.Drawing.SystemColors.Window;
            this.txtTiposCita.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTiposCita.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtTiposCita.BorderRadius = 0;
            this.txtTiposCita.BorderSize = 2;
            this.txtTiposCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiposCita.ForeColor = System.Drawing.Color.Black;
            this.txtTiposCita.Location = new System.Drawing.Point(27, 51);
            this.txtTiposCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiposCita.MaxLength = 10;
            this.txtTiposCita.Multiline = true;
            this.txtTiposCita.Name = "txtTiposCita";
            this.txtTiposCita.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTiposCita.PasswordChar = false;
            this.txtTiposCita.PlaceholderColor = System.Drawing.Color.Black;
            this.txtTiposCita.PlaceholderText = "Ejemplo: ";
            this.txtTiposCita.Size = new System.Drawing.Size(637, 205);
            this.txtTiposCita.TabIndex = 0;
            this.txtTiposCita.Texts = "";
            this.txtTiposCita.UnderlineStyle = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(723, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(217, 205);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1086, 846);
            this.Controls.Add(this.tagControl);
            this.Name = "ConfiguracionForm";
            this.Text = "ConfiguracionForm";
            this.Load += new System.EventHandler(this.ConfiguracionForm_Load);
            this.tagControl.ResumeLayout(false);
            this.TabPersonalizar.ResumeLayout(false);
            this.spConfiguración.Panel1.ResumeLayout(false);
            this.spConfiguración.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConfiguración)).EndInit();
            this.spConfiguración.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog SelectorDeColor;
        private System.Windows.Forms.TabControl tagControl;
        private System.Windows.Forms.TabPage TabPersonalizar;
        private System.Windows.Forms.SplitContainer spConfiguración;
        private System.Windows.Forms.TabPage tabLogs;
        private prueba.TextBoxD txtHoras;
        private System.Windows.Forms.Label lblTiposCita;
        private System.Windows.Forms.Label lblHoras;
        private CustomControls.RJControls.RJButton btnAplicar;
        private CustomControls.RJControls.RJButton btnEditar;
        private System.Windows.Forms.DataGridView dgLogs;
        private System.Windows.Forms.Label lblLogs;
        private prueba.TextBoxD txtTiposCita;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}