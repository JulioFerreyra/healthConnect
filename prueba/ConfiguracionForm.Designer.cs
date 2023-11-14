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
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.spConfiguración = new System.Windows.Forms.SplitContainer();
            this.txtTiposCita = new prueba.TextBoxD();
            this.textBoxD1 = new prueba.TextBoxD();
            this.lblTiposCita = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.tagControl.SuspendLayout();
            this.TabPersonalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConfiguración)).BeginInit();
            this.spConfiguración.Panel1.SuspendLayout();
            this.spConfiguración.SuspendLayout();
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
            // tabLogs
            // 
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1078, 820);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
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
            this.spConfiguración.Panel1.Controls.Add(this.dgLogs);
            this.spConfiguración.Panel1.Controls.Add(this.rjButton2);
            this.spConfiguración.Panel1.Controls.Add(this.btnEditar);
            this.spConfiguración.Panel1.Controls.Add(this.lblHoras);
            this.spConfiguración.Panel1.Controls.Add(this.lblTiposCita);
            this.spConfiguración.Panel1.Controls.Add(this.textBoxD1);
            this.spConfiguración.Panel1.Controls.Add(this.txtTiposCita);
            this.spConfiguración.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.spConfiguración.Panel2Collapsed = true;
            this.spConfiguración.Size = new System.Drawing.Size(1072, 814);
            this.spConfiguración.SplitterDistance = 520;
            this.spConfiguración.TabIndex = 0;
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
            this.txtTiposCita.Size = new System.Drawing.Size(637, 343);
            this.txtTiposCita.TabIndex = 0;
            this.txtTiposCita.Texts = "Hola mundo";
            this.txtTiposCita.UnderlineStyle = false;
            // 
            // textBoxD1
            // 
            this.textBoxD1.AutoScroll = true;
            this.textBoxD1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxD1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.textBoxD1.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.textBoxD1.BorderRadius = 0;
            this.textBoxD1.BorderSize = 2;
            this.textBoxD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxD1.ForeColor = System.Drawing.Color.Black;
            this.textBoxD1.Location = new System.Drawing.Point(27, 431);
            this.textBoxD1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxD1.MaxLength = 10;
            this.textBoxD1.Multiline = true;
            this.textBoxD1.Name = "textBoxD1";
            this.textBoxD1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxD1.PasswordChar = false;
            this.textBoxD1.PlaceholderColor = System.Drawing.Color.Violet;
            this.textBoxD1.PlaceholderText = "";
            this.textBoxD1.Size = new System.Drawing.Size(637, 184);
            this.textBoxD1.TabIndex = 1;
            this.textBoxD1.Texts = "";
            this.textBoxD1.UnderlineStyle = false;
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
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(24, 414);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(113, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horario (Uno por linea)";
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
            this.btnEditar.Location = new System.Drawing.Point(514, 638);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 37);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(346, 638);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 37);
            this.rjButton2.TabIndex = 5;
            this.rjButton2.Text = "rjButton2";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.Location = new System.Drawing.Point(27, 710);
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            this.dgLogs.Size = new System.Drawing.Size(917, 359);
            this.dgLogs.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog SelectorDeColor;
        private System.Windows.Forms.TabControl tagControl;
        private System.Windows.Forms.TabPage TabPersonalizar;
        private System.Windows.Forms.SplitContainer spConfiguración;
        private System.Windows.Forms.TabPage tabLogs;
        private prueba.TextBoxD textBoxD1;
        private prueba.TextBoxD txtTiposCita;
        private System.Windows.Forms.Label lblTiposCita;
        private System.Windows.Forms.Label lblHoras;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton btnEditar;
        private System.Windows.Forms.DataGridView dgLogs;
    }
}