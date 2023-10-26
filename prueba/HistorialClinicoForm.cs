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
            cmbTipoPat.SelectedIndex = 0;
            CambiarEstadoCamposNoPat(false);
           
        }

        private void BtnEdNoPat_Click(object sender, EventArgs e)
        {
            CambiarEstadoCamposNoPat(true);
        }
        private void btnGuNoPat_Click(object sender, EventArgs e)
        {
            CambiarEstadoCamposNoPat(false);
        }



        private void RellenarCamposPacientes()
        {
            
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow dr in logicaPodologo.GetDatosPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
                txtNombre.Texts = dr[0].ToString();
                txtApePat.Texts = dr[1].ToString();
                txtApeMat.Texts = dr[2].ToString();
                txtTelf.Texts = dr[3].ToString();
                txtEdad.Texts = dr[4].ToString();
                txtSexo.Texts = dr[5].ToString() == "F" ? "Femeninio" : "Masculino";
            }
        }

        private void cmbTipoPat_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPat.SelectedIndex == 1)
            {
                pnlNoPat.Visible = false;
                pnlPat.Visible = true;
                return;
            }
            pnlNoPat.Visible = !false;
            pnlPat.Visible = !true;
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
           cmbFrecAlc.Visible = false;
            cmbFrecTab.Visible = false;
            cmbFrecActFis.Visible = false;
            BtnEdNoPat.Visible = !estadoCampo;
        }

       
    }
}
