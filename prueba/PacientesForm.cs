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
    public partial class PacientesForm : Form
    {
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 31, 31);
            RellenarGrid(string.Empty);
            

        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            RellenarGrid(txtBuscar.Texts);
        }

        /// <summary>
        /// DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int FilaSeleccionada = dgPacientes.Rows.IndexOf(dgPacientes.Rows[e.RowIndex]);
                ElementosGlobales.idPacienteGlobal = (int)dgPacientes.Rows[FilaSeleccionada].Cells["ID"].Value;
            }
            catch (Exception)
            {

                
            }
            
            
            this.Close();
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

        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
