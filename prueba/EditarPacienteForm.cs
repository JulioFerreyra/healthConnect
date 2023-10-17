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
            //Paciente paciente = new Paciente(ElementosGlobales.idPacienteGlobal, txtNombre.Texts, txtApellPat.Texts, txtApellMat.Texts, txtTelefono.Texts);
            //LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
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
                txtNombre.Texts = registro[0].ToString();
                txtApellPat.Texts = registro[1].ToString();
                txtApellMat.Texts = registro[2].ToString();
                txtTelefono.Texts = registro[3].ToString();
            }
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
            else if (txtTelefono.Texts.Length >= 10)
            {
                // Evitar que se ingrese más de 10 caracteres
                e.Handled = true;
            }
        }
    }
}
