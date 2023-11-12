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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuarioForm nuevoUsuarioForm = new NuevoUsuarioForm();
            nuevoUsuarioForm.ShowDialog();
            RellenarGridUsuarios();
        }
        private void btnAgregarProfesionsitas_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodos
        /// </summary>
        private void RellenarGridUsuarios()
        {

        }

       

        
    }
}
