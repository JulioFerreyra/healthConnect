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

        public void GrantAccessAdministrador(string UsuarioAdministrador)
        {
            UsuarioDAO usuario = new UsuarioDAO();
            usuario.GrantAccessAdministrador(UsuarioAdministrador);
        }

        public void GrantAccessSecreataria(string usuarioSecretaria)
        {
            UsuarioDAO usuario = new UsuarioDAO();
            usuario.GrantAccessSecretaria(usuarioSecretaria);
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
                MessageBox.Show("Ingrese un usuario para continuar","Usuario invalido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(usuario.GetContraseña()))
            {
                MessageBox.Show("Ingrese la contraseña para continuar", "Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (usuario.GetContraseña().Length != 0)
            {
                MessageBox.Show("La contraseña debe contener 8 carácteres", "Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(confirmacionContraseña))
            {
                MessageBox.Show("Confirme la contraseña para continuar", "Confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Las contraseña no coinciden", "Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!GetUsuario(usuario))
            {
                MessageBox.Show("Usuario no existente", "Usuario invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ingrese una contraseña de administrador para continuar","Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }

        public void ActualizarContraseñaUsuarioMysql(Usuario usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.ActualizarContraseñaUsuarioMysql(usuario);
        }

        public void EliminarUsuarioMysql(string usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.EliminarUsuarioMysql(usuario);
        }

        public void CrearUsuarioMysql(Usuario usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.CrearUsuarioMysql(usuario);

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

        public void EliminarUsuarioMysqlRemoto(string usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.EliminarUsuarioMysqlRemoto(usuario);
        }

        public void CrearUsuarioMysqlRemoto(Usuario usuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.CrearUsuarioMysqlRemoto(usuario);
        }

        public void GrantAccessSecretariaRemoto(string usuarioSecretaria)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.GrantAccessSecretariaRemoto(usuarioSecretaria);
        }

        public void GrantAccessAdministradorRemoto(string UsuarioAdministrador)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.GrantAccessAdministradorRemoto(UsuarioAdministrador);
        }
    }


}
