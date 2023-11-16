using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class LogicaSecretaria
    {
        /// <summary>
        /// Select
        /// </summary>
        /// <param name="fechaCita"></param>
        /// <returns></returns>
        public DataTable VerConsultasPodologo(DateTime fechaCita, int idPodologo)
        {
            SecretariaDAO SecretariaDAO = new SecretariaDAO();
            return SecretariaDAO.VerCitasPodologo(fechaCita, idPodologo);
        }
        public DataTable VerPacientes(string Nombre)
        {
            SecretariaDAO secretariaDAO=new SecretariaDAO();
            return secretariaDAO.VerPacientes(Nombre);
        }
        public DataTable GetPaciente(int idPaciente)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.GetPaciente(idPaciente);
        }
        public DataTable GetCita(int idCita)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.GetCita(idCita);
        }
        public DataTable GetHorasPodologo(DateTime FechaCita, int idPodologo)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.GetHorasPodologo(FechaCita, idPodologo);
        }
        public DataTable GetHorasTrabajo()
        {
            SecretariaDAO secretaria = new SecretariaDAO();
            return secretaria.GetHorasTrabajo();
        }
        public DataTable GetDetellesCita(Cita cita)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.GetDetallesCita(cita);
        }
        public DataTable VerHistoralPaciente(Paciente paciente)
        {
            SecretariaDAO secretariaDAO=new SecretariaDAO();
            return secretariaDAO.VerHistorialCitasPaciente(paciente);
        }

        public DataTable GetTiposDeCita()
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.GetTiposDeCita();
        }

        public DataTable GetPodologos()
        {
            SecretariaDAO secretaria=new SecretariaDAO();
            return secretaria.GetPodologos();
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="cita"></param>
        public void EliminarCita(Cita cita)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la cita?\n Una vez eliminado no se podrá recuperar", "Confirmación necesario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                SecretariaDAO secretariaDAO = new SecretariaDAO();
                secretariaDAO.EliminarCita(cita);
            }
            return;
           
        }
        
        public void EliminarPaciente(Paciente paciente)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar los registros del Paciente?\n El hacerlo eliminará consigo las citas registradas a su nombre permanentemente", "Confirmación necesario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                SecretariaDAO secretariaDAO = new SecretariaDAO();
                secretariaDAO.EliminarCitasPaciente(paciente);
                secretariaDAO.EliminarPaciente(paciente);
            }
            return;

        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="cita"></param>
        public bool CrearNuevaCita(Cita cita)
        {
            LogicaCita logicaCita = new LogicaCita();
            if (logicaCita.ValidarInsertarCamposCita(cita)==false)
            {
                return false;
            }
            SecretariaDAO SecretariaDAO = new SecretariaDAO();
            SecretariaDAO.CrearNuevaCita(cita);
            return true;
        }
        public bool CrearNuevoPaciente(Paciente paciente)
        {
            LogicaPaciente logicaPaciente = new LogicaPaciente();
            if (logicaPaciente.ValidarCamposPaciente(paciente))
            {
                SecretariaDAO secretariaDAO = new SecretariaDAO();
                secretariaDAO.CrearNuevoPaciente(paciente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="cita"></param>
        public bool EditarCita(Cita cita)
        {
            LogicaCita logicaCitaEditar = new LogicaCita();
            if (logicaCitaEditar.ValidarCamposCitaActualizar(cita)==false)
            {
                return false;
            }
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea modificar la cita?\n", "Confirmación necesaria", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                SecretariaDAO secretariaDao = new SecretariaDAO();
                secretariaDao.ActualizarCita(cita);
                return true;
            }
            return false;
        }
        public bool EditarPaciente(Paciente paciente)
        {
            LogicaPaciente logicaPaciente = new LogicaPaciente();
            if (logicaPaciente.ValidarCamposPaciente(paciente))
            {
                SecretariaDAO SecretariaDAO = new SecretariaDAO();
                SecretariaDAO.ActualizarPaciente(paciente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Finalizar Cita
        /// </summary>
        /// <param name="cita"></param>
        public void FinalizarCita(Cita cita)
        {
            LogicaCita logicaCita = new LogicaCita();
            if (logicaCita.ValidarCamposFinalizarCita(cita))
            {
                SecretariaDAO secretariaDAO = new SecretariaDAO();
                secretariaDAO.AgregarResultadoCita(cita);
            }
            return;
        }

        public DataTable ReporteTipoCitaPodologo(string tipoCita,string EstadoCita,string idPodologo)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.ReporteTipoCitaPodologo(tipoCita,EstadoCita,idPodologo);
        }
      

        public DataTable ReporteFechasPodologo(DateTime fechaInicio, DateTime fechaFinal,  string idPodologo, string EstadoCita)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            return secretariaDAO.ReporteFechasPodologo(fechaInicio,fechaFinal, idPodologo, EstadoCita);
        }

        public void SetUsser(string user)
        {
            SecretariaDAO secretaria = new SecretariaDAO();
            secretaria.SetUsser(user);
        }
        public void SetPassword(string password)
        {
            SecretariaDAO secretaria = new SecretariaDAO();
            secretaria.SetPassword(password);
        }


    }
}
