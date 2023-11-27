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
    public partial class ConfirmarCitasForm : Form
    {
        public ConfirmarCitasForm()
        {
            InitializeComponent();
            ttAyuda.SetToolTip(pctAyuda,"Ayuda");
        }

        private void ConfirmarCitasForm_Load(object sender, EventArgs e)
        {
            RellenarDataGrid();
            AgregarColumnas();
            if (dgCitas.Columns.Count > 3)
            {
                dgCitas.Columns["ID"].Visible = false;
            }
        }


        private void dgCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgCitas.Columns[e.ColumnIndex].Name == "AceptarCol" )
                {
                    int FilaSeleccionada = dgCitas.Rows.IndexOf(dgCitas.Rows[e.RowIndex]);
                    Cita cita = new Cita(Convert.ToInt32(dgCitas.Rows[FilaSeleccionada].Cells["ID"].Value)
                        );
                   
                    CrearCita(cita);
                    RellenarDataGrid();
                }

            }
            catch (Exception)
            {

                
            }
            try
            {
                if (dgCitas.Columns[e.ColumnIndex].Name == "EditarCol")
                {
                    int FilaSeleccionada = dgCitas.Rows.IndexOf(dgCitas.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = Convert.ToInt32(dgCitas.Rows[FilaSeleccionada].Cells["ID"].Value);
                    EditarCitaForm editarCitaForm = new EditarCitaForm(false);
                    editarCitaForm.ShowDialog();
                    RellenarDataGrid();
                }
               
            }
            catch (Exception)
            {

                
            }
            try
            {
                if (dgCitas.Columns[e.ColumnIndex].Name == "RechazarCol")
                {
                    int FilaSeleccionada = dgCitas.Rows.IndexOf(dgCitas.Rows[e.RowIndex]);
                    RechazarCita(Convert.ToInt32(dgCitas.Rows[FilaSeleccionada].Cells["ID"].Value));
                    RellenarDataGrid();
                }
            }
            catch (Exception)
            {

                
            }

        }

        private void RellenarDataGrid()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            dgCitas.DataSource = logicaSecretaria.VerCitasPorConfirmacion();
        }

        private void AgregarColumnas()
        {
            DataGridViewImageColumn aceptarCol = new DataGridViewImageColumn
            {
                Name = "AceptarCol",
                HeaderText = "Aceptar Cita",
                Image = Properties.Resources.AgregarIcon,
                ImageLayout = DataGridViewImageCellLayout.Normal

        };
            DataGridViewImageColumn rechazarCol = new DataGridViewImageColumn
            {
                Name = "RechazarCol",
                HeaderText = "Rechazar Cita",
                Image = Properties.Resources.cancelar,
                ImageLayout = DataGridViewImageCellLayout.Normal

            };
            DataGridViewImageColumn editarCol = new DataGridViewImageColumn
            {
                Name = "EditarCol",
                HeaderText = "Editar Cita",
                Image = Properties.Resources.editar,
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            dgCitas.Columns.Add(aceptarCol);
            dgCitas.Columns.Add(editarCol);
            dgCitas.Columns.Add(rechazarCol);
        }

        private void CrearCita(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            logicaSecretaria.AceptarCita(cita);
        }

        private void RechazarCita(int idCita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            logicaSecretaria.RechazarCita(idCita);
        }
        private void dgCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pctAyuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Cada cita pendiente de confirmación tiene columnas adicionales para las siguientes acciones: \n Aceptar: Al presionar sobre la columna de 'Aceptar Cita' la cita que corresponda a la fila y a la columna será aceptada. \n Editar: Al presionar sobre la columna de 'Editar Cita' se abrirá otra ventana donde podrá modificar los datos de la cita. \n Rechazar: Al presionar sobre 'Rechazar Cita' la cita será rechazada.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
