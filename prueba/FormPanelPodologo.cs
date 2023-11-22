using CapaLogica;
using FontAwesome.Sharp;
using prueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace CapaPresentacion
{
    public partial class FormPanelPodologo : Form
    {
        public FormPanelPodologo()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 80);
            panel1.Controls.Add(leftBorderBtn);
        }


        /// <summary>
        /// load
        /// </summary>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActivateButton(btnPrincipal, RGBColors.colorBoton);
            BotonInicial();
            AbrirFormulario<PodologoPrincipalForm>();
        }
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private struct RGBColors
        {
            public static Color colorBoton = Color.FromArgb(146, 171, 255);
            public static Color Blanco = Color.White;
            public static Color ColorIzquierda = Color.FromArgb(230, 210, 240);
            
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255,255,255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(146, 171, 255);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }




        /// <summary>
        /// Paneles de carga
        /// </summary>

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                Panelformularios.Controls.Add(formulario);
                Panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }


     
        /// <summary>
        /// botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void rjButton1_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void rjButton4_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario<SeleccionarPacienteForm>();
        //}

        //private void rjButton2_Click(object sender, EventArgs e)
        //{
        //    AbrirFormulario<PodologoPrincipalForm>();
        //}
        //private void rjButton3_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}


        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Reportes";
            AbrirFormulario<ReportesForm>();
           //ReportesForm reportes = new ReportesForm();
           // reportes .Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Usuarios";
            AbrirFormulario<UsuariosForm>();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Configuración";
            AbrirFormulario<ConfiguracionForm>();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Patalla Principal";
            AbrirFormulario<PodologoPrincipalForm>();
        }
        private void BotonInicial()
        {
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.colorBoton;
            lblTitulo.Text = "Patalla Principal";
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Seleccionar paciente";
            AbrirFormulario<SeleccionarPacienteForm>();

        }

        private void btnInicioUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnInicioUsuario_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnInicioUsuario_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
                btnAyuda.Visible = false;
                btnCerrarSesion.Visible = false;
            }
            else
            {
                pnlMenu.Visible = true;
                btnAyuda.Visible = true;
                btnCerrarSesion.Visible = true;
            }
        }
    }
}
