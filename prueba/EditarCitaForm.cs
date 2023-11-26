using CapaEntidad;
using CapaLogica;
using prueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class EditarCitaForm : Form
    {
        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(146, 171, 255);
        private bool condicionEditarCita;
        private int podologo;
        public EditarCitaForm(bool condicionEditarCita)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White;
            ttAyuda.SetToolTip(btnAyuda, "Para seleccionar a un Paciente de clic sobre el icono de lupa");
            ttAyuda.SetToolTip(button1, "Seleccionar Paciente");
            ttAyuda.SetToolTip(CmbxPodologo, "Seleccionar Profesionista");
            ttAyuda.SetToolTip(cmbxHora, "Seleccionar Hora disponible");
            ttAyuda.SetToolTip(cmbxTipoCita, "Seleccionar Tipo de Cita");
            ttAyuda.SetToolTip(dtFecha, "Seleccionar Fecha");
            ttAyuda.SetToolTip(tbxSintomas, "Seleccionar profesionista");
            ttAyuda.SetToolTip(txtAceptar, "Aceptar y Guardar");
            ttAyuda.SetToolTip(btnFinalizar, "Finalizar cita y Agregar Resultado");
            this.condicionEditarCita = condicionEditarCita;
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


        /// <summary>
        /// LoadForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarCitaForm_Load(object sender, EventArgs e)
        {
            RellenarComboBoxPodologo();
            RellenarBoxHoras();
            RellenarCampos();
            RellenarTiposCita();
            //if (ElementosGlobales.idUsuarioGlobal != 3)
            //{
            //    CmbxPodologo.Enabled = false;
            //    cmbxEstadoCita.Enabled = false;
            //}
        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PacientesForm BuscarPaciente = new PacientesForm();
            BuscarPaciente.ShowDialog();
            
            
         

            RellenarCamposPaciente();

        }
        private void rjButton4_Click(object sender, EventArgs e)
        {
            AnadirResultadoForm resultado = new AnadirResultadoForm(true);
            resultado.ShowDialog();   
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal, ElementosGlobales.idPacienteGlobal, dtFecha.Value, cmbxHora.Texts, ElementosGlobales.PodologoGlobal, tbxSintomas.Texts, cmbxTipoCita.Texts, "pendiente");
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            
            if (logicaSecretaria.EditarCita(cita, condicionEditarCita))
            {
                //FormPanelSecretaria.AbrirFormulario<SecretariaPrincipalForm>();
                Close();
            }
           
        }


        /// <summary>
        /// DateTimePicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            RellenarBoxHoras();
            DeshabilitarHoras();
            RestablecerComboBoxHora();
        }

        /// <summary>
        /// ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbxPodologo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CmbxPodologo.SelectedIndex == 0)
            //{
            //    ElementosGlobales.PodologoGlobal = 2;
            //}
            //if (CmbxPodologo.SelectedIndex == 1)
            //{
            //    ElementosGlobales.PodologoGlobal = 1;
            //}
            RellenarBoxHoras();
            DeshabilitarHoras();
            RestablecerComboBoxHora();
            ElementosGlobales.PodologoGlobal = ElementosGlobales.idPodologos[CmbxPodologo.SelectedIndex];
        }

        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarCampos()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow renglon in logicaSecretaria.GetCita(ElementosGlobales.idCitaGlobal).Rows)
            {
                tbxNombre.Texts = renglon[0].ToString();
                tbxApellPat.Texts = renglon[1].ToString();
                tbxApellMat.Texts = renglon[2].ToString();
                tbxTelefono.Texts = renglon[3].ToString();
                dtFecha.Value = DateTime.Parse(renglon[4].ToString());
                tbxSintomas.Texts = renglon[6].ToString();
                cmbxTipoCita.Texts = renglon[7].ToString(); 
                
                CmbxPodologo.SelectedIndex = CmbxPodologo.Items.IndexOf(renglon[9].ToString());
                ElementosGlobales.PodologoGlobal = ElementosGlobales.idPodologos[CmbxPodologo.SelectedIndex];
                ElementosGlobales.idPacienteGlobal = (int)renglon[10];
               cmbxHora.SelectedIndex = cmbxHora.Items.IndexOf(renglon[5].ToString());
               

            }
        }

        private void RellenarComboBoxPodologo()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
           
            foreach (DataRow registro in logicaSecretaria.GetPodologos().Rows)
            {
                CmbxPodologo.Items.Add(registro[1].ToString());
            }
        }
        private void RellenarCamposPaciente()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow Filas in logicaSecretaria.GetPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
                tbxNombre.Texts = Filas[0].ToString();
                tbxApellPat.Texts = Filas[1].ToString();
                tbxApellMat.Texts = Filas[2].ToString();
                tbxTelefono.Texts = Filas[3].ToString();
            }
        }
        private void RellenarBoxHoras()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            cmbxHora.Items.Clear();
            foreach (DataRow registro in logicaSecretaria.GetHorasTrabajo().Rows)
            {
                cmbxHora.Items.Add(registro[0].ToString());
            }
        }
        private  void DeshabilitarHoras()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow registro in logicaSecretaria.GetHorasPodologo(dtFecha.Value, ElementosGlobales.PodologoGlobal).Rows)
            {
                int index = cmbxHora.Items.IndexOf(registro[0].ToString());
                cmbxHora.Items.RemoveAt(index);
            }
        }
        private void RestablecerComboBoxHora()
        {
            cmbxHora.Texts = "Hora";
            cmbxHora.SelectedIndex = -1;

        }

        private void RellenarTiposCita()
        {
            LogicaSecretaria logicaSecretsaria = new LogicaSecretaria();
            foreach (DataRow fila in logicaSecretsaria.GetTiposDeCita().Rows)
            {
                cmbxTipoCita.Items.Add(Convert.ToString(fila[0]));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarCitaForm_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }


}
