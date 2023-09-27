namespace CapaPresentacion
{
    partial class HistorialPodologoForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbCorreoLogin = new prueba.TextBoxD();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.BuscarUsuario;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(687, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txbCorreoLogin
            // 
            this.txbCorreoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.txbCorreoLogin.BorderColor = System.Drawing.Color.DimGray;
            this.txbCorreoLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txbCorreoLogin.BorderRadius = 10;
            this.txbCorreoLogin.BorderSize = 2;
            this.txbCorreoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorreoLogin.ForeColor = System.Drawing.Color.White;
            this.txbCorreoLogin.Location = new System.Drawing.Point(238, 116);
            this.txbCorreoLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbCorreoLogin.MaxLength = 10;
            this.txbCorreoLogin.Multiline = false;
            this.txbCorreoLogin.Name = "txbCorreoLogin";
            this.txbCorreoLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCorreoLogin.PasswordChar = false;
            this.txbCorreoLogin.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txbCorreoLogin.PlaceholderText = "Buscar";
            this.txbCorreoLogin.Size = new System.Drawing.Size(444, 46);
            this.txbCorreoLogin.TabIndex = 9;
            this.txbCorreoLogin.Texts = "";
            this.txbCorreoLogin.UnderlineStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(879, 397);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(389, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Historial";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 37);
            this.panel1.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.button2.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(933, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 40);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // HistorialPodologoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbCorreoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialPodologoForm";
            this.Text = "HistorialPodologoForm";
            this.Load += new System.EventHandler(this.HistorialPodologoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private prueba.TextBoxD txbCorreoLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}