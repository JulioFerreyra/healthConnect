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
    public partial class AgregarProfesionistaForm : Form
    {
        public AgregarProfesionistaForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Profesionista profesionista = new Profesionista(txtNombre.Texts,txtPat.Texts,txtMat.Texts,txtTelefono.Texts);
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.CrearProfesionista(profesionista))
            {
                Close();
            }
            


        }

        private void txtTelefono__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (txtTelefono.Texts.Length >= 10)
            {
                e.Handled = true;
            }
        }
    }
}
