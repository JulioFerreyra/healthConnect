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
            Usuario usuario = new Usuario(txtUsuario.Texts,txtContraseña.Texts);
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (logicaUsuario.ActualizarContraseña(usuario,txtConfirmarContraseña.Texts))
            {
                txtConfirmarContraseña.Texts = string.Empty;
                txtContraseña.Texts = string.Empty;
                txtUsuario.Texts = string.Empty;
            }
        }
    }
}
