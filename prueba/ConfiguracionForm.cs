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
    public partial class ConfiguracionForm : Form
    {
        public ConfiguracionForm()
        {
            InitializeComponent();
        }





        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            SelectorDeColor.ShowDialog();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            string [] TiposCita = txtTiposCita.Texts.Split(new[] {Environment.NewLine,"\n"},StringSplitOptions.None);
            foreach (string str in TiposCita)
            {
                textBoxD1.Texts += str;
                textBoxD1.Texts += "\n";
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
