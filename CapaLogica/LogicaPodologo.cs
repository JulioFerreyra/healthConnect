using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class LogicaPodologo
    {

     

        /// <summary>
        /// Select
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

        public DataTable VerUsuarios(string usuario)
        {
            PodologoDAO podologoDAO= new PodologoDAO();
            return podologoDAO.VerUsuarios(usuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
           
                PodologoDAO podologoDAO = new PodologoDAO();
                podologoDAO.EliminarUsuario(idUsuario);
          

            
        }

        public string GetContraseñaUsuario(int idUsuario)
        {
            PodologoDAO podologodao = new PodologoDAO();
            return podologodao.GetContraseñaUsuario(idUsuario);
        }


        /// <summary>
        /// Crear usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// 
        
        private bool ValidarCamposCrearUsuario(Usuario usuario, string puesto,string comprobarContraseña)
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

        public bool ValidacionCrearUsuario(Usuario usuario, string puesto, string comprobarContraseña)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (!ValidarCamposCrearUsuario(usuario,puesto,comprobarContraseña))
            {
                return false;
            }
            if (!logicaUsuario.ValidarContraseñaConfirmada(usuario,comprobarContraseña))
            {
                MessageBox.Show("Las contraseña no coinciden");
                return false;
                
            }
            return true;
        }
        public void CraerUsuario(Usuario usuario, string puesto, string comprobarContraseña)
        {
            if (ValidacionCrearUsuario(usuario,puesto,comprobarContraseña))
            {
                LogicaUsuario logicaUsuario = new LogicaUsuario();
                PodologoDAO podologodao = new PodologoDAO();
                podologodao.CraerUsuario(usuario);
                logicaUsuario.CrearUsuarioMysql(usuario);
            }
        }
    }
}


