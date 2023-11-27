namespace CapaPresentacion
{
    partial class ConfirmarCitasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarCitasForm));
            this.dgCitas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pctAyuda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCitas
            // 
            this.dgCitas.AllowUserToAddRows = false;
            this.dgCitas.AllowUserToDeleteRows = false;
            this.dgCitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitas.EnableHeadersVisualStyles = false;
            this.dgCitas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.dgCitas.Location = new System.Drawing.Point(14, 82);
            this.dgCitas.Name = "dgCitas";
            this.dgCitas.ReadOnly = true;
            this.dgCitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCitas.RowHeadersVisible = false;
            this.dgCitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgCitas.Size = new System.Drawing.Size(1101, 682);
            this.dgCitas.TabIndex = 0;
            this.dgCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCitas_CellClick);
            this.dgCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCitas_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Citas por confirmar";
            // 
            // pctAyuda
            // 
            this.pctAyuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.pctAyuda.FlatAppearance.BorderSize = 0;
            this.pctAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pctAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.pctAyuda.IconColor = System.Drawing.Color.Black;
            this.pctAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pctAyuda.IconSize = 24;
            this.pctAyuda.Location = new System.Drawing.Point(1084, 12);
            this.pctAyuda.Name = "pctAyuda";
            this.pctAyuda.Size = new System.Drawing.Size(31, 31);
            this.pctAyuda.TabIndex = 102;
            this.pctAyuda.UseVisualStyleBackColor = true;
            this.pctAyuda.Click += new System.EventHandler(this.pctAyuda_Click);
            // 
            // ConfirmarCitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 804);
            this.Controls.Add(this.pctAyuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmarCitasForm";
            this.Text = "ConfirmarCitasForm";
            this.Load += new System.EventHandler(this.ConfirmarCitasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttAyuda;
        private FontAwesome.Sharp.IconButton pctAyuda;
    }
}