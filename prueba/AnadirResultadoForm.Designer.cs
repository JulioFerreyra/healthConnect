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
            this.txtDetalles = new prueba.TextBoxD();
            this.txtRes = new prueba.TextBoxD();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.txtTel = new prueba.TextBoxD();
            this.txtApellMat = new prueba.TextBoxD();
            this.txtApellPat = new prueba.TextBoxD();
            this.txtNombre = new prueba.TextBoxD();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(367, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 46);
            this.label2.TabIndex = 19;
            this.label2.Text = "Diagnóstico";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 46);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDetalles
            // 
            this.txtDetalles.BackColor = System.Drawing.Color.White;
            this.txtDetalles.BorderColor = System.Drawing.Color.Black;
            this.txtDetalles.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.txtDetalles.BorderRadius = 0;
            this.txtDetalles.BorderSize = 2;
            this.txtDetalles.Enabled = false;
            this.txtDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalles.ForeColor = System.Drawing.Color.Black;
            this.txtDetalles.Location = new System.Drawing.Point(503, 176);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDetalles.MaxLength = 100;
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtDetalles.PasswordChar = false;
            this.txtDetalles.PlaceholderColor = System.Drawing.Color.White;
            this.txtDetalles.PlaceholderText = "Detalles";
            this.txtDetalles.Size = new System.Drawing.Size(528, 144);
            this.txtDetalles.TabIndex = 20;
            this.txtDetalles.Texts = "";
            this.txtDetalles.UnderlineStyle = true;
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.White;
            this.txtRes.BorderColor = System.Drawing.Color.Black;
            this.txtRes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.txtRes.BorderRadius = 0;
            this.txtRes.BorderSize = 2;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.ForeColor = System.Drawing.Color.Black;
            this.txtRes.Location = new System.Drawing.Point(503, 380);
            this.txtRes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRes.MaxLength = 200;
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtRes.PasswordChar = false;
            this.txtRes.PlaceholderColor = System.Drawing.Color.White;
            this.txtRes.PlaceholderText = "Resultado";
            this.txtRes.Size = new System.Drawing.Size(528, 144);
            this.txtRes.TabIndex = 18;
            this.txtRes.Texts = "";
            this.txtRes.UnderlineStyle = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
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
            this.rjButton1.Location = new System.Drawing.Point(397, 642);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(213, 62);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.Text = "Agregar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.BorderColor = System.Drawing.Color.Black;
            this.txtTel.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.txtTel.BorderRadius = 0;
            this.txtTel.BorderSize = 2;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(68, 485);
            this.txtTel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTel.MaxLength = 100;
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtTel.PasswordChar = false;
            this.txtTel.PlaceholderColor = System.Drawing.Color.White;
            this.txtTel.PlaceholderText = "Teléfono";
            this.txtTel.Size = new System.Drawing.Size(333, 39);
            this.txtTel.TabIndex = 16;
            this.txtTel.Texts = "";
            this.txtTel.UnderlineStyle = true;
            // 
            // txtApellMat
            // 
            this.txtApellMat.BackColor = System.Drawing.Color.White;
            this.txtApellMat.BorderColor = System.Drawing.Color.Black;
            this.txtApellMat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.txtApellMat.BorderRadius = 0;
            this.txtApellMat.BorderSize = 2;
            this.txtApellMat.Enabled = false;
            this.txtApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMat.ForeColor = System.Drawing.Color.Black;
            this.txtApellMat.Location = new System.Drawing.Point(68, 380);
            this.txtApellMat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtApellMat.MaxLength = 100;
            this.txtApellMat.Multiline = true;
            this.txtApellMat.Name = "txtApellMat";
            this.txtApellMat.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtApellMat.PasswordChar = false;
            this.txtApellMat.PlaceholderColor = System.Drawing.Color.White;
            this.txtApellMat.PlaceholderText = "Apellido materno";
            this.txtApellMat.Size = new System.Drawing.Size(333, 39);
            this.txtApellMat.TabIndex = 15;
            this.txtApellMat.Texts = "";
            this.txtApellMat.UnderlineStyle = true;
            // 
            // txtApellPat
            // 
            this.txtApellPat.BackColor = System.Drawing.Color.White;
            this.txtApellPat.BorderColor = System.Drawing.Color.Black;
            this.txtApellPat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.txtApellPat.BorderRadius = 0;
            this.txtApellPat.BorderSize = 2;
            this.txtApellPat.Enabled = false;
            this.txtApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPat.ForeColor = System.Drawing.Color.Black;
            this.txtApellPat.Location = new System.Drawing.Point(68, 281);
            this.txtApellPat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtApellPat.MaxLength = 100;
            this.txtApellPat.Multiline = true;
            this.txtApellPat.Name = "txtApellPat";
            this.txtApellPat.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtApellPat.PasswordChar = false;
            this.txtApellPat.PlaceholderColor = System.Drawing.Color.White;
            this.txtApellPat.PlaceholderText = "Apellido paterno";
            this.txtApellPat.Size = new System.Drawing.Size(333, 39);
            this.txtApellPat.TabIndex = 14;
            this.txtApellPat.Texts = "";
            this.txtApellPat.UnderlineStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Black;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(68, 177);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.White;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 39);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(154)))));
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1031, -5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AnadirResultadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1096, 779);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnadirResultadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirResultadoForm";
            this.Load += new System.EventHandler(this.AnadirResultadoForm_Load);
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
    }
}