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
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class HistorialClinicoForm : Form
    {


        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        public HistorialClinicoForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            ttAyuda.SetToolTip(txtNombre, "Nombre del Paciente");
            ttAyuda.SetToolTip(txtApePat, "Apellido Paterno del Paciente");
            ttAyuda.SetToolTip(txtApeMat, "Apellido Materno del Paciente");
            ttAyuda.SetToolTip(txtEdad, "Edad del Paciente");
            ttAyuda.SetToolTip(txtTelf, "Número de teléfono del Paciente");
            ttAyuda.SetToolTip(lblFicha, "Número de ficha");
            ttAyuda.SetToolTip(iconButton1, "Ayuda");
            ttAyuda.SetToolTip(ayudaPat, "Ayuda");
            ttAyuda.SetToolTip(ayudaNoPat, "Ayuda");
            ttAyuda.SetToolTip(iconButton4, "Diagnósticos del paciente");



        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               // ReleaseCapture();
                //SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
        private void HistorialClinicoForm_Load(object sender, EventArgs e)
        {
            RellenarCamposPacientes();
            RellenarAntecedentesPaciente();
            
            CambiarEstadoCamposNoPat(false);
            CambiarEstadoCamposPat(false);


        }
        

        /// <summary>
        /// botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdNoPat_Click(object sender, EventArgs e)
        {
            CambiarEstadoCamposNoPat(true);
        }
        private void btnGuNoPat_Click(object sender, EventArgs e)
        {
            // int fH, fa, fT;
            AntecedentesNoPatologicos antecedentes = new AntecedentesNoPatologicos(ElementosGlobales.idPacienteGlobal, cmbParto.SelectedIndex == 0, cmbHiperlax.SelectedIndex == 0, cmbTabaco.SelectedIndex == 0, cmbAlc.SelectedIndex == 0, cmbDrogas.SelectedIndex ==0, cmbActFis.SelectedIndex == 0, int.Parse(numFrecAlc.Value.ToString()), int.Parse(numFrecAct.Value.ToString()), int.Parse(numFrecTab.Value.ToString()));
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.ActualizarDatosNoPatologicosPaciente(antecedentes);
            CambiarEstadoCamposNoPat(false);
        }

        private void BtnEdPat_Click(object sender, EventArgs e)
        {
            CambiarEstadoCamposPat(true);
        }

        private void BtnGuPat_Click(object sender, EventArgs e)
        {
            AntecedentesPatologicos antecedentes = new AntecedentesPatologicos(ElementosGlobales.idPacienteGlobal, cmbDiabetes.Texts, cmbTension.Texts, cmbTiroides.Texts, cmbHepatitis.Texts, cmbCardiopatias.SelectedIndex ==0, txtInterv.Text, cmbNeoplasia.SelectedIndex == 0, txtMed.Text, txtAlergias.Text);
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.ActualizarAntecedentesPatologicosPaciente(antecedentes);
            CambiarEstadoCamposPat(false);
        }

        /// <summary>
        /// Combo Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTabaco_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTabaco.SelectedIndex == 0)
            {
                lblFrecTab.Visible = true;
                numFrecTab.Visible = true;
                return;
            }
            lblFrecTab.Visible = false;
            numFrecTab.Visible = false;
            numFrecTab.Value = 0;
        }

        private void cmbAlc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlc.SelectedIndex == 0)
            {
                numFrecAlc.Visible = true;
                lblFrecAlc.Visible = true;
                return;
            }
            lblFrecAlc.Visible = false;
            numFrecAlc.Visible = false;
            numFrecAlc.Value = 0;
        }

        private void cmbActFis_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbActFis.SelectedIndex == 0)
            {
                lblFrecAct.Visible = true;
                numFrecAct.Visible = true;
                return;
            }
            lblFrecAct.Visible = false;
            numFrecAct.Visible = false;
            numFrecAct.Value = 0;
        }

        

        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarCamposPacientes()
        {
            
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow fila in logicaPodologo.GetDatosPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
                txtNombre.Texts = fila[0].ToString();
                txtApePat.Texts = fila[1].ToString();
                txtApeMat.Texts = fila[2].ToString();
                txtTelf.Texts = fila[3].ToString();
                txtEdad.Texts = fila[4].ToString();
                txtSexo.Texts = fila[5].ToString() == "F" ? "Femenino" : "Masculino";
            }
            
        }

        private void RellenarAntecedentesPaciente()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow fila in logicaPodologo.GetAntecendetesNoPatologicosPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
                cmbParto.SelectedIndex = bool.Parse(fila[0].ToString()) ? 0 : 1;
                cmbHiperlax.SelectedIndex = bool.Parse(fila[1].ToString()) ? 0 : 1; 
                cmbTabaco.SelectedIndex = bool.Parse(fila[2].ToString()) ? 0 : 1;
                numFrecTab.Value = int.Parse(fila[3].ToString());
                cmbAlc.SelectedIndex = bool.Parse(fila[4].ToString()) ? 0 : 1;
                numFrecAlc.Value = int.Parse(fila[5].ToString());
                cmbActFis.SelectedIndex = bool.Parse(fila[6].ToString()) ? 0 : 1;
                numFrecAct.Value = int.Parse(fila[7].ToString());
                cmbDrogas.SelectedIndex = bool.Parse(fila[8].ToString()) ? 0 : 1;
                //Antecedentes patológicos
              
                cmbDiabetes.SelectedIndex = cmbDiabetes.Items.IndexOf(fila[9].ToString()); 
                cmbTension.SelectedIndex= cmbTension.Items.IndexOf(fila[10].ToString()); 
                cmbTiroides.SelectedIndex = cmbTiroides.Items.IndexOf(fila[11].ToString());
                cmbHepatitis.SelectedIndex = cmbHepatitis.Items.IndexOf(fila[12].ToString());
                cmbCardiopatias.SelectedIndex= bool.Parse(fila[13].ToString()) ? 0 : 1;
                txtInterv.Text = string.IsNullOrEmpty(fila[14].ToString()) ? "" : fila[14].ToString();
                cmbNeoplasia.SelectedIndex = bool.Parse(fila[15].ToString()) ? 0 : 1 ;
                txtMed.Text = fila[16].ToString();
                txtAlergias.Text = fila[17].ToString();
                lblFicha.Text += fila[18].ToString();

            }
        }

        private void CambiarEstadoCamposNoPat(bool estadoCampo)
        {
            cmbAlc.Enabled = estadoCampo;
            cmbActFis.Enabled = estadoCampo;
            cmbDrogas.Enabled = estadoCampo;
            cmbHiperlax.Enabled = estadoCampo;
            cmbParto.Enabled = estadoCampo;
            cmbTabaco.Enabled = estadoCampo;
            btnGuNoPat.Visible = estadoCampo;
            BtnEdNoPat.Visible = !estadoCampo;
            numFrecAlc.Enabled = estadoCampo;
            numFrecTab.Enabled = estadoCampo;
            numFrecAct.Enabled = estadoCampo;
            lblFrecAct.Visible = cmbActFis.SelectedIndex == 0;
            lblFrecAlc.Visible = cmbAlc.SelectedIndex == 0;
            lblFrecTab.Visible = cmbTabaco.SelectedIndex == 0;

        }

        private void CambiarEstadoCamposPat(bool estadoCampo)
        {
            cmbCardiopatias.Enabled = estadoCampo;
            cmbDiabetes.Enabled = estadoCampo;
            cmbHepatitis.Enabled = estadoCampo;
            cmbTension.Enabled = estadoCampo;
            cmbTiroides.Enabled = estadoCampo;
            cmbNeoplasia.Enabled = estadoCampo;
            txtInterv.Enabled = estadoCampo;
            txtAlergias.Enabled = estadoCampo;
            txtMed.Enabled = estadoCampo;
            BtnGuPat.Visible = estadoCampo;
            BtnEdPat.Visible = !estadoCampo;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void RellenarGridDiagnosticos()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            DataTable diagnosticos = logicaPodologo.GetDiagnosticosCitasPaciente(ElementosGlobales.idPacienteGlobal);
            diagnosticos.Merge(logicaPodologo.GetDiagnosticosCitasPacienteRemoto(ElementosGlobales.idPacienteGlobal));
            dgDiagnosticos.DataSource = diagnosticos;
    }
        private void tabHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabHistorial.SelectedIndex == 2)
            {

                RellenarGridDiagnosticos();
                if (dgDiagnosticos.Columns.Count != 0)
                {
                    dgDiagnosticos.Columns["ID"].Visible = false;
                }
            }
        }

        private void cmbDiabetes_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistorialClinicoForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Historial Clínico del paciente. \nSe clasifican los antecedentes patológicos, no patológicos y el historial de diagnósticos", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ayudaPat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Antecentes patológicos del paciente. \n Para Editar los datos de clic sobre el botón de 'Editar', modifique los datos necesarios.Finalmente de clic en el botón de 'Guardar'", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayudaNoPat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Antecentes no patológicos del paciente. \n Para Editar los datos de clic sobre el botón de 'Editar', modifique los datos necesarios. Finalmente de clic en el botón de 'Guardar'", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
