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
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {

            this.rvReportes.RefreshReport();
        }
    }
}
