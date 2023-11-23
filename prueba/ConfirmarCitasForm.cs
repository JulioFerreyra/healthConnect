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
        }

        private void ConfirmarCitasForm_Load(object sender, EventArgs e)
        {
            RellenarDataGrid();
            AgregarColumnas();
        }


        private void dgCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgCitas.Columns[e.ColumnIndex].Name == "AceptarCol" )
                {
                    int FilaSeleccionada = dgCitas.Rows.IndexOf(dgCitas.Rows[e.RowIndex]);
                    Cita cita = new Cita(Convert.ToInt32(dgCitas.Rows[FilaSeleccionada].Cells["idPaciente"].Value),
                        Convert.ToDateTime(dgCitas.Rows[FilaSeleccionada].Cells["Fecha"].Value),
                        Convert.ToString(dgCitas.Rows[FilaSeleccionada].Cells["Hora"].Value),
                        Convert.ToInt32(dgCitas.Rows[FilaSeleccionada].Cells["idProfesionista"].Value),
                         Convert.ToString(dgCitas.Rows[FilaSeleccionada].Cells["Motivo Cita"].Value),
                         Convert.ToString(dgCitas.Rows[FilaSeleccionada].Cells["Tipo Cita"].Value)
                        );
                    MessageBox.Show(cita.GetIdPaciente().ToString());
                    CrearCita(cita);
                    RechazarCita(Convert.ToInt32(dgCitas.Rows[FilaSeleccionada].Cells["ID"].Value));
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
                    MessageBox.Show("Editar");
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
            DataGridViewButtonColumn aceptarCol = new DataGridViewButtonColumn
            {
                Name = "AceptarCol",
                HeaderText = "Aceptar Cita"
            };
            DataGridViewButtonColumn rechazarCol = new DataGridViewButtonColumn
            {
                Name = "RechazarCol",
                HeaderText = "Rechazar Cita"
            };
            DataGridViewButtonColumn editarCol = new DataGridViewButtonColumn
            {
                Name = "EditarCol",
                HeaderText = "Editar Cita"
            };
            dgCitas.Columns.Add(aceptarCol);
            dgCitas.Columns.Add(editarCol);
            dgCitas.Columns.Add(rechazarCol);
        }

        private void CrearCita(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            logicaSecretaria.CrearNuevaCita(cita);
        }

        private void RechazarCita(int idCita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            logicaSecretaria.RechazarCita(idCita);
        }
        private void dgCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
