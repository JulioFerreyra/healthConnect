using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class LogicaCita
    {
        public bool ValidarInsertarCamposCita(Cita cita)
        {
            if(cita.GetIdPaciente() == 0)
            {
                MessageBox.Show("Seleccione un paciente para continuar","Paciente no seleccionado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (cita.GetIdPodologo() < 1)
            {
                MessageBox.Show("Seleccione un profesionista para continuar", "Profesionista no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
            if (cita.GetFechaCita().DayOfYear < DateTime.Today.DayOfYear)
            {
                MessageBox.Show("No es posible registrar citas para días anteriores a hoy: " + DateTime.Today.ToString("dd-MM-yyyy"), "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cita.GetHoraCita() == "Hora")
            {
                MessageBox.Show("Seleccione una Hora para continuar","Hora Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (DateTime.Parse(cita.GetHoraCita()).TimeOfDay < DateTime.Parse(DateTime.Now.ToString("HH:mm")).TimeOfDay && cita.GetFechaCita().DayOfYear <= DateTime.Today.DayOfYear)
            {
                MessageBox.Show("La hora seleccionada " + cita.GetHoraCita() + " debe ser mayor a la hora actual","Hora invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (cita.GetTipoCita() == "Tipo de cita")
            {
                MessageBox.Show("Seleccione un \"Tipo de cita\" para continuar", "Tipo de cita invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cita.GetDetallesCita()))
            {
                MessageBox.Show("Ingrese los sintomas para continuar","Sintomas invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           

            return true;
        }
        public bool ValidarCamposCitaActualizar(Cita cita)
        {
            if (DateTime.Today.DayOfYear > cita.GetFechaCita().DayOfYear)
            {
                MessageBox.Show("No es posible registrar citas para días anteriores a hoy: " + DateTime.Today.ToString("dd-MM-yyyy"), "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            if (cita.GetHoraCita() == "Hora")
            {
                MessageBox.Show("Seleccione una Hora para continuar", "Hora Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (DateTime.Parse(cita.GetHoraCita()).TimeOfDay < DateTime.Parse(DateTime.Now.ToString("HH:mm")).TimeOfDay && cita.GetFechaCita().DayOfYear < DateTime.Today.DayOfYear)
            {
                MessageBox.Show("La hora seleccionada " + cita.GetHoraCita() + " debe ser mayor a la hora actual", "Hora invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
           
            if (cita.GetTipoCita() == "Tipo de cita")
            {
                MessageBox.Show("Seleccione un paciente para continuar", "Paciente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cita.GetDetallesCita()))
            {
                MessageBox.Show("Ingrese los sintomas para continuar", "Sintomas invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cita.GetEstadoCita()== "Estado de la cita")
            {
                MessageBox.Show("Seleccione un Estado para continuar","Estado invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }
        public bool ValidarCamposFinalizarCita(Cita cita)
        {
            if (string.IsNullOrEmpty(cita.GetHistoriaClinica()))
            {
                MessageBox.Show("Agregue un diagnóstico para finalizar la cita","Diagnostica invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
