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

        List<int> profesionistasRomotos = new List<int>();
        public NuevaCitaForm()
        {
            InitializeComponent();
        }
        private bool letram = false;
        private void NuevaCitaForm_Load(object sender, EventArgs e)
        {
            cmbSucursal.SelectedIndex = 0;
            RellenarComboBoxPodologos();
            RellenarGrid();
            RellenarComboBoxHora();
            RestablecerComboBoxHora();
            RellenarTiposCita();
            cmbxHora.Enabled = false;
            ttAyuda.SetToolTip(btnAyuda, "Ayuda");
            ttAyuda.SetToolTip(button1, "Seleccionar paciente");
            if (dgPodologos.Columns.Count != 0)
            {
                dgPodologos.Columns["ID"].Visible = false;
            }

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
            
            if (cmbSucursal.SelectedIndex == 0)
            {
                Cita cita = new Cita(ElementosGlobales.idPacienteGlobal, dtFechaCita.Value, cmbxHora.Texts, cmbxPodologo.SelectedIndex == -1 ? 0 : ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex], tbxSintomas.Texts, cmbxTipoCita.Texts);

                LimpiarCampos(cita);
                //RestablecerComboBoxHora();
                RellenarGrid();
                return;
            }
            Cita citaRemota = new Cita(ElementosGlobales.idPacienteGlobal, dtFechaCita.Value, cmbxHora.Texts, cmbxPodologo.SelectedIndex == -1 ? 0 : profesionistasRomotos[cmbxPodologo.SelectedIndex], tbxSintomas.Texts, cmbxTipoCita.Texts);

            InsertarCitaRemota(citaRemota);
            RellenarGridRemoto();


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
            if (cmbSucursal.SelectedIndex == 0)
            {
                RellenarGrid();
                RellenarComboBoxHora();
                DeshabilitarHora();
                RestablecerComboBoxHora();
            }
            if (cmbSucursal.SelectedIndex == 1)
            {
                RellenarGridRemoto();
                RellenarComboBoxHoraRemota();
                DeshabilitarHoraRemota();
                RestablecerComboBoxHora();
            }
        }


        ///<summary>
        ///ComboBox
        /// </summary>
        /// 
        private void cmbxPodologo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedIndex == 0)
            {
                RellenarGrid();
                RellenarComboBoxHora();
                DeshabilitarHora();
                RestablecerComboBoxHora();
                cmbxHora.Enabled = true;
            }
            if (cmbSucursal.SelectedIndex == 1)
            {
                RellenarGridRemoto();
                RellenarComboBoxHoraRemota();
                DeshabilitarHoraRemota();
                RestablecerComboBoxHora();
                cmbxHora.Enabled = true;
            }
            }


        ///<summary>
        ///Metodos externos
        /// </summary>

        private void RellenarGrid()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            if (cmbxPodologo.SelectedIndex < 0 )
            {
                dgPodologos.DataSource = logicaSecretaria.VerConsultasPodologo(dtFechaCita.Value,0);
                return;
            }
            dgPodologos.DataSource= logicaSecretaria.VerConsultasPodologo(dtFechaCita.Value, ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);
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
        private void RellenarComboBoxHora()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            cmbxHora.Items.Clear();
            foreach (DataRow hora in logicaSecretaria.GetHorasTrabajo().Rows)
            {
                cmbxHora.Items.Add(hora[0]);
            }
        }

        private void RellenarComboBoxPodologos()
        {
            cmbxPodologo.Items.Clear();
            LogicaSecretaria secretaria = new LogicaSecretaria();
            foreach (DataRow registro in secretaria.GetPodologos().Rows)
            {
                cmbxPodologo.Items.Add(registro[1].ToString());
            }
        }
        private void DeshabilitarHora()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow hora in logicaSecretaria.GetHorasPodologo(dtFechaCita.Value, cmbxPodologo.SelectedIndex == -1 ? 0 : ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]).Rows)
            {
                int index = cmbxHora.Items.IndexOf(hora[0].ToString());
                cmbxHora.Items.RemoveAt(index);
            }
        }
        private void LimpiarCampos(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();

            if (logicaSecretaria.CrearNuevaCita(cita))
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
        private void RellenarTiposCita()
        {
            cmbxTipoCita.Items.Clear();
            LogicaSecretaria logicaSecretsaria = new LogicaSecretaria();
            foreach (DataRow fila in logicaSecretsaria.GetTiposDeCita().Rows)
            {
                cmbxTipoCita.Items.Add(Convert.ToString(fila[0]));
            }
        }

        private void cmbSucursal_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxPodologo.SelectedIndex = -1;
            cmbxPodologo.Texts = "Profesionista";
            if (cmbSucursal.SelectedIndex == 0)
            {
                RellenarGrid();
                RellenarComboBoxPodologos();
                RellenarComboBoxHora();
                RellenarTiposCita();
            }
            if (cmbSucursal.SelectedIndex ==1)
            {
                RellenarGridRemoto();
                RellenarComboBoxPodologosRemoto();
                RellenarComboBoxHoraRemota();
                RellenarTiposCitaRemoto();
            }
        }

        /// <summary>
        /// Remoto
        /// </summary>
        private void RellenarComboBoxPodologosRemoto()
        {
            cmbxPodologo.Items.Clear();
            LogicaSecretaria secretaria = new LogicaSecretaria();
            foreach (DataRow registro in secretaria.GetPodologosRemoto().Rows)
            {
                cmbxPodologo.Items.Add(registro[1].ToString());
                profesionistasRomotos.Add(Convert.ToInt32(registro[0]));
            }
        }

        private void RellenarComboBoxHoraRemota()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            cmbxHora.Items.Clear();
            foreach (DataRow hora in logicaSecretaria.GetHorasTrabajoRemoto().Rows)
            {
                cmbxHora.Items.Add(hora[0]);
            }
        }
        private void DeshabilitarHoraRemota()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow hora in logicaSecretaria.GetHorasPodologoRemoto(dtFechaCita.Value, cmbxPodologo.SelectedIndex == -1 ? 0 : profesionistasRomotos[cmbxPodologo.SelectedIndex]).Rows)
            {
                int index = cmbxHora.Items.IndexOf(hora[0].ToString());
                cmbxHora.Items.RemoveAt(index);
            }
        }

        private void RellenarTiposCitaRemoto()
        {
            cmbxTipoCita.Items.Clear();
            LogicaSecretaria logicaSecretsaria = new LogicaSecretaria();
            foreach (DataRow fila in logicaSecretsaria.GetTiposDeCitaRemoto().Rows)
            {
                cmbxTipoCita.Items.Add(Convert.ToString(fila[0]));
            }
        }

        private void RellenarGridRemoto()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            if (cmbxPodologo.SelectedIndex < 0)
            {
                dgPodologos.DataSource = logicaSecretaria.VerCitasPodologoRemotas(dtFechaCita.Value, 0);
                return;
            }
            dgPodologos.DataSource = logicaSecretaria.VerCitasPodologoRemotas(dtFechaCita.Value, ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);
        }

        private void InsertarCitaRemota(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();

            if (logicaSecretaria.CrearNuevaCitaRemota(cita))
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

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear una nueva cita: \n 1: Seleccione al paciente dando clic sobre el icono de lupa. \n2: Seleccione al profesionista, esto habilitará el selector de 'Horas'\n3: Seleccione la fecha y hora de la cita \n4: Seleccione el tipo de cita \n5: Ingrese los sintomas o motivo de la cita. \n6: Seleccione la sucursal \n(Es posible que varios campos regresen a su valor predeterminado)","Ayuda",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
