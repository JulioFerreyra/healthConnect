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


namespace CapaPresentacion
{
    public partial class FormPanelSecretaria : Form
    {
        
        public FormPanelSecretaria()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 80);
            panel1.Controls.Add(leftBorderBtn);
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActivateButton(btnPrincipal, RGBColors.colorBoton);
            BotonInicial();
            AbrirFormulario<SecretariaPrincipalForm>();
        }


        /// <summary>
        /// Diseño?
        /// </summary>
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
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
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

        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
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
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        //Nuevo Paciente
        private void rjButton1_Click(object sender, EventArgs e)
        {
            NuevoPacienteForm NuevoPaciente = new NuevoPacienteForm();  
            NuevoPaciente.ShowDialog();
            try
            {
                Form formularioCerrar = Application.OpenForms["SeleccionarPacienteForm"];
                formularioCerrar.Close();
            }
            catch (Exception)
            {

            }
        }

        //Seleccionar Paciente
        private void rjButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Pacientes";
            AbrirFormulario<SeleccionarPacienteForm>();
            try
            {
                Form formularioCerrar = Application.OpenForms["SecretariaPrincipalForm"];
                formularioCerrar.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                Form formularioCerrar = Application.OpenForms["NuevaCitaForm"];
                formularioCerrar.Close();
            }
            catch (Exception) 
            {

            }


        }

        //Secretaria Principal
        private void rjButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Pantalla Principal";
            AbrirFormulario<SecretariaPrincipalForm>();
            try
            {
                Form formularioCerrar = Application.OpenForms["SeleccionarPacienteForm"];
                formularioCerrar.Close();
               
            }
            catch (Exception)
            {

            }
            try
            {
                Form formularioCerrar = Application.OpenForms["NuevaCitaForm"];
                formularioCerrar.Close();
                
            }
            catch (Exception)
            {

            }
            try
            {
                Form CerrarNuevoPaciente = Application.OpenForms["NuevoPacienteForm"];
                CerrarNuevoPaciente.Close();

            }
            catch (Exception)
            {

            }
           

        }

        //Nueva cita
        private void rjButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Nueva Cita";
            ElementosGlobales.PodologoGlobal = 0;
            AbrirFormulario<NuevaCitaForm>();
            try
            {
                Form formularioCerrar = Application.OpenForms["SecretariaPrincipalForm"];
                formularioCerrar.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                Form formularioCerrar = Application.OpenForms["SeleccionarPacienteForm"];
                formularioCerrar.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                Form CerrarNuevoPaciente = Application.OpenForms["NuevoPacienteForm"];
                CerrarNuevoPaciente.Close();

            }
            catch (Exception)
            {

            }

        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorBoton);
            lblTitulo.Text = "Citas por confirmar";
            //SeleccionReporteForm seleccionReporteForm = new SeleccionReporteForm();
            //ElementosGlobales.UsuarioCondicion = true;
            //seleccionReporteForm.ShowDialog();
            AbrirFormulario<ConfirmarCitasForm>();
            try
            {
                Form formularioCerrar = Application.OpenForms["SecretariaPrincipalForm"];
                formularioCerrar.Close();

            }
            catch (Exception)
            {

            }
            try
            {
                Form formularioCerrar = Application.OpenForms["SeleccionarPacienteForm"];
                formularioCerrar.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                Form CerrarNuevoPaciente = Application.OpenForms["NuevoPacienteForm"];
                CerrarNuevoPaciente.Close();

            }
            catch (Exception)
            {

            }

            //ReportesForm reportes = new ReportesForm();
            //reportes.ShowDialog();
        }

        private void Panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        private void BotonInicial()
        {
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.colorBoton;
            lblTitulo.Text = "Pantalla Principal";
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
