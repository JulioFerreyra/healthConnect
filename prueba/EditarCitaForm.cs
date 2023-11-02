using CapaEntidad;
using CapaLogica;
using prueba;
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
    public partial class EditarCitaForm : Form
    {
        private int podologo;
        public EditarCitaForm()
        {
            InitializeComponent();
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
            AnadirResultadoForm resultado = new AnadirResultadoForm();
            resultado.ShowDialog();   
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal, ElementosGlobales.idPacienteGlobal, dtFecha.Value, cmbxHora.Texts, ElementosGlobales.PodologoGlobal, tbxSintomas.Texts, cmbxTipoCita.Texts, cmbxEstadoCita.Texts.ToLower());
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            
            if (logicaSecretaria.EditarCita(cita))
            {
                FormPanelSecretaria.AbrirFormulario<SecretariaPrincipalForm>();
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
                cmbxEstadoCita.Texts= renglon[8].ToString();
                
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

     
    }


}
