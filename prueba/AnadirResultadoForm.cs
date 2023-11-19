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
    public partial class AnadirResultadoForm : Form
    {
        public AnadirResultadoForm()
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
        private void AnadirResultadoForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(31, 31, 31);
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal);
            RellenarCampos(cita);

        }

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rjButton1_Click(object sender, EventArgs e)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal, txtRes.Texts);
            logicaSecretaria.FinalizarCita(cita);
            Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="cita"></param>
        private void RellenarCampos(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow registro in logicaSecretaria.GetDetellesCita(cita).Rows)
            {
                txtNombre.Texts = registro[0].ToString();
                txtApellPat.Texts = registro[1].ToString();
                txtApellMat.Texts = registro[2].ToString();
                txtTel.Texts = registro[3].ToString();
                txtDetalles.Texts = registro[4].ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}