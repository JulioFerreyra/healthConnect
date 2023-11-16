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
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.lblLogs = new System.Windows.Forms.Label();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.dgTiposCita = new System.Windows.Forms.DataGridView();
            this.dgHorario = new System.Windows.Forms.DataGridView();
            this.tagControl.SuspendLayout();
            this.TabPersonalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConfiguración)).BeginInit();
            this.spConfiguración.Panel1.SuspendLayout();
            this.spConfiguración.SuspendLayout();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // tagControl
            // 
            this.tagControl.Controls.Add(this.TabPersonalizar);
            this.tagControl.Controls.Add(this.tabLogs);
            this.tagControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagControl.Location = new System.Drawing.Point(0, 0);
            this.tagControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagControl.Name = "tagControl";
            this.tagControl.SelectedIndex = 0;
            this.tagControl.Size = new System.Drawing.Size(1448, 1041);
            this.tagControl.TabIndex = 0;
            this.tagControl.SelectedIndexChanged += new System.EventHandler(this.tagControl_SelectedIndexChanged);
            // 
            // TabPersonalizar
            // 
            this.TabPersonalizar.Controls.Add(this.spConfiguración);
            this.TabPersonalizar.Location = new System.Drawing.Point(4, 25);
            this.TabPersonalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPersonalizar.Name = "TabPersonalizar";
            this.TabPersonalizar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPersonalizar.Size = new System.Drawing.Size(1440, 1012);
            this.TabPersonalizar.TabIndex = 0;
            this.TabPersonalizar.Text = "Personalización";
            this.TabPersonalizar.UseVisualStyleBackColor = true;
            // 
            // spConfiguración
            // 
            this.spConfiguración.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spConfiguración.Location = new System.Drawing.Point(4, 4);
            this.spConfiguración.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spConfiguración.Name = "spConfiguración";
            this.spConfiguración.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spConfiguración.Panel1
            // 
            this.spConfiguración.Panel1.AutoScroll = true;
            this.spConfiguración.Panel1.Controls.Add(this.dgHorario);
            this.spConfiguración.Panel1.Controls.Add(this.dgTiposCita);
            this.spConfiguración.Panel1.Controls.Add(this.btnAplicar);
            this.spConfiguración.Panel1.Controls.Add(this.btnEditar);
            this.spConfiguración.Panel1.Controls.Add(this.lblHoras);
            this.spConfiguración.Panel1.Controls.Add(this.lblTiposCita);
            this.spConfiguración.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.spConfiguración.Panel2Collapsed = true;
            this.spConfiguración.Size = new System.Drawing.Size(1432, 1004);
            this.spConfiguración.SplitterDistance = 520;
            this.spConfiguración.SplitterWidth = 5;
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
            this.btnAplicar.Location = new System.Drawing.Point(461, 628);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(200, 46);
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
            this.btnEditar.Location = new System.Drawing.Point(685, 628);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 46);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(32, 352);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(143, 16);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horario (Uno por linea)";
            // 
            // lblTiposCita
            // 
            this.lblTiposCita.AutoSize = true;
            this.lblTiposCita.Location = new System.Drawing.Point(32, 42);
            this.lblTiposCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiposCita.Name = "lblTiposCita";
            this.lblTiposCita.Size = new System.Drawing.Size(228, 16);
            this.lblTiposCita.TabIndex = 2;
            this.lblTiposCita.Text = "Agregar Tipos de cita (Uno por linea)";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.lblLogs);
            this.tabLogs.Controls.Add(this.dgLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 25);
            this.tabLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLogs.Size = new System.Drawing.Size(1440, 1012);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(101, 161);
            this.lblLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(37, 16);
            this.lblLogs.TabIndex = 8;
            this.lblLogs.Text = "Logs";
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.Location = new System.Drawing.Point(105, 181);
            this.dgLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgLogs.MultiSelect = false;
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            this.dgLogs.RowHeadersWidth = 51;
            this.dgLogs.Size = new System.Drawing.Size(1223, 442);
            this.dgLogs.TabIndex = 7;
            // 
            // dgTiposCita
            // 
            this.dgTiposCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTiposCita.Location = new System.Drawing.Point(35, 61);
            this.dgTiposCita.Name = "dgTiposCita";
            this.dgTiposCita.RowHeadersWidth = 51;
            this.dgTiposCita.RowTemplate.Height = 24;
            this.dgTiposCita.Size = new System.Drawing.Size(240, 150);
            this.dgTiposCita.TabIndex = 6;
            // 
            // dgHorario
            // 
            this.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorario.Location = new System.Drawing.Point(35, 371);
            this.dgHorario.Name = "dgHorario";
            this.dgHorario.RowHeadersWidth = 51;
            this.dgHorario.Size = new System.Drawing.Size(240, 150);
            this.dgHorario.TabIndex = 7;
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1448, 1041);
            this.Controls.Add(this.tagControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog SelectorDeColor;
        private System.Windows.Forms.TabControl tagControl;
        private System.Windows.Forms.TabPage TabPersonalizar;
        private System.Windows.Forms.SplitContainer spConfiguración;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label lblTiposCita;
        private System.Windows.Forms.Label lblHoras;
        private CustomControls.RJControls.RJButton btnAplicar;
        private CustomControls.RJControls.RJButton btnEditar;
        private System.Windows.Forms.DataGridView dgLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.DataGridView dgHorario;
        private System.Windows.Forms.DataGridView dgTiposCita;
    }
}