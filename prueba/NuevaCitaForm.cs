using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class NuevaCitaForm : Form
    {
        public NuevaCitaForm()
        {
            InitializeComponent();
        }
        private bool letram = false;
        private void NuevaCitaForm_Load(object sender, EventArgs e)
        {
           
            RellenarGrid();
            RellenarComboBox();
            RestablecerComboBoxHora();
            cmbxHora.Enabled = false;

        }

        private void textBoxD4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// 
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PacientesForm paciente = new PacientesForm();   
            paciente.ShowDialog();
            RellenarCampos();
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita(ElementosGlobales.idPacienteGlobal, dtFechaCita.Value, cmbxHora.Texts, ElementosGlobales.PodologoGlobal, tbxSintomas.Texts, cmbxTipoCita.Texts);
            LimpiarCampos(cita);
            //RestablecerComboBoxHora();
            RellenarGrid();
           

        }
        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
          
           Close();
        }


        ///<summary>
        ///DateTimePicker
        /// </summary>
        /// 
        private void dtFechaCita_ValueChanged(object sender, EventArgs e)
        {
            RellenarGrid();
            RellenarComboBox();
            DeshabilitarHora();
            RestablecerComboBoxHora();
        }


        ///<summary>
        ///ComboBox
        /// </summary>
        /// 
        private void cmbxPodologo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPodologo.SelectedIndex == 0)
            {
                ElementosGlobales.PodologoGlobal = 2;
                RellenarGrid();

            }
            if (cmbxPodologo.SelectedIndex == 1)
            {
                ElementosGlobales.PodologoGlobal = 1;
                RellenarGrid();
            }
            RellenarComboBox();
            DeshabilitarHora();
            RestablecerComboBoxHora();
            cmbxHora.Enabled = true;
        }


        ///<summary>
        ///Metodos externos
        /// </summary>

        private void RellenarGrid()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            dgPodologos.DataSource= logicaSecretaria.VerConsultasPodologo(dtFechaCita.Value,ElementosGlobales.PodologoGlobal);
        }
        private void RellenarCampos()
        {
            LogicaSecretaria logicaSecretaria= new LogicaSecretaria();
            foreach (DataRow Filas in logicaSecretaria.GetPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
                tbxNombre.Texts = Filas[0].ToString();
                tbxApellPat.Texts = Filas[1].ToString();
                tbxApellMat.Texts = Filas[2].ToString();
                tbxTelefono.Texts = Filas[3].ToString();
            }
        }
        private void RellenarComboBox()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            cmbxHora.Items.Clear();
            foreach (DataRow hora in logicaSecretaria.GetHorasTrabajo().Rows)
            {
                cmbxHora.Items.Add(hora[0]);
            }
        }
        private void DeshabilitarHora()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow hora in logicaSecretaria.GetHorasPodologo(dtFechaCita.Value,ElementosGlobales.PodologoGlobal).Rows)
            {
                int index = cmbxHora.Items.IndexOf(hora[0].ToString());
                cmbxHora.Items.RemoveAt(index);
            }
        }
        private void LimpiarCampos(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();

            if (logicaSecretaria.CrearNuevaCita(cita)==true)
            {
                ElementosGlobales.idPacienteGlobal = 0;
                tbxApellMat.Texts = string.Empty;
                tbxApellPat.Texts = string.Empty;
                tbxNombre.Texts = string.Empty;
                tbxTelefono.Texts = string.Empty;
                tbxSintomas.Texts = string.Empty;
                RestablecerComboBoxHora();
                cmbxHora.Enabled = false;
                cmbxPodologo.Texts = "Podólogo";
                cmbxTipoCita.Texts = "Tipo de cita";
            }
            
        }
        private void RestablecerComboBoxHora()
        {
            cmbxHora.SelectedIndex = -1;
            cmbxHora.Texts = "Hora";
        }
  
    }
}
