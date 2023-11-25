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
    public partial class EditarProfesionistaForm : Form
    {

        private string sucursal; 
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constantes necesarias para manipular la posición de la ventana
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public EditarProfesionistaForm(string sucursal) 
        {
            InitializeComponent();
            this.sucursal = sucursal;
        }

        private void EditarProfesionsitaForm_Load(object sender, EventArgs e)
        {
            RellenarCamposProfesionista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Profesionista profesionista = new Profesionista(ElementosGlobales.PodologoGlobal, txtNombre.Texts,txtPat.Texts,txtMat.Texts,txtTel.Texts);
            if (cmbSucursal.SelectedIndex == 0)
            {
                ActualizarProfesionistasLocal(profesionista);
                return;
            }
            ActualizarProfesionistasRemoto(profesionista);
            
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
            cmbSucursal.SelectedIndex = cmbSucursal.Items.IndexOf(sucursal);
        }

        private void ActualizarProfesionistasLocal(Profesionista profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.ActualizarDatosProfesionista(profesionista))
            {
                Close();
                return;
            }
        }

        private void ActualizarProfesionistasRemoto(Profesionista profesionista)
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            if (logicaPodologo.ActualizarDatosProfesionistaRemoto(profesionista))
            {
                Close();
                return;
            }

        }


    }
}
