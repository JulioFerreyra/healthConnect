﻿namespace prueba
{
    partial class NuevoPacienteForm
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
            this.txtNombre = new prueba.TextBoxD();
            this.txtApellPat = new prueba.TextBoxD();
            this.txtApellMat = new prueba.TextBoxD();
            this.txtTelefono = new prueba.TextBoxD();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(129, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.White;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 39);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellPat
            // 
            this.txtApellPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtApellPat.BorderColor = System.Drawing.Color.White;
            this.txtApellPat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellPat.BorderRadius = 0;
            this.txtApellPat.BorderSize = 2;
            this.txtApellPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellPat.Location = new System.Drawing.Point(129, 188);
            this.txtApellPat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtApellPat.MaxLength = 10;
            this.txtApellPat.Multiline = false;
            this.txtApellPat.Name = "txtApellPat";
            this.txtApellPat.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtApellPat.PasswordChar = false;
            this.txtApellPat.PlaceholderColor = System.Drawing.Color.White;
            this.txtApellPat.PlaceholderText = "Apellido paterno";
            this.txtApellPat.Size = new System.Drawing.Size(333, 39);
            this.txtApellPat.TabIndex = 4;
            this.txtApellPat.Texts = "";
            this.txtApellPat.UnderlineStyle = true;
            this.txtApellPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellPat_KeyPress);
            // 
            // txtApellMat
            // 
            this.txtApellMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtApellMat.BorderColor = System.Drawing.Color.White;
            this.txtApellMat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellMat.BorderRadius = 0;
            this.txtApellMat.BorderSize = 2;
            this.txtApellMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMat.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellMat.Location = new System.Drawing.Point(129, 267);
            this.txtApellMat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtApellMat.MaxLength = 10;
            this.txtApellMat.Multiline = false;
            this.txtApellMat.Name = "txtApellMat";
            this.txtApellMat.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtApellMat.PasswordChar = false;
            this.txtApellMat.PlaceholderColor = System.Drawing.Color.White;
            this.txtApellMat.PlaceholderText = "Apellido materno";
            this.txtApellMat.Size = new System.Drawing.Size(333, 39);
            this.txtApellMat.TabIndex = 5;
            this.txtApellMat.Texts = "";
            this.txtApellMat.UnderlineStyle = true;
            this.txtApellMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellMat_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.White;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(129, 346);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.White;
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(333, 39);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlineStyle = true;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
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
            this.rjButton1.Location = new System.Drawing.Point(189, 425);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(213, 62);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "Guardar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar nuevo paciente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 46);
            this.panel1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(63)))));
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(547, -5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NuevoPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellMat);
            this.Controls.Add(this.txtApellPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NuevoPacienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoPacienteForm";
            this.Load += new System.EventHandler(this.NuevoPacienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxD txtNombre;
        private TextBoxD txtApellPat;
        private TextBoxD txtApellMat;
        private TextBoxD txtTelefono;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}