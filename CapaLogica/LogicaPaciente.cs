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
                MessageBox.Show("Nombre no valido\n Por favor verificar el campo NOMBRE e intentar nuevamente", "Nombre no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoPaterno()))
            {
                MessageBox.Show("Apellido Paterno no valido\n Por favor verificar el campo APELLIDO PATERNO e intentar nuevamente", "Apellido Paterno no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoMaterno()))
            {
                MessageBox.Show("Apellido Materno no valido\n Por favor verificar el campo APELLIDO MATERNO e intentar nuevamente", "Apellido Materno no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetTelefono()) || paciente.GetTelefono().Length!=10)
            {
                MessageBox.Show("Telefono no valido\n Por favor verificar el campo TELEFONO e intentar nuevamente", "Telefono no valido");
                return false;
            }
            return true;
        }
    }
}
