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
    public partial class OlvideContraseñaForm : Form
    {
        public OlvideContraseñaForm()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Texts, txtContraseña.Texts);
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (logicaUsuario.ValidarActualizarContraseña(usuario, txtConfirmarContraseña.Texts))
            {
               ComprobarContraseñaForm contraseñaForm = new ComprobarContraseñaForm();
                contraseñaForm.ShowDialog();
                ActualizarContraseña(usuario);
                
            }
           
           
            
            
        }

        private void ActualizarContraseña(Usuario usuario)
        {
            if (ElementosGlobales.isAdmin)
            {
                LogicaUsuario logicaUsuario = new LogicaUsuario();
                logicaUsuario.ActualizarContraseña(usuario);
                logicaUsuario.ActualizarContraseñaUsuarioMysql(usuario);

                txtConfirmarContraseña.Texts = string.Empty;
                txtContraseña.Texts = string.Empty;
                txtUsuario.Texts = string.Empty;
                return;
            }
            MessageBox.Show("Contraseña de administrador invalida");
        }
    }
}
