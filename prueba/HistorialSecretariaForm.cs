using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class HistorialSecretariaForm : Form
    {
        public HistorialSecretariaForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistorialSecretariaForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 31, 31);
            Paciente paciente = new Paciente(ElementosGlobales.idPacienteGlobal);
            RellenarDataGrid(paciente);
            AgregarBotonGrid();

        }

        /// <summary>
        /// Botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Método
        /// </summary>
        /// <param name="paciente"></param>
        private void RellenarDataGrid(Paciente paciente)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            dgHistorial.DataSource = logicaSecretaria.VerHistoralPaciente(paciente);
        }
        private void AgregarBotonGrid()
        {
            DataGridViewImageColumn btnDetalles = new DataGridViewImageColumn();
            btnDetalles.Name = "DetallesCol";
            btnDetalles.HeaderText = "Ver detalles";
            btnDetalles.ImageLayout = DataGridViewImageCellLayout.Normal;
            btnDetalles.Image = CapaPresentacion.Properties.Resources.detalles;
            btnDetalles.Width = 40;
            dgHistorial.Columns.Add(btnDetalles);

        }

        private void dgHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgHistorial.Columns[e.ColumnIndex].Name == "DetallesCol")
                {
                    int index = dgHistorial.Rows.IndexOf(dgHistorial.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgHistorial.Rows[index].Cells["ID"].Value;
                    DetallesCitaForm detalles = new DetallesCitaForm();
                    detalles.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
