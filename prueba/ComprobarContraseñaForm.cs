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
    public partial class ComprobarContraseñaForm : Form
    {
        public ComprobarContraseñaForm()
        {
            InitializeComponent();
        }

        private void brnAceptar_Click(object sender, EventArgs e)
        {
            LogicaUsuario logica = new LogicaUsuario();

            if (logica.ValidarCampoAdminVacio(txtContraseña.Texts))
            {
                ElementosGlobales.isAdmin = logica.ValidarContraseñaAdmin(txtContraseña.Texts);
                Close();
               
            }
        }

        
    }
}
