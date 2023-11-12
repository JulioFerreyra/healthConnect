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
            RellenarGridUsuarios("");
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
            RellenarGridUsuarios("");
           
        }
        private void btnAgregarProfesionsitas_Click(object sender, EventArgs e)
        {
            AgregarProfesionistaForm agregarProfesionistaForm = new AgregarProfesionistaForm();
            agregarProfesionistaForm.ShowDialog();
            RellenarGridProfesionistas("");
        }

        private void dgUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgUsuarios.Columns[e.ColumnIndex].Name == "EliminarCol")
            {
                try
                {
                    int FilaSeleccionada = dgUsuarios.Rows.IndexOf(dgUsuarios.Rows[e.RowIndex]);


                    ComprobarContraseñaForm comprobarContraseñaForm = new ComprobarContraseñaForm();
                    comprobarContraseñaForm.ShowDialog();
                    EliminarUsuario(Convert.ToInt16(dgUsuarios.Rows[FilaSeleccionada].Cells["ID"].Value), Convert.ToString(dgUsuarios.Rows[FilaSeleccionada].Cells["usuarioCol"].Value));
                    RellenarGridUsuarios("");
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
                    RellenarGridProfesionistas("");
                    permitirVisualizar = false;
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
                    EditarProfesionsitaForm editarProfesionsitaForm = new EditarProfesionsitaForm();
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
                dgUsuarios.Rows.Insert(0, Convert.ToString(dataRow[0]), Convert.ToString(dataRow[1]), Convert.ToBoolean(dataRow[3]) ? "Adminstrador" : "Secretaria");
            }
        }
        private void RellenarGridProfesionistas(string profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            dgProfesionistas.DataSource = logicaPodologo.VerProfesionistas("");
        }

       private void VisualizarContraseña(int fila)
        {
            LogicaPodologo logica = new LogicaPodologo();
            if (permitirVisualizar)
            {
                MessageBox.Show("Su contraseña es: " + logica.GetContraseñaUsuario(Convert.ToInt16(dgUsuarios.Rows[fila].Cells["ID"].Value)));
                return;
            }
            MessageBox.Show("Contraseña de administrador incorrecta");
        }
        private void EliminarUsuario(int idUsuario, string usuario)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (permitirVisualizar)
            {
                logicaPodologo.EliminarUsuario(idUsuario);
                logicaUsuario.EliminarUsuarioMysql(usuario);
            }
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

       
    }
}
