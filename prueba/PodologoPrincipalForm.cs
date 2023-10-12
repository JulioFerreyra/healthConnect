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
using System.Windows.Controls;
using System.Windows.Forms;

using Color = System.Drawing.Color;

namespace CapaPresentacion
{
    public partial class PodologoPrincipalForm : Form
    {
       
        public PodologoPrincipalForm()
        {
            InitializeComponent();
          

        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PodologoPrincipalForm_Load(object sender, EventArgs e)
        {
            RellenarDataGrid();
            AgregarBotonesDataGrid();
            AsignarNombrePodologo();
            
        }

        /// <summary>
        /// DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EliminarCol")
                {
                    int FilaSeleccionada = dataGridView1.Rows.IndexOf(dataGridView1.Rows[e.RowIndex]);
                    int idCita = (int)dataGridView1.Rows[FilaSeleccionada].Cells["ID"].Value;
                    Cita cita = new Cita(idCita);
                    LogicaPodologo logicaPodologo = new LogicaPodologo();
                    logicaPodologo.EliminarCita(cita);
                    RellenarDataGrid();

                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditarCol")
                {
                    int FilaSeleccionada = dataGridView1.Rows.IndexOf(dataGridView1.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dataGridView1.Rows[FilaSeleccionada].Cells["ID"].Value;
                    ElementosGlobales.PodologoGlobal = ElementosGlobales.idUsuarioGlobal;
                    EditarCitaForm editarcita = new EditarCitaForm();
                    editarcita.ShowDialog();
                    RellenarDataGrid();

                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DetallesCol")
                {
                    int FilaSeleccionada = dataGridView1.Rows.IndexOf(dataGridView1.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dataGridView1.Rows[FilaSeleccionada].Cells["ID"].Value;
                    DetallesCitaForm detallesCitaForm = new DetallesCitaForm();
                    detallesCitaForm.ShowDialog();
                }

            }
            catch
            {

            }

        }
        /// <summary>
        /// Calendario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendarioCitas_DateChanged(object sender, DateRangeEventArgs e)
        {
            RellenarDataGrid();
        }

        /// <summary>
        /// Métodos
        /// </summary>
        private void AgregarBotonesDataGrid()
        {
            DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "EditarCol";
            btnEditar.Width = 20;
            btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEditar.Image = CapaPresentacion.Properties.Resources.editar;


            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn();
            btnEliminar.Width = 45;
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "EliminarCol";
            btnEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEliminar.Image = CapaPresentacion.Properties.Resources.eliminar;

            DataGridViewImageColumn btnDetalles = new DataGridViewImageColumn();
            btnDetalles.Width = 45;
            btnDetalles.Name = "DetallesCol";
            btnDetalles.HeaderText = "Ver Detalles";
            btnDetalles.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnDetalles.Image = CapaPresentacion.Properties.Resources.detalles;

            dataGridView1.Columns.Add(btnEditar);
            dataGridView1.Columns.Add(btnEliminar);
            dataGridView1 .Columns.Add(btnDetalles);
        }
        private void RellenarDataGrid()
        {
            ElementosGlobales.PodologoGlobal = ElementosGlobales.idUsuarioGlobal;
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
           dataGridView1.DataSource= logicaSecretaria.VerConsultasPodologo(calendarioCitas.SelectionStart, ElementosGlobales.PodologoGlobal);
        }
        private void AsignarNombrePodologo()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            ElementosGlobales.PodologoGlobal = ElementosGlobales.idUsuarioGlobal;
            foreach (DataRow registro in logicaPodologo.GetNombrePodologo(ElementosGlobales.PodologoGlobal).Rows)
            {
<<<<<<< Updated upstream
                //lblPodologo.Text +=" " + registro[0].ToString(); no lo borro pq luego me pegas
=======
              //  lblPodologo.Text +=" " + registro[0].ToString();
>>>>>>> Stashed changes
            }
        }

       
    }
}
