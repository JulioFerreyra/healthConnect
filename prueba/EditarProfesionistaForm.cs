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
    public partial class EditarProfesionistaForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);

        private string sucursal; 
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
        public EditarProfesionistaForm(string sucursal) 
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            this.sucursal = sucursal;

            ttAyuda.SetToolTip(txtNombre, "Nombre del Profesionista");
            ttAyuda.SetToolTip(txtPat, "Apellido Paterno del Profesionista");
            ttAyuda.SetToolTip(txtMat, "Apellido Materno del Profesionista");
            ttAyuda.SetToolTip(txtTel, "Número de Teléfono del Profesionista");
            ttAyuda.SetToolTip(cmbSucursal, "Sucural de Trabajo del Profesionista");
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

        private void EditarProfesionsitaForm_Load(object sender, EventArgs e)
        {
            RellenarCamposProfesionista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Profesionista profesionista = new Profesionista(ElementosGlobales.PodologoGlobal, txtNombre.Texts,txtPat.Texts,txtMat.Texts,txtTel.Texts);
            if (cmbSucursal.SelectedIndex == 0)
            {
                ActualizarProfesionistasLocal(profesionista);
                return;
            }
            ActualizarProfesionistasRemoto(profesionista);
            
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (txtTel.Texts.Length >= 10)
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarCamposProfesionista()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow fila in logicaPodologo.GetDatosProfesionista(ElementosGlobales.PodologoGlobal).Rows)
            {
                txtNombre.Texts = Convert.ToString(fila[0]);
                txtPat.Texts = Convert.ToString(fila[1]);
                txtMat.Texts = Convert.ToString(fila[2]);
                txtTel.Texts = Convert.ToString(fila[3]);
            }
            cmbSucursal.SelectedIndex = cmbSucursal.Items.IndexOf(sucursal);
        }

        private void ActualizarProfesionistasLocal(Profesionista profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.ActualizarDatosProfesionista(profesionista))
            {
                Close();
                return;
            }
        }

        private void ActualizarProfesionistasRemoto(Profesionista profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.ActualizarDatosProfesionistaRemoto(profesionista))
            {
                Close();
                return;
            }

        }

        private void EditarProfesionistaForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void ttAyuda_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Editar Profesionista: Modifique los campos requeridos y presione en 'Guardar'", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
