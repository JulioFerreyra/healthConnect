using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PacientesForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        public PacientesForm()
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
        private void PacientesForm_Load(object sender, EventArgs e)
        {
            RellenarGrid(string.Empty);
            dgPacientes.Columns["ID"].Visible = false;

        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            RellenarGrid(txtBuscar.Texts);
        }

        /// <summary>
        /// DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int FilaSeleccionada = dgPacientes.Rows.IndexOf(dgPacientes.Rows[e.RowIndex]);
                ElementosGlobales.idPacienteGlobal = (int)dgPacientes.Rows[FilaSeleccionada].Cells["ID"].Value;
            }
            catch (Exception)
            {

                
            }
            
            
            Close();
        }     


        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="NombrePaciente"></param>
        private void RellenarGrid(string NombrePaciente)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            dgPacientes.DataSource = logicaSecretaria.VerPacientes(NombrePaciente);

        }

        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PacientesForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
