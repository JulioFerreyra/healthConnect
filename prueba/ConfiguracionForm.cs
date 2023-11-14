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
    public partial class ConfiguracionForm : Form
    {
        public ConfiguracionForm()
        {
            InitializeComponent();
        }





        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            RellenarTiposCita();
            RellenarHoras();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
           

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CrearTiposCita();
            CrearHoras();

        }
        private void tagControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tagControl.SelectedIndex == 1) RellenarLogs();
        }

        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarTiposCita()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow registro in logicaPodologo.GetTiposDeCita().Rows)
            {
                txtTiposCita.Texts += string.Concat(Convert.ToString(registro[0]));
            }
        }
        private void RellenarHoras()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow registro in logicaPodologo.GetHoras().Rows)
            {
                txtHoras.Texts += string.Concat(Convert.ToString(registro[0]));
            }
        }
        private void RellenarLogs()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            dgLogs.DataSource = logicaPodologo.VerLogs();
        }

        private void CrearHoras()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.EliminarHoras();
            string[] TiposCita = txtHoras.Texts.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
            foreach (string tipoCita in TiposCita)
            {

                logicaPodologo.CrearHoras(tipoCita);
            }
        }

        private void CrearTiposCita()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.EliminarTiposCita();
            string[] TiposCita = txtTiposCita.Texts.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
            foreach (string tipoCita in TiposCita)
            {

                logicaPodologo.CrearTiposCita(tipoCita);
            }
        }
        private void textBoxD1__TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
