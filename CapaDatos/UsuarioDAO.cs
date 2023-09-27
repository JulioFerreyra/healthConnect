using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.CodeDom;
using System.Windows.Forms;

namespace CapaDatos
{
    public class UsuarioDAO
    {
        private const string USSER = "PodologiaTello";
        private const string PASSWORD = "podologiatello2023";
        private const string BASE_DATOS = "podtello";
        private const string HOST = "localhost";

       public void ProbarConexion()
        {
            MySqlConnection conexion_a_mysql = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_mysql.Open();
                MessageBox.Show(conexion_a_mysql.State.ToString());
                conexion_a_mysql.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
       
        public Dictionary<int, string> GetUsuarios(Usuario usuario) 
        {
            Dictionary<int,string> DatosUsuario= new Dictionary<int,string>();
            string ConsultaSelect = "select id_usuario,usuario,contrasena from usuario where usuario = \""+usuario.GetUsuario()+"\";";
            MySqlConnection conexion_a_mysql = new MySqlConnection(CadenaConexion());
            MySqlCommand comando = new MySqlCommand(ConsultaSelect,conexion_a_mysql);
            try
            {
                conexion_a_mysql.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    DatosUsuario.Add(lector.GetInt32(0), lector.GetString(2));
                }
                lector.Close();
                return DatosUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion_a_mysql.Close();
            }
            return DatosUsuario;
        }

        public string CadenaConexion()
        {
        
        string cadenaConexion = "Server="+HOST+";Database="+BASE_DATOS+";user="+USSER+";password="+PASSWORD+";";
            return cadenaConexion;
        }
    }
}
