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
            PodologoDAO podologoDAO=new PodologoDAO();
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
        }
        public void ActualizarAntecedentesPatologicosPaciente(AntecedentesPatologicos antecedentes)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            podologoDAO.ActualizarAntecedentesPatologicosPaciente(antecedentes);
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
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la cita?\n Una vez eliminado no se podrá recuperar", "Confirmación necesario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                PodologoDAO podologoDAO = new PodologoDAO();
                podologoDAO.EliminarCita(cita);
            }
            return;
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
            if (puesto == "Puesto")
            {
                MessageBox.Show("Seleccione un puesto valido para continuar");
                return false;
            }
            if (string.IsNullOrEmpty(usuario.GetUsuario()))
            {
                MessageBox.Show("Usuario invalido");
                return false;
            }
            if (string.IsNullOrEmpty(usuario.GetContraseña()))
            {
                MessageBox.Show("Contraseña invalida");
                return false;
            }
            if (string.IsNullOrEmpty(comprobarContraseña))
            {
                MessageBox.Show("Compruebe la contraseña para continuar");
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
                MessageBox.Show("Las contraseña no coinciden");
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
                MessageBox.Show("El nombre no es valido");
                return false;
            }
            if (string.IsNullOrEmpty(profesionista.GetApellidoPaterno()))
            {
                MessageBox.Show("El Apellido Paterno no es valido");
                return false;
            }
            if (string.IsNullOrEmpty(profesionista.GetApellidoMaterno()))
            {
                MessageBox.Show("El Apellido Materno no es valido");
                return false;
            }
            if (string.IsNullOrEmpty(profesionista.GetTelefono()))
            {
                MessageBox.Show("El Teléfono no es valido");
                return false;
            }
            return true;
        }


        private bool ValidarCampoTipoCitaVacio(string TipoCita)
        {
            if (string.IsNullOrEmpty(TipoCita))
            {
                MessageBox.Show("Agregue un 'Tipo de Cita' para continuar");
                return false;

            }
            return true;
        }
        
        private bool ValidarHoras(string horas)
        {
            if (string.IsNullOrEmpty(horas))
            {
                MessageBox.Show("No es posible agregar elementos vacios");
                return false;
            }
            if (!horas.Contains(":")) 
            {
                MessageBox.Show("Formato de Hora invalido, es necesario agregar ':' entre las horas y los minutos");
                return false; 
            }
            if(horas.Length<4 || horas.Length > 5)
            {
                MessageBox.Show("Formato invalido, la hora ingresada no cuenta con el formato correcto");
                return false;
            }
            if (!ValidarFormatoHoras(horas))
            {
                MessageBox.Show("Formato invalido, la hora ingresada no cuenta con el formato correcto");
                return false;
            }
            return true;
        }


        public bool ValidarFormatoHoras(string horas)
        {
            return DateTime.TryParse(horas, out _);

        }
    }
}
