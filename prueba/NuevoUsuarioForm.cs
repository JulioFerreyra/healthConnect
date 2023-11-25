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
    public partial class NuevoUsuarioForm : Form
    {
        private bool isAdmin = false;
        public NuevoUsuarioForm()
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

        private void NuevoUsuarioForm_Load(object sender, EventArgs e)
        {
            cmbSucursal.SelectedIndex = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            Usuario usuario = new Usuario(txtNombre.Texts,txtContra.Texts, isAdmin);
            if (cmbSucursal.SelectedIndex == 0)
            {

            CrearUsuario(usuario);
                return;
            }
            CrearUsuarioRemoto(usuario);


        }

        private void cmbPuesto_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.SelectedIndex == 0)
            {
                isAdmin = false;
                return;
            }
            if (cmbPuesto.SelectedIndex == 1)
            {
                isAdmin = true;
                return;
            }
        }

        private void CrearUsuario(Usuario usuario)
        {
            LogicaPodologo logica = new LogicaPodologo();
            if (logica.CraerUsuario(usuario, cmbPuesto.Texts, txtConfirmar.Texts))
            {
                GrantAccess();
                Close();
            }
        }
        private void GrantAccess()
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (isAdmin)
            {
                logicaUsuario.GrantAccessAdministrador(txtNombre.Texts);
                return;
            }
            logicaUsuario.GrantAccessSecreataria(txtNombre.Texts);
        }

        private void CrearUsuarioRemoto(Usuario usuario)
        {
            LogicaPodologo logica = new LogicaPodologo();
            if (logica.CraerUsuarioRemoto(usuario, cmbPuesto.Texts, txtConfirmar.Texts))
            {
                GrantAccessRemoto();
                Close();
            }
        }
        private void GrantAccessRemoto()
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (isAdmin)
            {
                logicaUsuario.GrantAccessAdministradorRemoto(txtNombre.Texts);
                return;
            }
            logicaUsuario.GrantAccessSecretariaRemoto(txtNombre.Texts);
        }

        
    }
}
