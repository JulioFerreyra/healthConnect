using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace prueba
{
    public partial class NuevoPacienteForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        public NuevoPacienteForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            ttAyuda.SetToolTip(txtNombre, "Ingrese el nombre del paciente");
            ttAyuda.SetToolTip(txtApellMat, "Ingrese el apellido Materno del paciente");
            ttAyuda.SetToolTip(txtApellPat, "Ingrese el apellido paterno del paciente");
            ttAyuda.SetToolTip(txtDireccion, "Ingrese la dirección o domicilio del paciente");
            ttAyuda.SetToolTip(txtTelefono, "Ingrese el número de teléfono del paciente");
            ttAyuda.SetToolTip(dtpFechaNac, "Selecciona la fecha de nacimiento del paciente");
            ttAyuda.SetToolTip(cmbxSexo, "Selecciona el sexo del paciente");


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
        private void NuevoPacienteForm_Load(object sender, EventArgs e)
        {
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
           
            Paciente NuevoPaciente = new Paciente(txtNombre.Texts, txtApellPat.Texts, txtApellMat.Texts, txtTelefono.Texts,txtDireccion.Texts, dtpFechaNac.Value, cmbxSexo.Texts[0].ToString());
            if (logicaSecretaria.CrearNuevoPaciente(NuevoPaciente))
            {
                txtNombre.Texts = string.Empty;
                txtApellMat.Texts = string.Empty;
                txtApellPat.Texts = string.Empty;
                txtTelefono.Texts = string.Empty;
                txtDireccion.Texts = string.Empty;
                dtpFechaNac.Value = DateTime.Now;
                cmbxSexo.SelectedIndex = -1;
                cmbxSexo.Texts = "Sexo";
                //SeleccionarPacienteForm.RellenarGrid("");
            }
            return;
           
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

        private void txtApellMat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellPat_KeyPress(object sender, KeyPressEventArgs e)
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
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
           else if (txtTelefono.Texts.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTelefono__TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoPacienteForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Ingresar nuevo paciente: \n1: Ingrese nombre, apellido paterno y apellido materno del paciente \n2: Ingrese el número de teléfono (10 carácteres) \n3: Seleccione la fecha de nacimiento del paciente \n4: Selecciones el sexo del paciente \n5: De clic en 'Guardar'","Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
