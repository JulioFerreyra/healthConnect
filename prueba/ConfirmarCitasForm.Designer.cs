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
            this.dgCitas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCitas
            // 
            this.dgCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitas.Location = new System.Drawing.Point(89, 116);
            this.dgCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgCitas.Name = "dgCitas";
            this.dgCitas.RowHeadersWidth = 51;
            this.dgCitas.Size = new System.Drawing.Size(976, 405);
            this.dgCitas.TabIndex = 0;
            this.dgCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCitas_CellClick);
            this.dgCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCitas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Citas por confirmar";
            // 
            // ConfirmarCitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCitas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}