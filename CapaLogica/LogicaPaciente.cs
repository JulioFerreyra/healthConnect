using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    internal class LogicaPaciente
    {
        public bool ValidarCamposPaciente(Paciente paciente)
        {
            if (string.IsNullOrEmpty(paciente.GetNombre()))
            {
                MessageBox.Show("Nombre del paciente vacio", "Nombre no valido",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoPaterno()))
            {
                MessageBox.Show("Apellido Paterno del vacio", "Apellido Paterno no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoMaterno()))
            {
                MessageBox.Show("Apellido Materno del paciente vacio", "Apellido Materno no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetTelefono()) || paciente.GetTelefono().Length!=10)
            {
                MessageBox.Show("Teléfono del paciente vacio", "Teléfono no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetDireccion()))
            {
                MessageBox.Show("Dirección del paciente vacia", "Dirección no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (paciente.GetSexo() == null || paciente.GetSexo() == "S")
            {
                MessageBox.Show("Seleccione el Sexo del paciente para continuar", "Sexo no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning        );
                return false;
            }
            if (paciente.GetFechaNacimiento().DayOfYear >= DateTime.Now.DayOfYear)
            {
                MessageBox.Show("La fecha de nacimiento seleccionada "+paciente.GetFechaNacimiento().ToString("dd-MM-yyyy")+" es mayor a la fecha actual: " +DateTime.Now.ToString("dd-MM-yyyy"), "Fecha de nacimiento inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
