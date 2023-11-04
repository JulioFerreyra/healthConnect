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
                MessageBox.Show("Nombre no valido\n Por favor verifique el campo NOMBRE e intentar nuevamente", "Nombre no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoPaterno()))
            {
                MessageBox.Show("Apellido Paterno no valido\n Por favor verifique el campo APELLIDO PATERNO e intentar nuevamente", "Apellido Paterno no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoMaterno()))
            {
                MessageBox.Show("Apellido Materno no valido\n Por favor verifique el campo APELLIDO MATERNO e intentar nuevamente", "Apellido Materno no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetTelefono()) || paciente.GetTelefono().Length!=10)
            {
                MessageBox.Show("Telefono no valido\n Por favor verifique el campo TELÉFONO e intentar nuevamente", "Teléfono no valido");
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetDireccion()))
            {
                MessageBox.Show("Dirección no valida\n Por favor verifique el campo DIRECCIÓN e intentar nuevamente", "Dirección no valido");
                return false;
            }
            if (paciente.GetSexo() == null || paciente.GetSexo() == "S")
            {
                MessageBox.Show("Sexo seleccionado no valido\n Por favor verifique el campo SEXO e intentar nuevamente", "Sexo no valido");
                return false;
            }
            if (paciente.GetFechaNacimiento().DayOfYear >= DateTime.Now.DayOfYear)
            {
                MessageBox.Show("Fecha de Nacimiento no valida\n Por favor verifique el campo FECHA DE NACIMIENTO e intentar nuevamente", "Fecha no valido");
                return false;
            }
            return true;
        }
    }
}
