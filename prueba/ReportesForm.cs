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
            rvReportes.Clear();
            RellenarListaPodologos();
            RellenarProfesionistas();
            RellenarTiposCita();
            cmbPodologos.Enabled = false;
            CambiarVisibilidad(false);
            cmbTiposCita.Visible = false;
           rvReportes.Refresh();

           
        }

        private void cmbFiltro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPodologos.Enabled = true;
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

        private void RellenarProfesionistas()
        {
            LogicaPodologo logica = new LogicaPodologo();
            foreach (DataRow fila in logica.GetPodologos().Rows)
            {
                cmbPodologos.Items.Add(Convert.ToString(fila[1]));
            }
            if (cmbPodologos.Items.Count > 1)
            {
                cmbPodologos.Items.Add("Todos");
            }
        }

        private void RellenarTiposCita()
        {
            LogicaPodologo logica = new LogicaPodologo();
            foreach (DataRow fila in logica.GetTiposDeCita().Rows)
            {
                cmbTiposCita.Items.Add(Convert.ToString(fila[0]));
            }
           
        }

        private void RellenarListaPodologos()
        {
            LogicaSecretaria secretaria = new LogicaSecretaria();
            foreach (DataRow registro in secretaria.GetPodologos().Rows)
            {
                ElementosGlobales.idPodologos.Add(int.Parse(registro[0].ToString()));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (ValidarCondiciones())
            {
                this.rvReportes.Clear();
                SeleccionReporte();
                rvReportes.RefreshReport();
            }

        }

        private bool ValidarCondiciones()
        {
            if (cmbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Filtro para contiunar", "Filtro invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPodologos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Profesionista para contiunar", "Profesionista invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbFiltro.SelectedIndex ==0 && dtInicio.Value >= dtFinal.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final", "Rango de fechas invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cmbFiltro.SelectedIndex == 1 && cmbTiposCita.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de cita para contiunar", "Tipo de citas invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SeleccionReporte()
        {
            
            if (cmbFiltro.SelectedIndex == 0 && cmbPodologos.SelectedIndex == cmbPodologos.Items.Count-1)
            {
                LogicaPodologo logica = new LogicaPodologo();
               
                Reporte(logica.ReporteFechas(dtInicio.Value, dtFinal.Value));
            }
            if (cmbFiltro.SelectedIndex == 0 && cmbPodologos.SelectedIndex != cmbPodologos.Items.Count - 1)
            {
                LogicaPodologo logica = new LogicaPodologo();
                Reporte(logica.ReportesCitasFechas(ElementosGlobales.idPodologos[cmbPodologos.SelectedIndex], dtInicio.Value, dtFinal.Value));
            }
            if (cmbFiltro.SelectedIndex == 1 && cmbPodologos.SelectedIndex == cmbPodologos.Items.Count - 1)
            {
                LogicaPodologo logica = new LogicaPodologo();
                Reporte(logica.ReportesTipoCita(cmbTiposCita.Texts));
            }
            if (cmbFiltro.SelectedIndex == 1 && cmbPodologos.SelectedIndex != cmbPodologos.Items.Count - 1)
            {
                LogicaPodologo logica = new LogicaPodologo();
                Reporte(logica.ReportesCitasTipoCita(ElementosGlobales.idPodologos[cmbPodologos.SelectedIndex], cmbTiposCita.Texts));
            }
            if (cmbFiltro.SelectedIndex == 1 && cmbPodologos.SelectedIndex != cmbPodologos.Items.Count - 1 && cmbTiposCita.SelectedIndex == 0)
            {
                LogicaPodologo logica = new LogicaPodologo();
                Reporte(logica.ReportesCitasTipoCita(ElementosGlobales.idPodologos[cmbPodologos.SelectedIndex], ""));
            }
            if (cmbFiltro.SelectedIndex == 1 && cmbPodologos.SelectedIndex == cmbPodologos.Items.Count - 1 && cmbTiposCita.SelectedIndex == 0)
            {
                LogicaPodologo logica = new LogicaPodologo();
                Reporte(logica.ReportesTipoCita(""));
            }



        }

        private void Reporte(DataTable tablaConsulta)
        {
            rvReportes.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", tablaConsulta);
            rvReportes.LocalReport.DataSources.Add(reportDataSource);
            rvReportes.RefreshReport();
        }

        private void rvReportes_Load(object sender, EventArgs e)
        {
            this.rvReportes.Clear();
            rvReportes.RefreshReport();
        }

        private void cmbTiposCita_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
