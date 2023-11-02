using CapaEntidad;
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

namespace prueba
{
    public partial class NuevoPacienteForm : Form
    {
        public NuevoPacienteForm()
        {
            InitializeComponent();
        }

        private void NuevoPacienteForm_Load(object sender, EventArgs e)
        {
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
           
            Paciente NuevoPaciente = new Paciente(txtNombre.Texts, txtApellPat.Texts, txtApellMat.Texts, txtTelefono.Texts,txtDireccion.Texts, dtpFechaNac.Value, cmbxSexo.Texts[0].ToString());
            if (logicaSecretaria.CrearNuevoPaciente(NuevoPaciente))
            {
                txtNombre.Texts = string.Empty;
                txtApellMat.Texts = string.Empty;
                txtApellPat.Texts = string.Empty;
                txtTelefono.Texts = string.Empty;
                dtpFechaNac.Value = DateTime.Now;
                cmbxSexo.SelectedIndex = -1;
                cmbxSexo.Texts = "Sexo";
                SeleccionarPacienteForm.RellenarGrid("");
            }
            return;
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
              
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
              
            }
            else if (e.KeyChar == '\b')
            {
               
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
              
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                
            }
            else if (e.KeyChar == '\b')
            {
               
            }
            else
            {
                e.Handled = true; 
            }
        }

        private void txtApellPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
               
            }
            else if (e.KeyChar == '\b')
            {
               
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
           else if (txtTelefono.Texts.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
