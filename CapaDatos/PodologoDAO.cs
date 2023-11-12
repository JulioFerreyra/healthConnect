using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class PodologoDAO
    {
        private const string USSER = "Admin";
        private const string PASSWORD = "Admin";
        private const string HOST = "localhost";
        private const string BASE_DATOS = "healthconnect";

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="usuario"></param>
        /// 
        public void CrearProfesionista(Profesionista profesionista)
        {
            string consultaInsert = "insert into profesionistas(nombre,apell_mat, apell_pat, telefono) values(\""+profesionista.GetNombre()+"\",\""+profesionista.GetApellidoPaterno()+"\",\""+profesionista.GetApellidoMaterno()+"\",\""+profesionista.GetTelefono()+"\")";
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(consultaInsert, conexion_a_MySQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("El profesionista " + string.Concat(profesionista.GetNombre(),profesionista.GetApellidoPaterno(), profesionista.GetApellidoMaterno())+" Creado correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }
        public void CraerUsuario(Usuario usuario)
        {
            string consultaInsert = "insert into usuario(usuario,contraseña,isAdmin) values(\""+usuario.GetUsuario()+"\",\""+usuario.GetContraseña()+"\","+usuario.GetIsAdmin()+")";
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(consultaInsert, conexion_a_MySQL);
               comando.ExecuteNonQuery();
                MessageBox.Show("Usuario " +usuario.GetUsuario()+" Creado correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }


        /// <summary>
        /// Select
        /// </summary>
        /// <param name="FechaCita"></param>
        /// <param name="idPodologo"></param>
        /// <returns></returns>
        /// 
        public DataTable VerProfesionistas(string profesionistaLike)
        {
            
                DataTable datos = new DataTable();
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                string SentenciaSelect = "select id_profesionista as ID, concat(nombre, ' ', apell_pat, ' ' , apell_mat) as Profesionista, telefono as Teléfono, 'El Grullo' as Sucursal from profesionistas where nombre like '%"+profesionistaLike+ "%' or apell_pat like '%"+profesionistaLike+"%'";
                MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
                try
                {
                    conexion_a_MySQL.Open();
                    MySqlDataAdapter comando = new MySqlDataAdapter(SentenciaSelect, conexion_a_MySQL);
                    comando.Fill(datos);

                    return datos;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return datos;
                }
                finally
                {
                    conexion_a_MySQL.Close();
                }
            }
        public DataTable VerCitasPodologo(DateTime FechaCita, int idPodologo)
        {
            DataTable citas = new DataTable();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(CadenaConexion());
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select  c.id_cita as \"ID\", concat(pc.nombre,\" \",pc.apell_pat,\" \",apell_mat) as \"Paciente\",c.fecha_cita as \"Fecha\",c.hora as \"Hora\",c.tipo_cita as \"Tipo de Cita\",c.tel_contacto as \"Telefono\" from citas as c ");
            stringBuilder.Append("join paciente as pc on c.id_paciente=pc.id_paciente ");
            stringBuilder.Append("join profesionistas as pod on pod.id_profesionista = c.id_profesionista ");
            //stringBuilder.Append("join sucursal as s on s.id_sucursal = c.id_sucursal ");
            stringBuilder.Append("where pod.id_profesionista =" + idPodologo + " and c.fecha_cita =\"" + ConvertirFechaString(FechaCita) + "\" and c.estado_cita = \"pendiente\";");
            string SentenciaSelect = stringBuilder.ToString();

            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelect, conexion_a_mysql);
                adaptador.Fill(citas);
                return citas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return citas;
            }
            finally
            {
                conexion_a_mysql.Close();
            }

        }

        public DataTable VerUsuarios(string usuario)
        {

            DataTable datos = new DataTable();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string SentenciaSelect = "select id_usuario,usuario, contraseña, isAdmin from usuario where usuario like \"%"+usuario+"%\" and usuario <> 'Admin'";
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_MySQL.Open();
                MySqlDataAdapter comando = new MySqlDataAdapter(SentenciaSelect, conexion_a_MySQL);
                comando.Fill(datos);

                return datos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return datos;
            }
            finally
            {
                conexion_a_MySQL.Close();
            }

        }
        public DataTable GetDatosPaciente(int idPaciente)
        {
            DataTable datos = new DataTable();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string SentenciaSelect = "select nombre as Nombre, apell_pat as 'Apellido Paterno', apell_mat as 'Apellido Materno', telefono as Telefono,   year(now()) - year(fecha_nac) as Edad, sexo as Sexo from pacientes where id_paciente = " + idPaciente+";";
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_MySQL.Open();
                MySqlDataAdapter comando = new MySqlDataAdapter(SentenciaSelect, conexion_a_MySQL);
                comando.Fill(datos);
                
                return datos;
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
                return datos;
            }
            finally
            {
                conexion_a_MySQL .Close();
            }
        }

        public DataTable GetNombrePodologo(int idPodologo)
        {
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            string SentenciaSelect = "select concat(nombre, ' ', apell_pat, ' ', apell_mat) from profesionistas  where id_profesionista = "+idPodologo+";";
            DataTable NombrePodologo = new DataTable();
            try
            {
                conexion_a_MySQL.Open();
                MySqlDataAdapter comando = new MySqlDataAdapter(SentenciaSelect,conexion_a_MySQL);
                comando.Fill(NombrePodologo);
                return NombrePodologo;       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return NombrePodologo;
            }
            finally
            {
                conexion_a_MySQL.Close();
                
            }
        }

        public DataTable GetAntecendetesNoPatologicosPaciente(int idPaciente)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            string SentenciaSelect = "Select no.parto, no.hiperlaxitud, no.tabaco, no.frec_tab, no.alcohol, no.frec_alc, no.act_fisica, no.frec_actF,no.drogas, pat.diabetes, pat.presion_arterial, pat.tiroides, pat.hepatitis, pat.cardiopatias,pat.intervenciones,pat.neoplasia, pat.medicacion from ant_nopat no join ant_pat pat on no.id_paciente = pat.id_paciente where no.id_paciente="+idPaciente;
            DataTable antecendetesNoPat = new DataTable();
            try
            {
                conexion_a_MySQL.Open();
                MySqlDataAdapter comando = new MySqlDataAdapter(SentenciaSelect, conexion_a_MySQL);
                comando.Fill(antecendetesNoPat);
                return antecendetesNoPat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return antecendetesNoPat;
            }
            finally
            {
                conexion_a_MySQL.Close();

            }
        }

        public string GetContraseñaUsuario(int idUsuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(CadenaConexion());
            string SentenciaSelect = "select contraseña from usuario where id_usuario = " + idUsuario;
            string contraseña;
            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(SentenciaSelect,conexion_a_MySQL);
                contraseña = Convert.ToString(comando.ExecuteScalar());
                return contraseña;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
            finally
            {
                conexion_a_MySQL.Close();

            }
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="cita"></param>
        public void EliminarCita(Cita cita)
        {
            UsuarioDAO usuarioDAO =new UsuarioDAO();
            MySqlConnection conexion_a_SQL = new MySqlConnection(CadenaConexion());
            string SentenciaDelete = "delete from citas where id_cita = "+cita.GetIdCita()+";";
            try
            {
                conexion_a_SQL.Open();
                MySqlCommand commando = new MySqlCommand(SentenciaDelete,conexion_a_SQL);
                commando.ExecuteNonQuery();
                MessageBox.Show("Cita eliminada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conexion_a_SQL.Close();
            }
        }

       public void EliminarUsuario(int idUsuario)
        {
            string sentenciaDelete = "Delete from usuario where id_usuario = "+idUsuario+";";
            MySqlConnection conexion_a_SQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_SQL.Open();
                MySqlCommand commando = new MySqlCommand(sentenciaDelete, conexion_a_SQL);
                commando.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion_a_SQL.Close();
            }
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="antecedentes"></param>
        public void ActualizarDatosNoPatologicosPaciente(AntecedentesNoPatologicos antecedentes)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_SQL = new MySqlConnection(CadenaConexion());
            string sentenciaUpdate = "UPDATE ant_nopat SET parto = "+antecedentes.GetParto()+", hiperlaxitud = "+antecedentes.GetHiperlaxitud()+", tabaco = "+antecedentes.GetTabaco()+", frec_tab = "+antecedentes.GetFrecuenciaTabaco()+", alcohol = "+antecedentes.GetAlcohol()+", frec_alc = "+antecedentes.GetFrecueciaAlcohol()+", act_fisica = "+antecedentes.GetActividadFisica()+", frec_actF= "+antecedentes.GetFrecuenciaActividad()+", drogas = "+antecedentes.GetDrogas()+" WHERE id_paciente =" + antecedentes.GetIdPaciente();
            try
            {
                conexion_a_SQL.Open();
                MySqlCommand commando = new MySqlCommand(sentenciaUpdate, conexion_a_SQL);
                commando.ExecuteNonQuery();
                MessageBox.Show("Antecedentes actualizados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conexion_a_SQL.Close();
            }
        }

        public void ActualizarAntecedentesPatologicosPaciente(AntecedentesPatologicos antecedentes)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string sentenciaUpdate = "UPDATE ant_pat SET diabetes = \""+antecedentes.GetDiabetes()+"\", presion_arterial = \""+antecedentes.GetPresionArterial()+"\", tiroides = \""+antecedentes.GetTiroides()+"\", hepatitis = \""+antecedentes.GetHepatitis()+"\",cardiopatias = "+antecedentes.GetCardiopatias()+",intervenciones = \""+antecedentes.GetIntervenciones()+"\",neoplasia = "+antecedentes.GetNeoplasia()+",medicacion =\""+antecedentes.GetMedicacion()+"\" WHERE id_paciente = "+ antecedentes.GetIdPaciente();
            MySqlConnection conexion_a_SQL = new MySqlConnection(CadenaConexion());
            try
            {
                conexion_a_SQL.Open();
                MySqlCommand commando = new MySqlCommand(sentenciaUpdate, conexion_a_SQL);
                commando.ExecuteNonQuery();
                MessageBox.Show("Antecedentes actualizados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion_a_SQL.Close();
            }
        }


        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        private string ConvertirFechaString(DateTime Fecha)
        {
            return Fecha.ToString("yyyy-MM-dd");
        }

        public string CadenaConexion()
        {

            return "Server=" + HOST + ";Database=" + BASE_DATOS + ";user=" + USSER + ";password=" + PASSWORD + ";";

        }

    }
}
