using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class LogicaCita
    {
        public bool ValidarInsertarCamposCita(Cita cita)
        {
            if(ElementosGlobales.idPacienteGlobal == 0)
            {
                MessageBox.Show("Seleccione un paciente para continuar");
                return false;
            }
            if (cita.GetIdPodologo() < 1)
            {
                MessageBox.Show("Seleccione un podólogo para continuar");
                return false;
            }
            if (cita.GetTipoCita() == "Tipo de cita")
            {
                MessageBox.Show("El \"Tipo de cita\" seleccionado no es valido");
                return false;
            }
            if (cita.GetHoraCita() == "Hora")
            {
                MessageBox.Show("la Hora seleccionada no es valida");

                return false;
            }
            if (string.IsNullOrEmpty(cita.GetDetallesCita()))
            {
                MessageBox.Show("El campo \"Sintomas\" contiene un valor no valido");
                return false;
            }
          
            return true;
        }
        public bool ValidarCamposCitaActualizar(Cita cita)
        {
           
            if (cita.GetTipoCita() == "Tipo de cita")
            {
                MessageBox.Show("El \"Tipo de cita\" seleccionado no es valido");
                return false;
            }
            if (cita.GetHoraCita() == "Hora")
            {
                MessageBox.Show("la Hora seleccionada no es valida");

                return false;
            }
            if (string.IsNullOrEmpty(cita.GetDetallesCita()))
            {
                MessageBox.Show("El campo \"Sintomas\" contiene un valor no valido");
                return false;
            }
            if (cita.GetEstadoCita()== "Estado de la cita")
            {
                MessageBox.Show("El campo \"Estado de la Cita\" contiene un valor no valido");
                return false;
            }
            return true;
        }
        public bool ValidarCamposFinalizarCita(Cita cita)
        {
            if (string.IsNullOrEmpty(cita.GetHistoriaClinica()))
            {
                MessageBox.Show("Por favor ingrese un resultado valido para finalizar.");
                return false;
            }
            return true;
        }
    }
}
