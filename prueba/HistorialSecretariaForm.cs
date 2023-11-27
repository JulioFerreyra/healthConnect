using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
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

namespace prueba
{
    public partial class HistorialSecretariaForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        private string nombrePaciente; 
        public HistorialSecretariaForm(string nombrePaciente)
        {
            InitializeComponent();
            this.nombrePaciente = nombrePaciente;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            ttAyuda.SetToolTip(btnAyuda, "Citas Proximas");
            ttAyuda.SetToolTip(lblPaciente, "Paciente");
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
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
        private void HistorialSecretariaForm_Load(object sender, EventArgs e)
        {
            lblPaciente.Text += nombrePaciente;
            Paciente paciente = new Paciente(ElementosGlobales.idPacienteGlobal);
            RellenarDataGrid(paciente);
            AgregarBotonGrid();

        }

        /// <summary>
        /// Botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Método
        /// </summary>
        /// <param name="paciente"></param>
        private void RellenarDataGrid(Paciente paciente)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            DataTable citasPaciente = logicaSecretaria.VerHistoralPaciente(paciente);
            citasPaciente.Merge(logicaSecretaria.VerCitasPacienteRemoto(paciente));
            dgHistorial.DataSource = citasPaciente;

        }
        private void AgregarBotonGrid()
        {
            DataGridViewImageColumn btnDetalles = new DataGridViewImageColumn();
            btnDetalles.Name = "DetallesCol";
            btnDetalles.HeaderText = "Ver detalles";
            btnDetalles.ImageLayout = DataGridViewImageCellLayout.Normal;
            btnDetalles.Image = CapaPresentacion.Properties.Resources.detalles;
            btnDetalles.Width = 40;
            dgHistorial.Columns.Add(btnDetalles);

        }

        private void dgHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgHistorial.Columns[e.ColumnIndex].Name == "DetallesCol")
                {
                    int index = dgHistorial.Rows.IndexOf(dgHistorial.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgHistorial.Rows[index].Cells["ID"].Value;
                    DetallesCitaForm detalles = new DetallesCitaForm();
                    detalles.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void dgHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistorialSecretariaForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
