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
    public class SecretariaDAO
    {
     
        /// <summary>
        /// Select
        /// </summary>
        /// <param name="fechaCita"></param>
        /// <returns></returns>
        public DataTable VerCitasPodologo(DateTime fechaCita, int idPodologo)
        {

            UsuarioDAO ObjUsarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(ObjUsarioDAO.CadenaConexion());
            DataTable ConsultasPodologo = new DataTable();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("select  c.id_cita as \"ID\", concat(pc.nombre,\" \",pc.apell_pat,\" \",apell_mat) as \"Paciente\",c.fecha_cita as \"Fecha\",c.hora as \"Hora\",c.tipo_cita as \"Tipo de Cita\",pc.telefono as \"Telefono\" from citas as c ");
            stringBuilder.Append("join pacientes as pc on c.id_paciente=pc.id_paciente ");
            stringBuilder.Append("join profesionistas as pod on pod.id_profesionista = c.id_profesionista ");
            //stringBuilder.Append("join sucursal as s on s.id_sucursal = c.id_sucursal ");
            stringBuilder.Append("where pod.id_profesionista =" + idPodologo+" and c.fecha_cita =\"" + ConvertirFechaCadena(fechaCita) + "\" and c.estado_cita = \"pendiente\";");

            string ConsultaSelect = stringBuilder.ToString();

            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(ConsultaSelect, conexion_a_mysql);
                dataAdapter.Fill(ConsultasPodologo);
                return ConsultasPodologo;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return ConsultasPodologo;
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        }
        public DataTable VerPacientes(string Nombre)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaSelectLike = "select id_paciente as \"ID\", nombre as Nombre, apell_pat as \"Apellido Paterno\", apell_mat as \"Apellido Materno\", telefono as Telefono from pacientes where nombre like \"%" + Nombre + "%\";";
            DataTable tablaPacientes = new DataTable();
            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelectLike, conexion_a_mysql);
                adaptador.Fill(tablaPacientes);
                return tablaPacientes;

            }
            catch (Exception)
            {

                return tablaPacientes;
            }
            finally
            {

                conexion_a_mysql.Close();

            }

        }

        public DataTable GetPodologos()
        {
            UsuarioDAO usuario = new UsuarioDAO();
            DataTable dt = new DataTable();
            string sentenciaSelect = "select id_profesionista, nombre_comp from profesionistas";
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuario.CadenaConexion());
            try {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sentenciaSelect,conexion_a_mysql);
                adaptador.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
            finally 
            {
                conexion_a_mysql.Close();
            }


        }
        public DataTable GetPaciente(int idPaciente)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            DataTable DatosPaciente = new DataTable();
            string SentenciaSelectWhere = "select nombre as \"Nombre\", apell_pat as \"Apellido Paterno\",apell_mat as \"Apellido Materno\",telefono as \"Teléfono\", direccion as Direccion,fecha_nac as \"Fecha de Nacimiento\",sexo as Sexo from pacientes where id_paciente =" + idPaciente + ";";
            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelectWhere, conexion_a_mysql);
                adaptador.Fill(DatosPaciente);
                return DatosPaciente;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return DatosPaciente;

            }
            finally
            {
                conexion_a_mysql.Close();
            }


        }
        public DataTable GetCita(int idCita)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            DataTable DatosCita = new DataTable();
            string SentenciaSelect = "select p.nombre as \"Nombre\", p.apell_pat as \"Apellido Paterno\",p.apell_mat as \"Apellido Materno\", p.telefono as \"Teléfono\", c.fecha_cita as \"Fecha\",c.hora, c.motivo_cita,c.tipo_cita, c.estado_cita, pod.nombre_comp, c.id_paciente from pacientes as p join citas as c on c.id_paciente = p.id_paciente join profesionistas as pod on c.id_profesionista = pod.id_profesionista where c.id_cita =" + idCita + ";";
            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelect, conexion_a_mysql);
                adaptador.Fill(DatosCita);
                return DatosCita;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return DatosCita;

            }
            finally
            {
                conexion_a_mysql.Close();
            }

        }
        public DataTable GetHorasPodologo(DateTime fechaCita, int idPodologo)
        {
            DataTable DatosHoras = new DataTable();
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaSelect = "select hora from citas where fecha_cita = \""+ConvertirFechaCadena(fechaCita)+"\" and id_profesionista = "+idPodologo+" order by hora;";
            try
            {
                conexion_a_MySQL.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelect,conexion_a_MySQL);
                adaptador.Fill(DatosHoras); 
                return DatosHoras;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return DatosHoras;
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }
        public DataTable GetHorasTrabajo()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();   
            DataTable DatosHoras = new DataTable();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaSelect = "select horas from horas;";
            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelect, conexion_a_mysql);
                adaptador.Fill(DatosHoras);
                return DatosHoras;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                return DatosHoras;
            }
            finally
            {
                conexion_a_mysql.Close();
            }

        }
        public DataTable GetDetallesCita(Cita cita)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            DataTable DetallesCita = new DataTable();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaSelect = "select p.nombre, p.apell_pat, p.apell_mat, p.telefono, c.detalle_cita, c.historial_cli, pod.nombre_comp, c.tipo_cita,c.hora, c.fecha_cita from citas c  join paciente p on p.id_paciente = c.id_paciente  join podologo pod on pod.id_podologo = c.id_podologo  where c.id_cita ="+cita.GetIdCita()+";";
            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelect, conexion_a_mysql);
                adaptador.Fill(DetallesCita);
                return DetallesCita;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return DetallesCita;
            }
            finally
            {
                conexion_a_mysql.Close();
            }

        }
        public DataTable VerHistorialPaciente(Paciente paciente)
        {
            DataTable HistorialPaciente = new DataTable();
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaSelectWhere = "select c.id_cita as ID, concat(pac.nombre, \" \", pac.apell_pat, \" \", pac.apell_mat) as Paciente, c.fecha_cita as Fecha, pod.nombre_comp as Podólogo, suc.nombre as Sucursal, c.tipo_cita as \"Tipo de Cita\", c.estado_cita as Estado from citas c join paciente pac on c.id_paciente = pac.id_paciente join podologo pod on pod.id_podologo=c.id_podologo join sucursal suc on suc.id_sucursal = c.id_sucursal where c.id_paciente ="+paciente.GetIdPaciente()+" and estado_cita = \"finalizada\";";
            try
            {
                conexion_a_mysql.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(SentenciaSelectWhere, conexion_a_mysql);
                adaptador.Fill(HistorialPaciente);
                return HistorialPaciente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return HistorialPaciente;
            }
            finally
            {
                conexion_a_mysql.Close() ;
            }
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="paciente"></param>
        public void CrearNuevoPaciente(Paciente paciente)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaInsert = "insert into pacientes(nombre,apell_pat,apell_mat,telefono, direccion, fecha_nac ,sexo) values(\""+paciente.GetNombre()+"\",\""+paciente.GetApellidoPaterno()+"\",\""+paciente.GetApellidoMaterno()+"\",\""+paciente.GetTelefono()+"\", \""+paciente.GetDireccion()+"\", \""+ConvertirFechaCadena(paciente.GetFechaNacimiento())+"\",\""+paciente.GetSexo()+"\");";
            try
            {
                conexion_a_mysql.Open();
                MySqlCommand comandoMysql = new MySqlCommand(SentenciaInsert,conexion_a_mysql);
                comandoMysql.ExecuteNonQuery();
                MessageBox.Show("Paciente:" + paciente.GetNombre()+" "+paciente.GetApellidoPaterno()+" "+ paciente.GetApellidoMaterno() +" añadido correctamente");

            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
               
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        }
        public void CrearNuevaCita(Cita cita)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaInsert = "insert into citas(id_paciente,fecha_cita,hora,id_profesionista,motivo_cita,tipo_cita,estado_cita) values(" + cita.GetIdPaciente() + ",\"" + ConvertirFechaCadena(cita.GetFechaCita()) + "\",\"" + cita.GetHoraCita() + "\"," + cita.GetIdPodologo() + ",\"" + cita.GetDetallesCita() + "\",\"" + cita.GetTipoCita() + "\",\"pendiente\");";
            MySqlCommand comandoMysql = new MySqlCommand(SentenciaInsert, conexion_a_mysql);

            try
            {
                conexion_a_mysql.Open();
                comandoMysql.ExecuteNonQuery();
                MessageBox.Show("Cita agendada correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion_a_mysql.Close();
            }

        }


        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="cita"></param>
        public void EliminarCita(Cita cita)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaDelete = "Delete from citas where id_cita ="+cita.GetIdCita().ToString()+";";

            try
            {
                conexion_a_mysql.Open();
                MySqlCommand comandoMysql = new MySqlCommand(SentenciaDelete,conexion_a_mysql);
                comandoMysql.ExecuteNonQuery();
                MessageBox.Show("Cita eliminada corretamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        }
        public void EliminarPaciente(Paciente paciente)
        {
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaDelete = "delete from pacientes where id_paciente = "+paciente.GetIdPaciente()+";";
            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(SentenciaDelete, conexion_a_MySQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Paciente eliminado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }
        public void EliminarCitasPaciente(Paciente paciente)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaDelete = "delete from citas where id_paciente = " + paciente.GetIdPaciente() + ";";
            try
            {
                conexion_a_MySQL.Open();
                MySqlCommand comando = new MySqlCommand(SentenciaDelete, conexion_a_MySQL);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="cita"></param>
        public void ActualizarCita(Cita cita)
        {
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaUpdate = "Update citas set id_paciente = "+cita.GetIdPaciente()+", fecha_cita=\""+ConvertirFechaCadena(cita.GetFechaCita())+"\", id_profesionista="+cita.GetIdPodologo()+", motivo_cita=\""+cita.GetDetallesCita()+"\", estado_cita =\""+cita.GetEstadoCita()+"\", hora =\""+cita.GetHoraCita()+"\" where id_cita="+cita.GetIdCita()+";";
            try
            {
                conexion_a_mysql.Open();
                MySqlCommand comando = new MySqlCommand(SentenciaUpdate, conexion_a_mysql);
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualización Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conexion_a_mysql.Close();
            }

        }
        public void ActualizarPaciente(Paciente paciente)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaUpdate = "update pacientes set nombre = \""+paciente.GetNombre()+"\", apell_pat =\""+paciente.GetApellidoPaterno()+"\", apell_mat =\""+paciente.GetApellidoMaterno()+"\", telefono = \""+paciente.GetTelefono()+"\",direccion = \""+paciente.GetDireccion()+"\", fecha_nac = \""+ConvertirFechaCadena(paciente.GetFechaNacimiento())+"\", sexo = \""+paciente.GetSexo()+"\" where id_paciente ="+paciente.GetIdPaciente()+";";
            try
            {
                conexion_a_mysql.Open();
                MySqlCommand comando = new MySqlCommand(SentenciaUpdate , conexion_a_mysql);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos del paciente: " + paciente.GetIdPaciente() + " actualizados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        
        }


        /// <summary>
        /// Finalizar Cita
        /// </summary>
        /// <param name="cita"></param>
        public void AgregarResultadoCita(Cita cita)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_mysql = new MySqlConnection(usuarioDAO.CadenaConexion());
            string SentenciaUpdate = "update citas set historial_cli = \""+cita.GetHistoriaClinica()+"\", estado_cita = \"finalizada\" where id_cita ="+cita.GetIdCita()+";";
            try
            {
                conexion_a_mysql.Open();
                MySqlCommand comando = new MySqlCommand(SentenciaUpdate,conexion_a_mysql);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cita finalizada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                return;
               
            }
            finally
            {
                conexion_a_mysql.Close();
            }
        }

        /// <summary>
        /// Reportes
        /// </summary>
        /// <param name="TipoCita"></param>
        /// <returns></returns>
        public DataTable ReporteTipoCitaPodologo(string TipoCita,string EstadoCita, string idPodologo)
        {
            DataTable datosReporte = new DataTable();
            UsuarioDAO usuarioDAO=new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(usuarioDAO.CadenaConexion());
            string sentenciaReporte = "select c.id_cita ID, concat(pc.nombre, \" \", pc.apell_pat, \" \", pc.apell_mat) Paciente,pd.nombre_comp Podólogo, c.fecha_cita Fecha, c.Tipo_cita as Tipo, c.detalle_cita Detalles, c.historial_cli Resultado from citas c join podologo pd on c.id_podologo = pd.id_podologo join paciente pc on pc.id_paciente = c.id_paciente where c.estado_cita like \"%"+EstadoCita+"%\" and c.tipo_cita = \""+TipoCita+"\" and c.id_podologo like '%"+idPodologo+"%';";
            try
            {
               // MessageBox.Show(sentenciaReporte);
                conexion_a_MySQL.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sentenciaReporte, conexion_a_MySQL);
                adaptador.Fill(datosReporte);
                return datosReporte;
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message,"Error");
                return datosReporte;
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }

        public DataTable ReporteFechasPodologo(DateTime FechaInicio, DateTime FechaFinal, string idPodologo, string EstadoCita)
        {
            DataTable datosReporte = new DataTable();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            MySqlConnection conexion_a_MySQL = new MySqlConnection(usuarioDAO.CadenaConexion());
            string sentenciaReporte = "select c.id_cita ID, concat(pc.nombre, \" \", pc.apell_pat, \" \", pc.apell_mat) Paciente,pd.nombre_comp Podólogo, c.fecha_cita Fecha, c.Tipo_cita as Tipo, c.detalle_cita Detalles, c.historial_cli Resultado from citas c join podologo pd on c.id_podologo = pd.id_podologo join paciente pc on pc.id_paciente = c.id_paciente where c.estado_cita like \"%"+EstadoCita+"%\" and c.fecha_cita between \""+ConvertirFechaCadena(FechaInicio)+"\" and \""+ConvertirFechaCadena(FechaFinal)+"\" and c.id_podologo like '%"+idPodologo+"%';";
            try
            {
             //   MessageBox.Show(sentenciaReporte);
                conexion_a_MySQL.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sentenciaReporte, conexion_a_MySQL);
                adaptador.Fill(datosReporte);
                return datosReporte;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                return datosReporte;
            }
            finally
            {
                conexion_a_MySQL.Close();
            }
        }

     



        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="fechaCita"></param>
        /// <returns></returns>
        private string ConvertirFechaCadena(DateTime fechaCita)
        {
            return fechaCita.ToString("yyyy-MM-dd");

        }


        
    }
}
