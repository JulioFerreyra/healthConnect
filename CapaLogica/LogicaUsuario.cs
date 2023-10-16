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
            if(string.IsNullOrEmpty(usuario.GetUsuario()) || string.IsNullOrEmpty(usuario.GetContraseña()))
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
        return GetExistenciaUsuario(usuario)!=0;
    }

      
    public bool GetisAdmin(Usuario usuario)
    {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            return usuarioDAO.GetisAdmin(usuario);
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
