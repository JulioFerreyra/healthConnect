using CapaEntidad;
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
    public partial class EditarProfesionistaForm : Form
    {
        public EditarProfesionistaForm()
        {
            InitializeComponent();
        }

        private void EditarProfesionsitaForm_Load(object sender, EventArgs e)
        {
            RellenarCamposProfesionista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            Profesionista profesionista = new Profesionista(ElementosGlobales.PodologoGlobal, txtNombre.Texts,txtPat.Texts,txtMat.Texts,txtTel.Texts);
            if (logicaPodologo.ActualizarDatosProfesionista(profesionista))
            {
                Close();
                return;
            }
            
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (txtTel.Texts.Length >= 10)
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Métodos
        /// </summary>
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
