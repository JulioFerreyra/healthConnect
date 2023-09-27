using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DetallesCitaForm : Form
    {
        public DetallesCitaForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetallesCitaForm_Load(object sender, EventArgs e)
        {
            Cita cita = new Cita(ElementosGlobales.idCitaGlobal);
            RellenarCampos(cita);
        }

        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="cita"></param>
        public void RellenarCampos(Cita cita)
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
            foreach (DataRow renglon in logicaSecretaria.GetDetellesCita(cita).Rows)
            {
                tbxNombre.Texts = renglon[0].ToString();
                tbxApellPat.Texts = renglon[1].ToString();
                tbxApellMat.Texts = renglon[2].ToString();
                tbxTelefono.Texts = renglon[3].ToString();
                tbxSintomas.Texts = renglon[4].ToString();
                if (string.IsNullOrEmpty(renglon[5].ToString()))
                {
                    txtResultado.Texts = "Cita aún pendiente";
                }
                else
                {
                    txtResultado.Texts = renglon[5].ToString();

                }
                  
                txtPod.Texts = renglon[6].ToString();
                txtTipoCita.Texts = renglon[7].ToString();
                txtHora.Texts = renglon[8].ToString();
                txtFecha.Texts = renglon[9].ToString();
            }
            
        }
    }
    
}
