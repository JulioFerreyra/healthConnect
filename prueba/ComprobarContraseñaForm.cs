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
    public partial class ComprobarContraseñaForm : Form
    {
        public ComprobarContraseñaForm()
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
        private void brnAceptar_Click(object sender, EventArgs e)
        {
            LogicaUsuario logica = new LogicaUsuario();

            if (logica.ValidarCampoAdminVacio(txtContraseña.Texts))
            {
                bool autorizar = logica.ValidarContraseñaAdmin(txtContraseña.Texts);
                UsuariosForm.permitirVisualizar = autorizar;
                ElementosGlobales.isAdmin = autorizar;
                Close();
               
            }
        }
    }
}
