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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionForm));
            this.SelectorDeColor = new System.Windows.Forms.ColorDialog();
            this.tagControl = new System.Windows.Forms.TabControl();
            this.TabPersonalizar = new System.Windows.Forms.TabPage();
            this.spConfiguración = new System.Windows.Forms.SplitContainer();
            this.pctHorario = new System.Windows.Forms.PictureBox();
            this.pctTiposCita = new System.Windows.Forms.PictureBox();
            this.dgHorario = new System.Windows.Forms.DataGridView();
            this.dgTiposCita = new System.Windows.Forms.DataGridView();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblTiposCita = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.lblLogs = new System.Windows.Forms.Label();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAplicar = new CustomControls.RJControls.RJButton();
            this.btnEditar = new CustomControls.RJControls.RJButton();
            this.tagControl.SuspendLayout();
            this.TabPersonalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConfiguración)).BeginInit();
            this.spConfiguración.Panel1.SuspendLayout();
            this.spConfiguración.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTiposCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposCita)).BeginInit();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // tagControl
            // 
            this.tagControl.Controls.Add(this.TabPersonalizar);
            this.tagControl.Controls.Add(this.tabLogs);
            this.tagControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tagControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TabPersonalizar.Location = new System.Drawing.Point(4, 26);
            this.TabPersonalizar.Name = "TabPersonalizar";
            this.TabPersonalizar.Padding = new System.Windows.Forms.Padding(3);
            this.TabPersonalizar.Size = new System.Drawing.Size(1078, 816);
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
            this.spConfiguración.Panel1.Controls.Add(this.pctHorario);
            this.spConfiguración.Panel1.Controls.Add(this.pctTiposCita);
            this.spConfiguración.Panel1.Controls.Add(this.dgHorario);
            this.spConfiguración.Panel1.Controls.Add(this.dgTiposCita);
            this.spConfiguración.Panel1.Controls.Add(this.btnAplicar);
            this.spConfiguración.Panel1.Controls.Add(this.btnEditar);
            this.spConfiguración.Panel1.Controls.Add(this.lblHoras);
            this.spConfiguración.Panel1.Controls.Add(this.lblTiposCita);
            this.spConfiguración.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.spConfiguración.Panel2Collapsed = true;
            this.spConfiguración.Size = new System.Drawing.Size(1072, 810);
            this.spConfiguración.SplitterDistance = 520;
            this.spConfiguración.TabIndex = 0;
            // 
            // pctHorario
            // 
            this.pctHorario.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.pctHorario.Location = new System.Drawing.Point(195, 321);
            this.pctHorario.Name = "pctHorario";
            this.pctHorario.Size = new System.Drawing.Size(33, 32);
            this.pctHorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHorario.TabIndex = 8;
            this.pctHorario.TabStop = false;
            // 
            // pctTiposCita
            // 
            this.pctTiposCita.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.pctTiposCita.Location = new System.Drawing.Point(195, 59);
            this.pctTiposCita.Name = "pctTiposCita";
            this.pctTiposCita.Size = new System.Drawing.Size(33, 27);
            this.pctTiposCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTiposCita.TabIndex = 8;
            this.pctTiposCita.TabStop = false;
            // 
            // dgHorario
            // 
            this.dgHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHorario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgHorario.BackgroundColor = System.Drawing.Color.White;
            this.dgHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHorario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgHorario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHorario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgHorario.EnableHeadersVisualStyles = false;
            this.dgHorario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgHorario.Location = new System.Drawing.Point(28, 321);
            this.dgHorario.Margin = new System.Windows.Forms.Padding(2);
            this.dgHorario.Name = "dgHorario";
            this.dgHorario.RowHeadersVisible = false;
            this.dgHorario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgHorario.Size = new System.Drawing.Size(149, 180);
            this.dgHorario.TabIndex = 7;
            // 
            // dgTiposCita
            // 
            this.dgTiposCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTiposCita.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTiposCita.BackgroundColor = System.Drawing.Color.White;
            this.dgTiposCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTiposCita.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTiposCita.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTiposCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTiposCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTiposCita.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgTiposCita.EnableHeadersVisualStyles = false;
            this.dgTiposCita.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgTiposCita.Location = new System.Drawing.Point(28, 59);
            this.dgTiposCita.Margin = new System.Windows.Forms.Padding(2);
            this.dgTiposCita.Name = "dgTiposCita";
            this.dgTiposCita.RowHeadersVisible = false;
            this.dgTiposCita.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgTiposCita.RowTemplate.Height = 24;
            this.dgTiposCita.Size = new System.Drawing.Size(149, 196);
            this.dgTiposCita.TabIndex = 6;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(24, 296);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(192, 20);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horario (Uno por linea)";
            // 
            // lblTiposCita
            // 
            this.lblTiposCita.AutoSize = true;
            this.lblTiposCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiposCita.Location = new System.Drawing.Point(22, 24);
            this.lblTiposCita.Name = "lblTiposCita";
            this.lblTiposCita.Size = new System.Drawing.Size(304, 20);
            this.lblTiposCita.TabIndex = 2;
            this.lblTiposCita.Text = "Agregar Tipos de cita (Uno por linea)";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.lblLogs);
            this.tabLogs.Controls.Add(this.dgLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 26);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1078, 816);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogs.Location = new System.Drawing.Point(74, 72);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(91, 37);
            this.lblLogs.TabIndex = 8;
            this.lblLogs.Text = "Logs";
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.EnableHeadersVisualStyles = false;
            this.dgLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgLogs.Location = new System.Drawing.Point(79, 147);
            this.dgLogs.MultiSelect = false;
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            this.dgLogs.RowHeadersVisible = false;
            this.dgLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgLogs.Size = new System.Drawing.Size(917, 359);
            this.dgLogs.TabIndex = 7;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAplicar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAplicar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnAplicar.BorderRadius = 15;
            this.btnAplicar.BorderSize = 5;
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(195, 464);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(150, 37);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar Cambios";
            this.btnAplicar.TextColor = System.Drawing.Color.White;
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnEditar.BorderRadius = 15;
            this.btnEditar.BorderSize = 5;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(195, 218);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 37);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Aplicar Cambios";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1086, 846);
            this.Controls.Add(this.tagControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfiguracionForm";
            this.Text = "ConfiguracionForm";
            this.Load += new System.EventHandler(this.ConfiguracionForm_Load);
            this.tagControl.ResumeLayout(false);
            this.TabPersonalizar.ResumeLayout(false);
            this.spConfiguración.Panel1.ResumeLayout(false);
            this.spConfiguración.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConfiguración)).EndInit();
            this.spConfiguración.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTiposCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposCita)).EndInit();
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
        private System.Windows.Forms.Label lblTiposCita;
        private System.Windows.Forms.Label lblHoras;
        private CustomControls.RJControls.RJButton btnAplicar;
        private CustomControls.RJControls.RJButton btnEditar;
        private System.Windows.Forms.DataGridView dgLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.DataGridView dgHorario;
        private System.Windows.Forms.DataGridView dgTiposCita;
        private System.Windows.Forms.PictureBox pctHorario;
        private System.Windows.Forms.PictureBox pctTiposCita;
        private System.Windows.Forms.ToolTip ttAyuda;
    }
}