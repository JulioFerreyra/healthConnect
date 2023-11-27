﻿using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
namespace CapaPresentacion
{
    public partial class EditarPacienteForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        public EditarPacienteForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            ttAyuda.SetToolTip(txtNombre, "Nombre del Paciente");
            ttAyuda.SetToolTip(txtApellMat, "Apellido Materno del Paciente");
            ttAyuda.SetToolTip(txtApellPat, "Apellido Paterno del Paciente");
            ttAyuda.SetToolTip(txtDireccion, "Dirección del Paciente");
            ttAyuda.SetToolTip(txtTelefono, "Número de teléfono del Paciente");
            ttAyuda.SetToolTip(cmbxSexo, "Sexo del Paciente");
            ttAyuda.SetToolTip(dtpFechaNac, "Fecha de naciminento del Paciente");
            ttAyuda.SetToolTip(btnAceptar, "Actualizar Datos");
            ttAyuda.SetToolTip(btnAyuda, "Ayuda");
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constantes necesarias para manipular la posición de la ventana
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarPacienteForm_Load(object sender, EventArgs e)
        {
            
            RellenarCampos();
            
        }


        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //aqui borre el textboxd1
            Paciente paciente = new Paciente(ElementosGlobales.idPacienteGlobal, txtNombre.Texts, txtApellPat.Texts, txtApellMat.Texts, txtTelefono.Texts,txtDireccion.Texts, dtpFechaNac.Value, cmbxSexo.Texts[0].ToString());
            
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            if (logicaSecretaria.EditarPaciente(paciente))
            {
                Close();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarCampos()
        {
         LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow registro in logicaSecretaria.GetPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
                txtNombre.Texts = registro[0].ToString();
                //lo borre textBoxD1.Texts = registro[0].ToString();
                txtApellPat.Texts = registro[1].ToString();
                txtApellMat.Texts = registro[2].ToString();
                txtTelefono.Texts = registro[3].ToString();
                txtDireccion.Texts = registro[4].ToString();
                dtpFechaNac.Value = DateTime.Parse(registro[5].ToString());
                if (registro[6].ToString() == "F")
                {
                    cmbxSexo.SelectedIndex = 1;
                }
                if (registro[6].ToString() == "M")
                {
                    cmbxSexo.SelectedIndex = 0;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {

            }
            else if (e.KeyChar == '\b')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellPat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {

            }
            else if (e.KeyChar == '\b')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellMat_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {

            }
            else if (e.KeyChar == '\b')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '\b')
                {
                    // Permitir la tecla de retroceso (borrar caracteres)
                    e.Handled = false;
                }
                else
                {
                    // Evitar que se ingrese el carácter si no es un número
                    e.Handled = true;
                }
            }
            else if (txtTelefono.Text.Length >= 10)
            {
                // Evitar que se ingrese más de 10 caracteres
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {

            }
            else if (e.KeyChar == '\b')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void EditarPacienteForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Editar Paciente: Modifique los campos requeridos y presione en 'Guardar'", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
