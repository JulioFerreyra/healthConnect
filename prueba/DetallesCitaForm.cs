using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DetallesCitaForm : Form
    {
        public DetallesCitaForm()
        {
            InitializeComponent();
        }

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

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetallesCitaForm_Load(object sender, EventArgs e)
        {
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal);
            RellenarCampos(cita);
        }

        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="cita"></param>
        public void RellenarCampos(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow renglon in logicaSecretaria.GetDetellesCita(cita).Rows)
            {
                tbxNombre.Texts = renglon[0].ToString();
                tbxApellPat.Texts = renglon[1].ToString();
                tbxApellMat.Texts = renglon[2].ToString();
                tbxTelefono.Texts = renglon[3].ToString();
                tbxSintomas.Texts = renglon[4].ToString();
                if (string.IsNullOrEmpty(renglon[5].ToString()))
                {
                    txtResultado.Texts = "Cita aún pendiente";
                }
                else
                {
                    txtResultado.Texts = renglon[5].ToString();

                }
                  
                txtPod.Texts = renglon[6].ToString();
                txtTipoCita.Texts = renglon[7].ToString();
                txtHora.Texts = renglon[8].ToString();
                txtFecha.Texts = renglon[9].ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
