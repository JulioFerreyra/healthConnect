using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{ 
    public class UsuarioDAO
    {
        private const string USSER = "Admin";
        private const string PASSWORD = "Admin";
        private const string BASE_DATOS = "healthconnect";
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
       
        /// <summary>
        /// SElECT
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
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

        public int GetExistenciaUsuario(Usuario usuario)
        {
            string consultaSelect = "select id_usuario from usuario where usuario = \""+usuario.GetUsuario()+"\" and contraseña = \""+usuario.GetContraseña()+"\"";
            
            MySqlConnection conexion_a_mysql = new MySqlConnection(CadenaConexion());
            try 
            {
                object resultado;
                conexion_a_mysql.Open();    
                MySqlCommand comando = new MySqlCommand(consultaSelect, conexion_a_mysql);
                resultado = comando.ExecuteScalar();
                int id = Convert.ToInt32(resultado);
                return id;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        }

        public int GetUsuario(Usuario usuario)
        {
            string consultaSelect = "select id_usuario from usuario where usuario = \"" + usuario.GetUsuario()+"\"";

            MySqlConnection conexion_a_mysql = new MySqlConnection(CadenaConexion());
            try
            {
                object resultado;
                conexion_a_mysql.Open();
                MySqlCommand comando = new MySqlCommand(consultaSelect, conexion_a_mysql);
                resultado = comando.ExecuteScalar();
                int id = Convert.ToInt32(resultado);
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        }

        public bool GetisAdmin(Usuario usuario)
        {
            string consultaSelect = "select isAdmin from usuario where id_usuario =" + usuario.GetIdUsuario();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());

            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(consultaSelect,conexion_a_MySQL);
                object resultado = comando.ExecuteScalar();
                bool isAdmin = Convert.ToBoolean(resultado);
                return isAdmin;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
                
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        public void ActualizarContraseñaCita(Usuario usuario)
        {
            string consultaUpdate = "update usuario set contraseña = \""+ usuario.GetContraseña()+"\" where usuario = \""+usuario.GetUsuario()+"\"";
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(consultaUpdate,conexion_a_MySQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Contraseña actualizada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }

        public string CadenaConexion()
        {
        
        string cadenaConexion = "Server="+HOST+";Database="+BASE_DATOS+";user="+USSER+";password="+PASSWORD+";";
            return cadenaConexion;
        }
    }
}
