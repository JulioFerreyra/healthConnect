using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SeleccionReporteForm : Form
    {
        public SeleccionReporteForm()
        {
            InitializeComponent();
           
        }

        private void SeleccionReporteForm_Load(object sender, EventArgs e)
        {
           
            SetOffLimitTipoCita();
            SetOffLimitFechas();
            if (ElementosGlobales.UsuarioCondicion == false)
            {
                cmbxPodologo.SelectedIndex = ElementosGlobales.PodologoGlobal;
            }
            if (ElementosGlobales.UsuarioCondicion == true)
            {
                cmbxPodologo.SelectedIndex = -1;
                cmbxPodologo.Texts = "Podólogo";
            }
            cmbxPodologo.Enabled = false;
           
           
        }

 

        /// <summary>
        /// ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxSeleccion_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxSeleccion.SelectedIndex ==0)
            {
                SetOffLimitFechas();
                SetInLimitTipoCita();
                ElementosGlobales.TipoReporte = 1;
            }
            if (cmbxSeleccion.SelectedIndex ==1)
            {
                SetOffLimitTipoCita();
                SetInLimitFechas();
                ElementosGlobales.TipoReporte = 2;
            }
            cmbxPodologo.Enabled = ElementosGlobales.UsuarioCondicion;

        }
        private void cmbxEstadoCita_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxEstadoCita.SelectedIndex==0)
            {
                ElementosGlobales.EstadoCita = string.Empty;
            }
            if (cmbxEstadoCita.SelectedIndex !=0)
            {
                ElementosGlobales.EstadoCita = cmbxEstadoCita.SelectedItem.ToString().ToLower();
            }
        }
        private void cmbxPodologo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPodologo.SelectedIndex > 0)
            {
                ElementosGlobales.PodologoGlobal = cmbxPodologo.SelectedIndex;
            }
        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AsignacionesEspeciales();
                ElementosGlobales.FechasReporte.Clear();
                ElementosGlobales.FechasReporte.Add(dtInicio.Value.Date, dtFinal.Value.Date);
                ElementosGlobales.tipoCita = cmbxTipoCita.Texts;
                ReporteForm reporteForm = new ReporteForm();
                Hide();
                reporteForm.ShowDialog();
                Close();
            }
            return;
        }


        /// <summary>
        /// Métodos
        /// </summary>
        private void SetInLimitTipoCita() 
        {
            cmbxTipoCita.Location = new System.Drawing.Point(27, 126);
            cmbxTipoCita.Enabled = true;
        }
        private void SetOffLimitTipoCita()
        {
            cmbxTipoCita.Location = new System.Drawing.Point(33, Bottom + 100);
            cmbxTipoCita.SelectedIndex = -1;
            cmbxTipoCita.Texts = "Tipo Cita";
            cmbxTipoCita.Enabled=false;
        }
        private void SetInLimitFechas() 
        {
            dtFinal.Location = new System.Drawing.Point(262, 122);
            dtInicio.Location = new System.Drawing.Point(27, 122);
            dtInicio.Enabled = true;
            dtFinal.Enabled = true;
        }
        private void SetOffLimitFechas()
        {
            dtFinal.Location = new System.Drawing.Point(66, Bottom + 100);
            dtInicio.Location = new System.Drawing.Point(99, Bottom + 100);
            dtInicio.Value = DateTime.Now;
            dtInicio.Enabled = false;
            dtFinal.Enabled = false;


        }
        private bool ValidarCampos()
        {
            if (cmbxSeleccion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro para generar el reporte para continuar");
                return false;
            }
            if (cmbxPodologo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Pódologo para generar el reporte para continuar");
                return false;
            }
            if (cmbxTipoCita.Enabled == false && (dtFinal.Value.Date <= dtInicio.Value.Date))
            {
                MessageBox.Show("Seleccione una fecha final diferente para continuar");
                return false;
            }
            if (dtFinal.Enabled == false && cmbxTipoCita.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cita  para continuar");
                return false;
            }
            if (cmbxEstadoCita.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccione el estado de cita que desea consultar para continuar");
                return false;
            }
            return true;
        }
        private void AsignacionesEspeciales()
        {
            if (cmbxPodologo.SelectedIndex == 0 && cmbxSeleccion.SelectedIndex == 0)
            {
                ElementosGlobales.TipoReporte = 3;
            }
            if (cmbxPodologo.SelectedIndex == 0 && cmbxSeleccion.SelectedIndex == 1)
            {
                ElementosGlobales.TipoReporte = 4;
            }
        }
       
    }

  
}
