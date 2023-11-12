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
    public partial class EditarProfesionsitaForm : Form
    {
        public EditarProfesionsitaForm()
        {
            InitializeComponent();
        }

        private void EditarProfesionsitaForm_Load(object sender, EventArgs e)
        {
            RellenarCamposProfesionista();
        }

        private void RellenarCamposProfesionista()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            foreach (DataRow fila in logicaPodologo.GetDatosProfesionista(ElementosGlobales.PodologoGlobal).Rows)
            {
                txtNombre.Texts = Convert.ToString(fila[0]);
                txtPat.Texts = Convert.ToString(fila[1]);
                txtMat.Texts = Convert.ToString(fila[2]);
                txtTel.Texts = Convert.ToString(fila[3]);


            }
        }
    }
}
