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

namespace CapaPresentacion
{
    public partial class NuevoUsuarioForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        private bool isAdmin = false;
        public NuevoUsuarioForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
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

        private void NuevoUsuarioForm_Load(object sender, EventArgs e)
        {
            cmbSucursal.SelectedIndex = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            Usuario usuario = new Usuario(txtNombre.Texts,txtContra.Texts, isAdmin);
            if (cmbSucursal.SelectedIndex == 0)
            {

            CrearUsuario(usuario);
                return;
            }
            CrearUsuarioRemoto(usuario);


        }

        private void cmbPuesto_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.SelectedIndex == 0)
            {
                isAdmin = false;
                return;
            }
            if (cmbPuesto.SelectedIndex == 1)
            {
                isAdmin = true;
                return;
            }
        }

        private void CrearUsuario(Usuario usuario)
        {
            LogicaPodologo logica = new LogicaPodologo();
            if (logica.CraerUsuario(usuario, cmbPuesto.Texts, txtConfirmar.Texts))
            {
                GrantAccess();
                Close();
            }
        }
        private void GrantAccess()
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (isAdmin)
            {
                logicaUsuario.GrantAccessAdministrador(txtNombre.Texts);
                return;
            }
            logicaUsuario.GrantAccessSecreataria(txtNombre.Texts);
        }

        private void CrearUsuarioRemoto(Usuario usuario)
        {
            LogicaPodologo logica = new LogicaPodologo();
            if (logica.CraerUsuarioRemoto(usuario, cmbPuesto.Texts, txtConfirmar.Texts))
            {
                GrantAccessRemoto();
                Close();
            }
        }
        private void GrantAccessRemoto()
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (isAdmin)
            {
                logicaUsuario.GrantAccessAdministradorRemoto(txtNombre.Texts);
                return;
            }
            logicaUsuario.GrantAccessSecretariaRemoto(txtNombre.Texts);
        }

        private void NuevoUsuarioForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
