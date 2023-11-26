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

namespace CapaPresentacion
{
    public partial class AnadirResultadoForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        private bool editarCita;
        public AnadirResultadoForm(bool editarCita)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            this.editarCita = editarCita;
            ttAyuda.SetToolTip(txtNombre, "Nombre del paciente");
            ttAyuda.SetToolTip(txtApellMat, "Apellido Materno del paciente");
            ttAyuda.SetToolTip(txtApellPat, "Apellido Paterno del paciente");
            ttAyuda.SetToolTip(txtDetalles, "Detalles o motivo de la cita");
            ttAyuda.SetToolTip(txtRes, "Ingrese el diágnostico o resultado de la cita \n Este apartado no puede estar vacio");
            ttAyuda.SetToolTip(rjButton1, "Finalizar cita y agregar diagnóstico");

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
        private void AnadirResultadoForm_Load(object sender, EventArgs e)
        {
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal);
            RellenarCampos(cita);

        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rjButton1_Click(object sender, EventArgs e)
        {
          
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal, txtRes.Texts);
            if (editarCita && FinalizarCita(cita))
            {
                Form formularioCerrar = Application.OpenForms["EditarCitaForm"];
                formularioCerrar.Close();
                Close();
            }
            if (!editarCita && FinalizarCita(cita))
            {
                Close();   
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="cita"></param>
        private void RellenarCampos(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow registro in logicaSecretaria.GetDetellesCita(cita).Rows)
            {
                txtNombre.Texts = registro[0].ToString();
                txtApellPat.Texts = registro[1].ToString();
                txtApellMat.Texts = registro[2].ToString();
                txtTel.Texts = registro[3].ToString();
                txtDetalles.Texts = registro[4].ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private bool FinalizarCita(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            return logicaSecretaria.FinalizarCita(cita);
          
        }

        private void txtRes_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void AnadirResultadoForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}