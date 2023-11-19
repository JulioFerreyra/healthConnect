using CapaLogica;
using Microsoft.Reporting.WinForms;
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
            CambiarVisibilidad(false);
            cmbTiposCita.Visible = false;
            this.rvReportes.Clear();

            LogicaSecretaria logica = new LogicaSecretaria();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", logica.ReportesCitas());
            rvReportes.LocalReport.DataSources.Add(reportDataSource);
            rvReportes.RefreshReport();
        }

        private void cmbFiltro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0) CambiarVisibilidad(true);
             
            if (cmbFiltro.SelectedIndex == 1) CambiarVisibilidad(false);
        }

        private void CambiarVisibilidad(bool estado)
        {
            dtFinal.Visible= estado;
            dtInicio.Visible= estado;
            cmbTiposCita.Visible= !estado;
        }

        private void pnlOpciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
