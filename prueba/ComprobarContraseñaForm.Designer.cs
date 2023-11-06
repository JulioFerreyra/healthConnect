namespace CapaPresentacion
{
    partial class ComprobarContraseñaForm
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
            this.txtContraseña = new prueba.TextBoxD();
            this.brnAceptar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtContraseña.BorderRadius = 0;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(80, 46);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.MaxLength = 10;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.Violet;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(250, 32);
            this.txtContraseña.TabIndex = 0;
            this.txtContraseña.Texts = "";
            this.txtContraseña.UnderlineStyle = false;
            // 
            // brnAceptar
            // 
            this.brnAceptar.Location = new System.Drawing.Point(168, 102);
            this.brnAceptar.Name = "brnAceptar";
            this.brnAceptar.Size = new System.Drawing.Size(75, 23);
            this.brnAceptar.TabIndex = 1;
            this.brnAceptar.Text = "Aceptar";
            this.brnAceptar.UseVisualStyleBackColor = true;
            this.brnAceptar.Click += new System.EventHandler(this.brnAceptar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(77, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(189, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Ingrese la contraseña de administrador";
            // 
            // ComprobarContraseñaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 137);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.brnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Name = "ComprobarContraseñaForm";
            this.Text = "ComprobarContraseñaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prueba.TextBoxD txtContraseña;
        private System.Windows.Forms.Button brnAceptar;
        private System.Windows.Forms.Label lblInfo;
    }
}