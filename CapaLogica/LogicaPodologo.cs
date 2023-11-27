using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class LogicaPodologo
    {

        /// <summary>
        /// CREATE
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="puesto"></param>
        /// <param name="comprobarContraseña"></param>
        public bool CraerUsuario(Usuario usuario, string puesto, string comprobarContraseña)
        {
            if (ValidacionCrearUsuario(usuario, puesto, comprobarContraseña))
            {
                LogicaUsuario logicaUsuario = new LogicaUsuario();
                PodologoDAO podologodao = new PodologoDAO();
                podologodao.CraerUsuario(usuario);
                logicaUsuario.CrearUsuarioMysql(usuario);
                return true;
            }
            return false;

        }
        public bool CrearProfesionista(Profesionista profesionista)
        {
            if (ValidarCamposCrearProfesionistaVacios(profesionista))
            {
                PodologoDAO podologodao = new PodologoDAO();
                podologodao.CrearProfesionista(profesionista);
                return true;
            }
            return false;

        }
        public void CrearTiposCita(string tiposCita)
        {
            if (ValidarCampoTipoCitaVacio(tiposCita))
            {

                PodologoDAO podologoDAO = new PodologoDAO();
                podologoDAO.CrearTiposCita(tiposCita);
                // MessageBox.Show("Los 'Tipos de Citas' se han registrado correctamentn");
            }

        }
        public void CrearHoras(string horas)
        {
            if (ValidarHoras(horas))
            {
                PodologoDAO podologoDAO = new PodologoDAO();
                podologoDAO.CrearHoras(horas);
            }

        }


        /// <summary>
        /// READ
        /// </summary>
        /// <param name="FechaCita"></param>
        /// <param name="idPodologo"></param>
        /// <returns></returns>
        public DataTable VerCitasPodologo(DateTime FechaCita, int idPodologo)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.VerCitasPodologo(FechaCita, idPodologo);


        }
        public DataTable GetDiagnosticosCitasPaciente(int idPaciente)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetDiagnosticosCitasPaciente(idPaciente);
        }
        public DataTable GetPodologos()
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetPodologos();
        }
        public DataTable GetNombrePodologo(int idPodologo)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetNombrePodologo(idPodologo);
        }
        public DataTable VerProfesionistas(string profesionistaLike)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.VerProfesionistas(profesionistaLike);
        }
        public DataTable GetDatosPaciente(int idPaciente)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetDatosPaciente(idPaciente);
        }
        public DataTable GetAntecendetesNoPatologicosPaciente(int idPaciente)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetAntecendetesNoPatologicosPaciente(idPaciente);
        }
        public DataTable VerUsuarios(string usuario)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.VerUsuarios(usuario);
        }
        public string GetContraseñaUsuario(int idUsuario)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.GetContraseñaUsuario(idUsuario);
        }
        public DataTable GetDatosProfesionista(int idPofesionista)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.GetDatosProfesionista(idPofesionista);
        }
        public DataTable VerLogs()
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.VerLogs();
        }
        public DataTable GetTiposDeCita()
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetTiposDeCita();
        }
        public DataTable GetHoras()
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.GetHoras();
        }

        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="antecedentes"></param>
        public void ActualizarDatosNoPatologicosPaciente(AntecedentesNoPatologicos antecedentes)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.ActualizarDatosNoPatologicosPaciente(antecedentes);
            podologoDAO.ActualizarDatosNoPatologicosPacienteRemoto(antecedentes);
        }
        public void ActualizarAntecedentesPatologicosPaciente(AntecedentesPatologicos antecedentes)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.ActualizarAntecedentesPatologicosPaciente(antecedentes);
            podologoDAO.ActualizarAntecedentesPatologicosPacienteRemoto(antecedentes);
        }
        public bool ActualizarDatosProfesionista(Profesionista profesionista)
        {
            if (ValidarCamposCrearProfesionistaVacios(profesionista))
            {
                PodologoDAO podologoDAO = new PodologoDAO();
                podologoDAO.ActualizarDatosProfesionista(profesionista);
                return true;
            }
            return false;

        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="cita"></param>
        public void EliminarCita(Cita cita)
        {

            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.EliminarCita(cita);

        }
        public void EliminarUsuario(int idUsuario)
        {

            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.EliminarUsuario(idUsuario);



        }
        public void EliminarProfesionista(int idProfesionista)
        {
            PodologoDAO podologodao = new PodologoDAO();
            podologodao.EliminarProfesionista(idProfesionista);
        }

        public void EliminarTiposCita()
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.EliminarTiposCita();
        }

        public void EliminarHoras()
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.EliminarHoras();
        }

        /// <summary>
        /// Crear usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// 
        private bool ValidarCamposCrearUsuario(Usuario usuario, string puesto, string comprobarContraseña)
        {
            if (string.IsNullOrEmpty(usuario.GetUsuario()))
            {
                MessageBox.Show("Ingrese el usuario para continuar", "Usuario invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(usuario.GetContraseña()))
            {
                MessageBox.Show("Ingrese una contraseña para continuar", "Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (usuario.GetContraseña().Length != 8)
            {
                MessageBox.Show("La contraseña debe contener 8 (ocho) caractéres", "Confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(comprobarContraseña))
            {
                MessageBox.Show("Confirme la contraseña para continuar", "Confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (puesto == "Puesto")
            {
                MessageBox.Show("Seleccione un puesto para continuar", "Puesto invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
           

            return true;
        }
        private bool ValidacionCrearUsuario(Usuario usuario, string puesto, string comprobarContraseña)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (!ValidarCamposCrearUsuario(usuario, puesto, comprobarContraseña))
            {
                return false;
            }
            if (!logicaUsuario.ValidarContraseñaConfirmada(usuario, comprobarContraseña))
            {
                MessageBox.Show("Las contraseñas no coinciden", "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }


        /// <summary>
        /// Crear Profesionista
        /// </summary>
        /// <param name="profesionista"></param>
        /// 
        private bool ValidarCamposCrearProfesionistaVacios(Profesionista profesionista)
        {
            if (string.IsNullOrEmpty(profesionista.GetNombre()))
            {
                MessageBox.Show("Ingrese el nombre del profesionista para continuar", "Nombre invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(profesionista.GetApellidoPaterno()))
            {
                MessageBox.Show("Ingrese el apellido paterno del profesionista para continuar", "Apellido Paterno invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(profesionista.GetApellidoMaterno()))
            {
                MessageBox.Show("Ingrese el apellido materno del profesionista para continuar", "Apellido Materno invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(profesionista.GetTelefono()))
            {
                MessageBox.Show("Ingrese el apellido materno del profesionista para continuar", "Teléfono invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (profesionista.GetTelefono().Length < 10)
            {
                MessageBox.Show("El número de teléfono debe contener 10 caractéres", "Teléfono invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private bool ValidarCampoTipoCitaVacio(string TipoCita)
        {
            if (string.IsNullOrEmpty(TipoCita))
            {
                MessageBox.Show("Ingrese un 'Tipo de Cita' para continuar", "Tipo de cita invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }

        private bool ValidarHoras(string horas)
        {
            if (string.IsNullOrEmpty(horas))
            {
                MessageBox.Show("Ingrese una hora para continuar", "Hora invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (horas.Length < 4 || horas.Length > 5)
            {
                MessageBox.Show("La hora ingresada: " + horas + " no cuenta con el formato correcto", "Formato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!horas.Contains(":"))
            {
                MessageBox.Show("Formato de Hora invalido, es necesario agregar ':' entre las horas y los minutos", "Formato de hora invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
            if (!ValidarFormatoHoras(horas))
            {
                MessageBox.Show("La hora ingresada: " + horas + " no cuenta con el formato correcto", "Formato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        public bool ValidarFormatoHoras(string horas)
        {
            return DateTime.TryParse(horas, out _);

        }


        //Reportes


        public DataTable ReportesCitasTipoCita(int idPodologo, string tipoCita)
        {

            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.ReportesCitasTipoCita(idPodologo, tipoCita);

        }

        public DataTable ReportesTipoCita(string tipoCita)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.ReportesTipoCita(tipoCita);
        }

        public DataTable ReportesCitasFechas(int idPodologo, DateTime fechaInicio, DateTime fechaFin)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.ReportesCitasFechas(idPodologo, fechaInicio, fechaFin);
        }

        public DataTable ReporteFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.ReporteFechas(fechaInicio, fechaFin);
        }


        /// <summary>
        /// Remoto
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DataTable VerUsuariosRemoto(string usuario)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.VerUsuariosRemoto(usuario);
        }

        //Profesionista
        public DataTable VerProfesionistasRemoto(string profesionistaLike)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.VerProfesionistasRemoto(profesionistaLike);
        }
        public bool CrearProfesionistaRemoto(Profesionista profesionista)
        {
            if (ValidarCamposCrearProfesionistaVacios(profesionista))
            {
                PodologoDAO podologodao = new PodologoDAO();
                podologodao.CrearProfesionistaRemoto(profesionista);
                return true;
            }
            return false;


        }
        public DataTable GetDiagnosticosCitasPacienteRemoto(int idPaciente)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.GetDiagnosticosCitasPacienteRemoto(idPaciente);
        }

        public string GetContraseñaUsuarioRemoto(int idUsuario)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.GetContraseñaUsuarioRemoto(idUsuario);
        }

        public void EliminarProfesionistaRemoto(int idProfesionista)
        {
            PodologoDAO podologodao = new PodologoDAO();
            podologodao.EliminarProfesionistaRemoto(idProfesionista);
        }

        public bool ActualizarDatosProfesionistaRemoto(Profesionista profesionista)
        {
            if (ValidarCamposCrearProfesionistaVacios(profesionista))
            {
                PodologoDAO podologodao = new PodologoDAO();
                podologodao.ActualizarDatosProfesionistaRemoto(profesionista);
                return true;
            }
            return false;
        }

        public bool CraerUsuarioRemoto(Usuario usuario, string puesto, string comprobarContraseña)
        {
            if (ValidacionCrearUsuario(usuario, puesto, comprobarContraseña))
            {
                LogicaUsuario logicaUsuario = new LogicaUsuario();
                PodologoDAO podologodao = new PodologoDAO();
                podologodao.CraerUsuarioRemoto(usuario);
                logicaUsuario.CrearUsuarioMysqlRemoto(usuario);
                return true;
            }
            return false;
        }

        public void EliminarUsuarioRemoto(int idUsuario)
        {
            PodologoDAO podologodao = new PodologoDAO();
            podologodao.EliminarUsuarioRemoto(idUsuario);
        }
    }
   
}
