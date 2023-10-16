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


        public int SetIdUsuario(int idUsuario)
        {
            return this.idUsuario = idUsuario;
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
        public int getIdUsuario()
        {
            return idUsuario;
        }
    }
   

}
