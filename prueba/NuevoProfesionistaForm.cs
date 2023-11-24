using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class NuevoProfesionistaForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constantes necesarias para manipular la posición de la ventana
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void NuevoProfesionistaForm_Load(object sender, EventArgs e)
        {
            cmbSucursal.SelectedIndex = 0;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public NuevoProfesionistaForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Profesionista profesionista = new Profesionista(txtNombre.Texts,txtPat.Texts,txtMat.Texts,txtTelefono.Texts);
            if (cmbSucursal.SelectedIndex == 0)
            {
                CrearProfesionista(profesionista);
                return;
            }
            CrearProfesionistaRemoto(profesionista);
            


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

       

        private void CrearProfesionista(Profesionista profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.CrearProfesionista(profesionista))
            {
                Close();
            }
        }

        private void CrearProfesionistaRemoto(Profesionista profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.CrearProfesionistaRemoto(profesionista))
            {
                Close();
            }
        }
    }
}
