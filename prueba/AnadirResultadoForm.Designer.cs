﻿namespace CapaPresentacion
{
    partial class AnadirResultadoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDetalles = new prueba.TextBoxD();
            this.txtRes = new prueba.TextBoxD();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.txtTel = new prueba.TextBoxD();
            this.txtApellMat = new prueba.TextBoxD();
            this.txtApellPat = new prueba.TextBoxD();
            this.txtNombre = new prueba.TextBoxD();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(247, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Diagnóstico";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 37);
            this.panel1.TabIndex = 55;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.button1.Location = new System.Drawing.Point(690, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 40);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDetalles
            // 
            this.txtDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDetalles.BorderColor = System.Drawing.Color.Silver;
            this.txtDetalles.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDetalles.BorderRadius = 0;
            this.txtDetalles.BorderSize = 2;
            this.txtDetalles.Enabled = false;
            this.txtDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalles.ForeColor = System.Drawing.Color.Black;
            this.txtDetalles.Location = new System.Drawing.Point(307, 117);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalles.MaxLength = 100;
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDetalles.PasswordChar = false;
            this.txtDetalles.PlaceholderColor = System.Drawing.Color.Black;
            this.txtDetalles.PlaceholderText = "Detalles";
            this.txtDetalles.Size = new System.Drawing.Size(396, 117);
            this.txtDetalles.TabIndex = 20;
            this.txtDetalles.Texts = "";
            this.txtDetalles.UnderlineStyle = true;
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRes.BorderColor = System.Drawing.Color.Silver;
            this.txtRes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtRes.BorderRadius = 0;
            this.txtRes.BorderSize = 2;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.ForeColor = System.Drawing.Color.Black;
            this.txtRes.Location = new System.Drawing.Point(307, 279);
            this.txtRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRes.MaxLength = 200;
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRes.PasswordChar = false;
            this.txtRes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRes.PlaceholderText = "Resultado";
            this.txtRes.Size = new System.Drawing.Size(396, 117);
            this.txtRes.TabIndex = 18;
            this.txtRes.Texts = "";
            this.txtRes.UnderlineStyle = true;
            this.txtRes.Paint += new System.Windows.Forms.PaintEventHandler(this.txtRes_Paint);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 5;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton1.FlatAppearance.BorderSize = 4;
            this.rjButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(280, 422);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(160, 50);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.Text = "Agregar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTel.BorderColor = System.Drawing.Color.White;
            this.txtTel.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTel.BorderRadius = 0;
            this.txtTel.BorderSize = 2;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(41, 363);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.MaxLength = 100;
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtTel.PasswordChar = false;
            this.txtTel.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTel.PlaceholderText = "Teléfono";
            this.txtTel.Size = new System.Drawing.Size(250, 32);
            this.txtTel.TabIndex = 16;
            this.txtTel.Texts = "";
            this.txtTel.UnderlineStyle = true;
            // 
            // txtApellMat
            // 
            this.txtApellMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtApellMat.BorderColor = System.Drawing.Color.White;
            this.txtApellMat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtApellMat.BorderRadius = 0;
            this.txtApellMat.BorderSize = 2;
            this.txtApellMat.Enabled = false;
            this.txtApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMat.ForeColor = System.Drawing.Color.Black;
            this.txtApellMat.Location = new System.Drawing.Point(38, 285);
            this.txtApellMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellMat.MaxLength = 100;
            this.txtApellMat.Multiline = true;
            this.txtApellMat.Name = "txtApellMat";
            this.txtApellMat.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtApellMat.PasswordChar = false;
            this.txtApellMat.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtApellMat.PlaceholderText = "Apellido materno";
            this.txtApellMat.Size = new System.Drawing.Size(250, 32);
            this.txtApellMat.TabIndex = 15;
            this.txtApellMat.Texts = "";
            this.txtApellMat.UnderlineStyle = true;
            // 
            // txtApellPat
            // 
            this.txtApellPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtApellPat.BorderColor = System.Drawing.Color.White;
            this.txtApellPat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtApellPat.BorderRadius = 0;
            this.txtApellPat.BorderSize = 2;
            this.txtApellPat.Enabled = false;
            this.txtApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPat.ForeColor = System.Drawing.Color.Black;
            this.txtApellPat.Location = new System.Drawing.Point(41, 207);
            this.txtApellPat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellPat.MaxLength = 100;
            this.txtApellPat.Multiline = true;
            this.txtApellPat.Name = "txtApellPat";
            this.txtApellPat.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtApellPat.PasswordChar = false;
            this.txtApellPat.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtApellPat.PlaceholderText = "Apellido paterno";
            this.txtApellPat.Size = new System.Drawing.Size(250, 32);
            this.txtApellPat.TabIndex = 14;
            this.txtApellPat.Texts = "";
            this.txtApellPat.UnderlineStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(38, 129);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 34);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Apellido materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Télefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Detalles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Diagnóstico";
            // 
            // AnadirResultadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(738, 501);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtApellMat);
            this.Controls.Add(this.txtApellPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnadirResultadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirResultadoForm";
            this.Load += new System.EventHandler(this.AnadirResultadoForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private prueba.TextBoxD txtTel;
        private prueba.TextBoxD txtApellMat;
        private prueba.TextBoxD txtApellPat;
        private prueba.TextBoxD txtNombre;
        private prueba.TextBoxD txtRes;
        private System.Windows.Forms.Label label2;
        private prueba.TextBoxD txtDetalles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}