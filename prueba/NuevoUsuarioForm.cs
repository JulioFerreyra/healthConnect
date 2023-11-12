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
    public partial class NuevoUsuarioForm : Form
    {
        private bool isAdmin = false;
        public NuevoUsuarioForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LogicaPodologo logica = new LogicaPodologo();
            Usuario usuario = new Usuario(txtNombre.Texts,txtContra.Texts, isAdmin);
            logica.CraerUsuario(usuario,cmbPuesto.Texts,txtConfirmar.Texts);
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
    }
}
