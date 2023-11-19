using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
using CapaPresentacion;
using System.Runtime.InteropServices;

namespace prueba
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// para mover el ratón
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

  
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCorreoLogin.Texts = "FerrJu";
            txbPasswordLogin.Texts = "Apd12345";
        }


        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtCorreoLogin.Texts, txbPasswordLogin.Texts);
            IniciarSesionUsuario(usuario);

            
                   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvideContraseñaForm recuperarContraaseña = new OlvideContraseñaForm();
            Hide();
            recuperarContraaseña.ShowDialog();
            Show();
        }


        /// <summary>
        /// Mover mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void IniciarSesionUsuario(Usuario usuario)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            usuario.SetIdUsuario(logicaUsuario.GetExistenciaUsuario(usuario));

            if (logicaUsuario.ValidarExistenciaUsuario(usuario))
            {
                IniciarSesionAdmin(usuario);
                
                return;
            }
            
            MessageBox.Show("Credenciales incorrectas","Usuario no valido");


        }

        private void IniciarSesionAdmin(Usuario usuario)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();

            if (logicaUsuario.GetisAdmin(usuario))
            {
                EstablecerDatosUsuario(usuario);
                ElementosGlobales.isAdmin = true;
                Hide();
                FormPanelPodologo principalForm = new FormPanelPodologo();
                principalForm.ShowDialog();
                
                RestablecerValores();
                Show();
                return;
            }
            EstablecerDatosUsuario(usuario);
            Hide();
            FormPanelSecretaria principalSecretaria = new FormPanelSecretaria();
            ElementosGlobales.isAdmin = false;
            principalSecretaria.ShowDialog();
            RestablecerValores();
            Show();



        }
        private void RestablecerValores()
        {
            txtCorreoLogin.Texts = string.Empty;
            txbPasswordLogin.Texts = string.Empty;
            ElementosGlobales.idCitaGlobal = 0;
            ElementosGlobales.PodologoGlobal = 0;
            ElementosGlobales.idPacienteGlobal = 0;
            ElementosGlobales.tipoCita = string.Empty;
            ElementosGlobales.EstadoCita = string.Empty;
            ElementosGlobales.FechasReporte.Clear();
            ElementosGlobales.TipoReporte = 0;
            ElementosGlobales.isAdmin = false;
        }

        private void EstablecerDatosUsuario(Usuario usuario)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            logicaSecretaria.SetPassword(usuario.GetContraseña());
            logicaSecretaria.SetUsser(usuario.GetUsuario());
        }
        private void txbPasswordLogin__TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
