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
    public partial class ReporteForm : Form
    {
        public ReporteForm()
        {
            InitializeComponent();
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {
            vwReporte.LocalReport.DataSources.Clear();
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            switch (ElementosGlobales.TipoReporte)
            {
                case 1:
                    ReportDataSource reporte = new ReportDataSource("DataSet1", logicaSecretaria.ReporteTipoCitaPodologo(ElementosGlobales.tipoCita,ElementosGlobales.EstadoCita,ElementosGlobales.PodologoGlobal.ToString()));
                    vwReporte.LocalReport.DataSources.Add(reporte);
                    break;
                case 3:
                    ReportDataSource DatosReporte = new ReportDataSource("DataSet1", logicaSecretaria.ReporteTipoCitaPodologo(ElementosGlobales.tipoCita,ElementosGlobales.EstadoCita,string.Empty));
                    vwReporte.LocalReport.DataSources.Add(DatosReporte);
                    break;
                case 2:
                    ReportDataSource dtReporte = new ReportDataSource("DataSet1", logicaSecretaria.ReporteFechasPodologo(ElementosGlobales.FechasReporte.Keys.ElementAt(0),ElementosGlobales.FechasReporte.Values.ElementAt(0), ElementosGlobales.PodologoGlobal.ToString(),ElementosGlobales.EstadoCita));
                    vwReporte.LocalReport.DataSources.Add(dtReporte);
                    break; 
                case 4:
                    ReportDataSource report = new ReportDataSource("DataSet1", logicaSecretaria.ReporteFechasPodologo(ElementosGlobales.FechasReporte.Keys.ElementAt(0), ElementosGlobales.FechasReporte.Values.ElementAt(0), string.Empty, ElementosGlobales.EstadoCita));
                    vwReporte.LocalReport.DataSources.Add(report);
                    break;
                default:
                    break;
            }
            vwReporte.RefreshReport();
        }

        private void vwReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
