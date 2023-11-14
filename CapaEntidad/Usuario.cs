using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
       /// <summary>
       /// Atributos
       /// </summary>

        private int idUsuario { get; set; }
        private string usuario { get; set; }
        private string contraseña { get; set;}
        private bool isAdmin;


        ///
        ///<summary>
        ///Constructores
        ///</summary>
        ///

        public Usuario(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        public Usuario(string usuario, string contraseña, bool isAdmin)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.isAdmin = isAdmin;
        }

        public void SetIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        
        public string GetContraseña()
        {
            return contraseña;
        }

        public string GetUsuario() {
            return usuario;
        }
        public int GetIdUsuario()
        {
            return idUsuario;
        }
        public bool GetIsAdmin()
        {
            return isAdmin;
        }
    }
   

}
