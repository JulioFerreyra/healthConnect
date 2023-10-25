using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
namespace CapaPresentacion
{
    public partial class EditarPacienteForm : Form
    {
        public EditarPacienteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarPacienteForm_Load(object sender, EventArgs e)
        {
            
            RellenarCampos();

        }


        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //aqui borre el textboxd1
            //Paciente paciente = new Paciente(ElementosGlobales.idPacienteGlobal, textBoxD1.Texts, txtApellPat.Texts, txtApellMat.Texts, txtTelefono.Texts,txtDireccion.Texts, dtpFechaNac.Value, cmbxSexo.Texts[0].ToString());
            //MessageBox.Show(textBox1.Text);
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            //if (logicaSecretaria.EditarPaciente(paciente))
            //{
            //    Close();
            //}

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarCampos()
        {
         LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow registro in logicaSecretaria.GetPaciente(ElementosGlobales.idPacienteGlobal).Rows)
            {
               //lo borre textBoxD1.Texts = registro[0].ToString();
                txtApellPat.Text = registro[1].ToString();
                txtApellMat.Text = registro[2].ToString();
                txtTelefono.Text = registro[3].ToString();
                txtDireccion.Text = registro[4].ToString();
                dtpFechaNac.Value = DateTime.Parse(registro[5].ToString());
                if (registro[6].ToString() == "F")
                {
                    cmbxSexo.SelectedIndex = 1;
                }
                if (registro[6].ToString() == "M")
                {
                    cmbxSexo.SelectedIndex = 0;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txtApellPat_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtApellMat_KeyPress_1(object sender, KeyPressEventArgs e)
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
                    // Permitir la tecla de retroceso (borrar caracteres)
                    e.Handled = false;
                }
                else
                {
                    // Evitar que se ingrese el carácter si no es un número
                    e.Handled = true;
                }
            }
            else if (txtTelefono.Text.Length >= 10)
            {
                // Evitar que se ingrese más de 10 caracteres
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
