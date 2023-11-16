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
            
            
            Usuario usuario = new Usuario(txtNombre.Texts,txtContra.Texts, isAdmin);
            CrearUsuario(usuario);


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
    }
}
