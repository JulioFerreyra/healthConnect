using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class UsuariosForm : Form
    {
        public static bool permitirVisualizar = false;
        public UsuariosForm()
        {
            InitializeComponent();
        }
        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            RellenarGridProfesionistas("");
            
            RellenarDataGridUsuarios();
            AgregarColumnasDataGrid();
            
        }


        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuarioForm nuevoUsuarioForm = new NuevoUsuarioForm();
            nuevoUsuarioForm.ShowDialog();
            RellenarDataGridUsuarios();

        }
        private void btnAgregarProfesionsitas_Click(object sender, EventArgs e)
        {
            NuevoProfesionistaForm agregarProfesionistaForm = new NuevoProfesionistaForm();
            agregarProfesionistaForm.ShowDialog();
            RellenarGridProfesionistas("");
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsuarios.Columns[e.ColumnIndex].Name == "EliminarCol")
            {
                try
                {
                    int FilaSeleccionada = dgUsuarios.Rows.IndexOf(dgUsuarios.Rows[e.RowIndex]);


                    ComprobarContraseñaForm comprobarContraseñaForm = new ComprobarContraseñaForm();
                    comprobarContraseñaForm.ShowDialog();
                    EliminarUsuario(FilaSeleccionada);
                    RellenarDataGridUsuarios();
                    permitirVisualizar = false;
                }
                catch (Exception)
                {


                }

            }
            if (dgUsuarios.Columns[e.ColumnIndex].Name == "VerContraseñaCol")
            {
                try
                {

                    int FilaSeleccionada = dgUsuarios.Rows.IndexOf(dgUsuarios.Rows[e.RowIndex]);
                    ComprobarContraseñaForm comprobarContraseñaForm = new ComprobarContraseñaForm();
                    comprobarContraseñaForm.ShowDialog();

                    VisualizarContraseña(FilaSeleccionada);
                    permitirVisualizar = false;


                }
                catch (Exception)
                {


                }

            }
        }
        private void dgProfesionistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProfesionistas.Columns[e.ColumnIndex].Name == "EliminarCol")
            {
                try
                {
                    int FilaSeleccionada = dgProfesionistas.Rows.IndexOf(dgProfesionistas.Rows[e.RowIndex]);


                    ComprobarContraseñaForm comprobarContraseñaForm = new ComprobarContraseñaForm();
                    comprobarContraseñaForm.ShowDialog();
                    EliminarProfesionista(FilaSeleccionada);
                    
                    RellenarGridProfesionistas("");
                    
                }
                catch (Exception)
                {


                }

            }
            if (dgProfesionistas.Columns[e.ColumnIndex].Name == "EditarCol")
            {
                try
                {

                    int FilaSeleccionada = dgProfesionistas.Rows.IndexOf(dgProfesionistas.Rows[e.RowIndex]);
                    ElementosGlobales.PodologoGlobal = Convert.ToInt32(dgProfesionistas.Rows[FilaSeleccionada].Cells["ID"].Value);
                    
                    EditarProfesionistaForm editarProfesionsitaForm = new EditarProfesionistaForm(Convert.ToString(dgProfesionistas.Rows[FilaSeleccionada].Cells["Sucursal"].Value));
                    editarProfesionsitaForm.ShowDialog();
                    RellenarGridProfesionistas("");
                    permitirVisualizar = false;


                }
                catch (Exception)
                {


                }

            }
        }
        /// <summary>
        /// Metodos
        /// </summary>
        private void RellenarGridUsuarios(string usuario)
        {
            dgUsuarios.Rows.Clear();
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow dataRow in logicaPodologo.VerUsuarios(usuario).Rows)
            {
                dgUsuarios.Rows.Insert(0, Convert.ToString(dataRow[0]), Convert.ToString(dataRow[1]), Convert.ToBoolean(dataRow[3]) ? "Adminstrador" : "Secretaria", "El Grullo");
            }
        }
        private void RellenarGridProfesionistas(string profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            DataTable profesionistas = logicaPodologo.VerProfesionistas(profesionista);
            profesionistas.Merge(logicaPodologo.VerProfesionistasRemoto(profesionista));
            dgProfesionistas.DataSource = profesionistas;
        }

       private void VisualizarContraseña(int fila)
        {
            
           
            LogicaPodologo logica = new LogicaPodologo();
            if (permitirVisualizar && Convert.ToString(dgUsuarios.Rows[fila].Cells["SucursalCol"].Value) == "El Grullo")
            {
                MessageBox.Show("Su contraseña es: " + logica.GetContraseñaUsuario(Convert.ToInt16(dgUsuarios.Rows[fila].Cells["ID"].Value)));
               

                return;
            }
            if (permitirVisualizar && Convert.ToString(dgUsuarios.Rows[fila].Cells["sucursalCol"].Value) == "Ciudad Guzman")
            {

                MessageBox.Show("Su contraseña es: " + logica.GetContraseñaUsuarioRemoto(Convert.ToInt16(dgUsuarios.Rows[fila].Cells["ID"].Value)));

                return;
            }

            MessageBox.Show("Contraseña de administrador incorrecta");
        }
        
        private void EliminarProfesionistaLocal(int idProfesionista)
        {
            
                LogicaPodologo logicaPodologo = new LogicaPodologo();
                logicaPodologo.EliminarProfesionista(idProfesionista);
                return;
            
        }

        private void EliminarProfesionistaRemoto(int idProfesionista)
        {
           
                LogicaPodologo logicaPodologo = new LogicaPodologo();
                logicaPodologo.EliminarProfesionistaRemoto(idProfesionista);
                return;
            
        }

        private void EliminarUsuarioLocal(int idUsuario, string usuario)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.EliminarUsuario(idUsuario);
            logicaUsuario.EliminarUsuarioMysql(usuario);
            permitirVisualizar = false;

        }

        private void EliminarUsuarioRemoto(int idUsuario, string usuario)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.EliminarUsuarioRemoto(idUsuario);
            logicaUsuario.EliminarUsuarioMysqlRemoto(usuario);
            return;

        }

        private void AgregarColumnasDataGrid()
        {
            DataGridViewButtonColumn editarCol = new DataGridViewButtonColumn();
            editarCol.HeaderText = "Editar";
            editarCol.Name = "EditarCol";

            DataGridViewButtonColumn eliminarCol = new DataGridViewButtonColumn();
            eliminarCol.HeaderText = "Eliminar";
            eliminarCol.Name = "EliminarCol";

            dgProfesionistas.Columns.Add(editarCol);
            dgProfesionistas.Columns.Add(eliminarCol);
        }

        /// <summary>
        /// Remoto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        
        private void RellenarGridUsuariosRemoto(string usuario)
        {
           
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow dataRow in logicaPodologo.VerUsuariosRemoto(usuario).Rows)
            {
                dgUsuarios.Rows.Insert(dgUsuarios.Rows.Count, Convert.ToString(dataRow[0]), Convert.ToString(dataRow[1]), Convert.ToBoolean(dataRow[3]) ? "Adminstrador" : "Secretaria","Ciudad Guzman");
            }
        }

        private void RellenarDataGridUsuarios()
        {
            dgUsuarios.Rows.Clear();
            RellenarGridUsuarios("");
            RellenarGridUsuariosRemoto("");
        }
        private void dgProfesionistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarProfesionista(int fila)
        {
           
            if (permitirVisualizar && Convert.ToString(dgProfesionistas.Rows[fila].Cells["Sucursal"].Value) == "El Grullo")
            {

                EliminarProfesionistaLocal(Convert.ToInt32(dgProfesionistas.Rows[fila].Cells["ID"].Value));

                return;
            }
            if (permitirVisualizar && Convert.ToString(dgProfesionistas.Rows[fila].Cells["sucursal"].Value) == "Ciudad Guzman")
            {

                EliminarProfesionistaRemoto(Convert.ToInt32(dgProfesionistas.Rows[fila].Cells["ID"].Value));

                return;
            }
        }

        private void EliminarUsuario(int fila)
        {

            if (permitirVisualizar && Convert.ToString(dgUsuarios.Rows[fila].Cells["sucursalCol"].Value) == "El Grullo")
            {

                EliminarUsuarioLocal(Convert.ToInt32(dgUsuarios.Rows[fila].Cells["ID"].Value), Convert.ToString(dgUsuarios.Rows[fila].Cells["usuarioCol"].Value));

                return;
            }
            if (permitirVisualizar && Convert.ToString(dgUsuarios.Rows[fila].Cells["sucursalCol"].Value) == "Ciudad Guzman")
            {

                EliminarUsuarioRemoto(Convert.ToInt32(dgUsuarios.Rows[fila].Cells["ID"].Value), Convert.ToString(dgUsuarios.Rows[fila].Cells["usuarioCol"].Value));

                return;
            }
            if (!permitirVisualizar)
            {
                MessageBox.Show("Contraseña de administrador invalida", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
