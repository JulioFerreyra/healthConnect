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
using System.Windows;
using System.Windows.Forms;

namespace CapaPresentacion { 

    public partial class OlvideContraseñaForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
    string usuarioText;
        public OlvideContraseñaForm(string usuarioText)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            this.usuarioText = usuarioText;
        
            ttAyuda.SetToolTip(txtUsuario, "Ingrese su Usuario");
            ttAyuda.SetToolTip(txtContraseña, "Ingrese una nueva contraseña \n Esta debe tener 8 carácteres");
            ttAyuda.SetToolTip(txtConfirmarContraseña, "Confirme su nueva contraseña \n Ambas contraseñas deben coincidir" );
            ttAyuda.SetToolTip(btnAceptar, "Restablecer su contraseña");
            ttAyuda.SetToolTip(lblRegresar, "Regresar a Inicio de Sesión");
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

        private void OlvideContraseñaForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Texts = usuarioText;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Texts, txtContraseña.Texts);
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (logicaUsuario.ValidarActualizarContraseña(usuario, txtConfirmarContraseña.Texts))
            {
               ComprobarContraseñaForm contraseñaForm = new ComprobarContraseñaForm();
                contraseñaForm.ShowDialog();
                ActualizarContraseña(usuario);
                
            }
        
        }

        private void lblRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnMostrarConfirmacion_Click(object sender, EventArgs e)
        {
            txtConfirmarContraseña.PasswordChar = !txtConfirmarContraseña.PasswordChar;
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = !txtContraseña.PasswordChar;
        }
      
      
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtContraseña.Texts.Length > 8)
            {
                e.Handled = true;
            }
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtConfirmarContraseña.Texts.Length > 8)
            {
                e.Handled = true;
            }
        }
        private void ActualizarContraseña(Usuario usuario)
        {
            if (ElementosGlobales.isAdmin)
            {
                LogicaUsuario logicaUsuario = new LogicaUsuario();
                logicaUsuario.ActualizarContraseña(usuario);
                logicaUsuario.ActualizarContraseñaUsuarioMysql(usuario);

                txtConfirmarContraseña.Texts = string.Empty;
                txtContraseña.Texts = string.Empty;
                txtUsuario.Texts = string.Empty;
                return;
            }
          //  MessageBox.Show("Contraseña de administrador invalida");
        }

        private void OlvideContraseñaForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
