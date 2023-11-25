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
                MessageBox.Show("Ingrese el nombre del paciente para continuar", "Nombre no valido",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoPaterno()))
            {
                MessageBox.Show("Ingrese el apellido paterno del paciente para continuar", "Apellido Paterno no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetApellidoMaterno()))
            {
                MessageBox.Show("Ingrese el apellido materno del paciente para continuar", "Apellido Materno no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetTelefono()) || paciente.GetTelefono().Length!=10)
            {
                MessageBox.Show("Ingrese el número de teléfono del paciente para continuar", "Teléfono no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.GetDireccion()))
            {
                MessageBox.Show("Ingrese la dirección o domicilio del paciente para continuar", "Dirección no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (paciente.GetFechaNacimiento().DayOfYear >= DateTime.Now.DayOfYear)
            {
                MessageBox.Show("La fecha de nacimiento seleccionada " + paciente.GetFechaNacimiento().ToString("dd-MM-yyyy") + " es mayor a la fecha actual: " + DateTime.Now.ToString("dd-MM-yyyy"), "Fecha de nacimiento inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (paciente.GetSexo() == null || paciente.GetSexo() == "S")
            {
                MessageBox.Show("Seleccione el Sexo del paciente para continuar", "Sexo no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning        );
                return false;
            }
           
            return true;
        }
    }
}
