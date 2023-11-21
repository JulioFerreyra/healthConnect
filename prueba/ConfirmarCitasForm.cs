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
        }

        private void RellenarDataGrid()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            dgCitas.DataSource = logicaSecretaria.VerCitasPorConfirmacion();
        }
    }
}
