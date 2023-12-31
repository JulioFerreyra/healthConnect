﻿    using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPresentacion;
using System.Windows.Forms;
using CapaEntidad;

namespace prueba
{
    public partial class SeleccionarPacienteForm : Form
    {
        public SeleccionarPacienteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FormLoad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionarPacienteForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(31, 31, 31);
            RellenarGrid(string.Empty);
            AgregarBotonesGrid();
            
            
        }

        /// <summary>
        /// Boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            RellenarGrid(txtBuscar.Texts);
        }
        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
            Close();

        }


        /// <summary>
        /// DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPacientes.Columns[e.ColumnIndex].Name=="EditarCol")
                {
                    int FilaSeleccionada = dgPacientes.Rows.IndexOf(dgPacientes.Rows[e.RowIndex]);
                    ElementosGlobales.idPacienteGlobal = (int)dgPacientes.Rows[FilaSeleccionada].Cells["ID"].Value;
                    EditarPacienteForm editarPaciente = new EditarPacienteForm();
                    editarPaciente.ShowDialog();
                    RellenarGrid(string.Empty);
                }
                if (dgPacientes.Columns[e.ColumnIndex].Name == "EliminarCol")
                {

                    int FilaSeleccionada = dgPacientes.Rows.IndexOf(dgPacientes.Rows[e.RowIndex]);
                    int idPacienteEliminar = (int)dgPacientes.Rows[FilaSeleccionada].Cells["ID"].Value;
                    Paciente paciente = new Paciente(idPacienteEliminar);
                    LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
                    logicaSecretaria.EliminarPaciente(paciente);
                    RellenarGrid(string.Empty);
                }
                if(dgPacientes.Columns[e.ColumnIndex].Name == "HistorialCol")
                {
                    int FilaSeleccionada = dgPacientes.Rows.IndexOf(dgPacientes.Rows[e.RowIndex]);
                    ElementosGlobales.idPacienteGlobal = (int)dgPacientes.Rows[FilaSeleccionada].Cells["ID"].Value;
                    HistorialSecretariaForm historialSecretariaForm = new HistorialSecretariaForm();
                    historialSecretariaForm.ShowDialog();

                }
            }
            catch 
            { 
            }

        }


        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="NombrePaciente"></param>
        private void RellenarGrid(string NombrePaciente)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            dgPacientes.DataSource = logicaSecretaria.VerPacientes(NombrePaciente);

        }    

        private void AgregarBotonesGrid()
        {
            DataGridViewImageColumn EditarBtnGrid = new DataGridViewImageColumn();
            EditarBtnGrid.HeaderText = "Editar";
            EditarBtnGrid.Width = 30;
            EditarBtnGrid.Name = "EditarCol";
            EditarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            EditarBtnGrid.Image = CapaPresentacion.Properties.Resources.editar;

            DataGridViewImageColumn EliminarBtnGrid = new DataGridViewImageColumn();
            EliminarBtnGrid.HeaderText = "Eliminar";
            EliminarBtnGrid.Name = "EliminarCol";
            EliminarBtnGrid.Width = 30;
            EliminarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            EliminarBtnGrid.Image = CapaPresentacion.Properties.Resources.eliminar;


            DataGridViewButtonColumn VerHistoralBtnGrid = new DataGridViewButtonColumn();
            VerHistoralBtnGrid.HeaderText = "Ver Historial";
            VerHistoralBtnGrid.Name = "HistorialCol";
            VerHistoralBtnGrid.Width = 30;
            if (ElementosGlobales.idUsuarioGlobal ==3)
            {
                dgPacientes.Columns.Add(EditarBtnGrid);
                dgPacientes.Columns.Add(EliminarBtnGrid);
                
            }
            dgPacientes.Columns.Add(VerHistoralBtnGrid);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
