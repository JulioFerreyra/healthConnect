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
    public partial class HistorialPodologoForm : Form
    {
        public HistorialPodologoForm()
        {
            InitializeComponent();
        }

        private void HistorialPodologoForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 31, 31);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRegresarPrincipalSecretaria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
