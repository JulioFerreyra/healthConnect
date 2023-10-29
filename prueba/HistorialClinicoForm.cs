using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class HistorialClinicoForm : Form
    {
        public HistorialClinicoForm()
        {
            InitializeComponent();
        }
        private void HistorialClinicoForm_Load(object sender, EventArgs e)
        {
            RellenarCamposPacientes();
            RellenarAntecedentesPaciente();
            cmbTipoPat.SelectedIndex = 0;
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
                numFrecTab.Visible = true;
                return;
            }
            numFrecTab.Visible = !true;
            numFrecTab.Value = 0;
        }

        private void cmbAlc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlc.SelectedIndex == 0)
            {
                numFrecAlc.Visible = true;
                return;
            }
            numFrecAlc.Visible = !true;
            numFrecAlc.Value = 0;
        }

        private void cmbActFis_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbActFis.SelectedIndex == 0)
            {
                numFrecAct.Visible = true;
                return;
            }
            numFrecAct.Visible = false;
            numFrecAct.Value = 0;
        }

        private void cmbTipoPat_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPat.SelectedIndex == 1)
            {
                pnlNoPat.Visible = false;
                pnlPat.Visible = true;

                return;

            }
            //CambiarEstadoCamposNoPat(false);
            pnlNoPat.Visible = !false;
            pnlPat.Visible = !true;
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
                cmbParto.SelectedIndex = bool.Parse(fila[0].ToString()) == true ? 0 : 1;
                cmbHiperlax.SelectedIndex = bool.Parse(fila[1].ToString()) == true ? 0 : 1; 
                cmbTabaco.SelectedIndex = bool.Parse(fila[2].ToString()) == true ? 0 : 1;
                //cmbFrecTab.Texts = string.IsNullOrEmpty(fila[3].ToString()) ? "Frecuencia" : fila[3].ToString();
                numFrecTab.Value = int.Parse(fila[3].ToString());
                cmbAlc.SelectedIndex = bool.Parse(fila[4].ToString()) == true ? 0 : 1;
                numFrecAlc.Value = int.Parse(fila[5].ToString());
                //cmbFrecAlc.Texts = string.IsNullOrEmpty(fila[5].ToString()) ? "Frecuencia" : fila[5].ToString();
                cmbActFis.SelectedIndex = bool.Parse(fila[6].ToString()) == true ? 0 : 1;
                numFrecAct.Value = int.Parse(fila[7].ToString());
                //cmbFrecActFis.Texts = string.IsNullOrEmpty(fila[7].ToString()) ? "Frecuencia" : fila[7].ToString();
                cmbDrogas.SelectedIndex = bool.Parse(fila[8].ToString()) == true ? 0 : 1;
                cmbDiabetes.Texts = fila[9].ToString();
                cmbTension.Texts = fila[10].ToString(); 
                cmbTiroides.Texts = fila[11].ToString();
                cmbHepatitis.Texts = fila[12].ToString();
                cmbCardiopatias.Texts = fila[13].ToString();
                txtInterv.Text = string.IsNullOrEmpty(fila[14].ToString()) ? "" : fila[14].ToString();
                cmbNeoplasia.Texts = fila[15].ToString();
                txtMed.Text = fila[16].ToString();

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
            txtMed.Enabled = estadoCampo;
            BtnGuPat.Visible = estadoCampo;
            BtnEdPat.Visible = !estadoCampo;
        }

        
    }
}
