using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaLogica
{
    public class LogicaUsuario
    {
        public void ProbarConexion()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.ProbarConexion();
        }


        private bool ValidarCamposVacios(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.GetUsuario()) || string.IsNullOrEmpty(usuario.GetContraseña()))
            {
                return false;
            }
            return true;
        }

        public int GetExistenciaUsuario(Usuario usuario)
        {

            if (!ValidarCamposVacios(usuario))
            {

                return 0;

            }
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            return usuarioDAO.GetExistenciaUsuario(usuario);
        }

        public bool ValidarExistenciaUsuario(Usuario usuario)
        {
            return GetExistenciaUsuario(usuario) != 0;
        }



        public bool GetisAdmin(Usuario usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            return usuarioDAO.GetisAdmin(usuario);
        }


        private bool ValidarCamposActualizarUsuario(Usuario usuario, string confirmacionContraseña)
        {
            if (string.IsNullOrEmpty(usuario.GetUsuario()))
            {
                MessageBox.Show("Usuario vacio");
                return false;
            }

            if (string.IsNullOrEmpty(usuario.GetContraseña()))
            {
                MessageBox.Show("Contraseña vacia");
                return false;
            }

            if (string.IsNullOrEmpty(confirmacionContraseña))
            {
                MessageBox.Show("Confirme la contraseña para continuar");
                return false;
            }

            return true;
        }

        private bool GetUsuario(Usuario usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            return usuarioDAO.GetUsuario(usuario) != 0;
          
            
        }

        

        public bool ValidarContraseñaConfirmada(Usuario usuario, string confirmacionContraseña)
        {

            return usuario.GetContraseña() == confirmacionContraseña;
          

        }

        public bool ValidarActualizarContraseña(Usuario usuario, string ConfirmacionContraseña)
        {
            if (!ValidarCamposActualizarUsuario(usuario, ConfirmacionContraseña))
            {
                return false;
            }
            if (!ValidarContraseñaConfirmada(usuario,ConfirmacionContraseña))
            {
                MessageBox.Show("La contraseña no coincide");
                return false;
            }
            if (!GetUsuario(usuario))
            {
                MessageBox.Show("El usuario que desea actualizar no existe");
                return false;
            }
            return true;
        }
        public void ActualizarContraseña(Usuario usuario)
        {
           
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                usuarioDAO.ActualizarContraseñaUsuario(usuario);
        }

        public bool ValidarContraseñaAdmin(string contraseña)
        {
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            return usuarioDAO.ValidarExistenciaContraseñaAdmin(contraseña) != 0;

        }

        public bool ValidarCampoAdminVacio(string ContraseñaAdmin)
        {
            if (string.IsNullOrEmpty(ContraseñaAdmin))
            {
                MessageBox.Show("Ingrese una contraseña de administrador para continuar");
                return false;

            }
            return true;
        }

        public void ActualizarContraseñaUsuarioMysql(Usuario usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.ActualizarContraseñaUsuarioMysql(usuario);
        }


        //private void GetDatosUsuario(Usuario usuario)
        //{
        //    if (ValidarCamposVacios(usuario))
        //    {
        //        UsuarioDAO usuarioDAO=new UsuarioDAO();
        //        ElementosGlobales.DiccionarioUsuarios = usuarioDAO.GetUsuarios(usuario);
        //    }

        //}

        //private bool ValidarContraseña(Usuario usuario)
        //{
        //    try
        //    {
        //        GetDatosUsuario(usuario);
        //        if (ElementosGlobales.DiccionarioUsuarios.Values.ElementAt(0) == usuario.GetContraseña())
        //        {
        //            return true;                  
        //        }
        //    }
        //    catch (Exception)
        //    {


        //    }
        //    MessageBox.Show("Usuario o Contraseña Invalidos");
        //    return false;
        //}

        //public int InciarSesion(Usuario usuario)
        //{
        //    if (ValidarContraseña(usuario))
        //    {

        //       return ElementosGlobales.DiccionarioUsuarios.Keys.ElementAt(0);
        //    }
        //    return 0;
        //}


    }

}
