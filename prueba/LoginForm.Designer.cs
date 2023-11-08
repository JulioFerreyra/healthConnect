namespace prueba
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.txbPasswordLogin = new prueba.TextBoxD();
            this.txtCorreoLogin = new prueba.TextBoxD();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 37);
            this.panel1.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(358, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(138, 484);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 16);
            this.linkLabel1.TabIndex = 59;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvide mi contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton1.BorderRadius = 16;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(128, 425);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(143, 45);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Iniciar sesión";
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txbPasswordLogin
            // 
            this.txbPasswordLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbPasswordLogin.BorderColor = System.Drawing.Color.Transparent;
            this.txbPasswordLogin.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txbPasswordLogin.BorderRadius = 10;
            this.txbPasswordLogin.BorderSize = 2;
            this.txbPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPasswordLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txbPasswordLogin.Location = new System.Drawing.Point(44, 361);
            this.txbPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbPasswordLogin.MaxLength = 10;
            this.txbPasswordLogin.Multiline = false;
            this.txbPasswordLogin.Name = "txbPasswordLogin";
            this.txbPasswordLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPasswordLogin.PasswordChar = true;
            this.txbPasswordLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPasswordLogin.PlaceholderText = "Contraseña";
            this.txbPasswordLogin.Size = new System.Drawing.Size(302, 47);
            this.txbPasswordLogin.TabIndex = 4;
            this.txbPasswordLogin.Texts = "";
            this.txbPasswordLogin.UnderlineStyle = false;
            this.txbPasswordLogin._TextChanged += new System.EventHandler(this.txbPasswordLogin__TextChanged);
            // 
            // txtCorreoLogin
            // 
            this.txtCorreoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCorreoLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCorreoLogin.BorderFocusColor = System.Drawing.Color.Silver;
            this.txtCorreoLogin.BorderRadius = 10;
            this.txtCorreoLogin.BorderSize = 2;
            this.txtCorreoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreoLogin.Location = new System.Drawing.Point(44, 269);
            this.txtCorreoLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoLogin.MaxLength = 10;
            this.txtCorreoLogin.Multiline = false;
            this.txtCorreoLogin.Name = "txtCorreoLogin";
            this.txtCorreoLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreoLogin.PasswordChar = false;
            this.txtCorreoLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreoLogin.PlaceholderText = "Usuario";
            this.txtCorreoLogin.Size = new System.Drawing.Size(302, 47);
            this.txtCorreoLogin.TabIndex = 3;
            this.txtCorreoLogin.Texts = "";
            this.txtCorreoLogin.UnderlineStyle = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pctLogo.ErrorImage = null;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(34, 43);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(331, 185);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 58;
            this.pctLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 520);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPasswordLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreoLogin);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(20)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8";
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox textBox1;
        private TextBoxD txtCorreoLogin;
        private TextBoxD txbPasswordLogin;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}

