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
            leftBorderBtn.Size = new Size(7, 70);
            panel1.Controls.Add(leftBorderBtn);
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario<SecretariaPrincipalForm>();
        }


        /// <summary>
        /// Diseño?
        /// </summary>
        private IconButton currentbtn;
        private Panel leftBorderBtn;


        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private struct RGBColors
        {
            public static Color panelcolor = Color.FromArgb(59, 59, 59);//PANEL
            public static Color cerrarcolor = Color.FromArgb(186, 0, 0);//ROJO
            public static Color botonverdecolor = Color.FromArgb(99, 184, 63);//VERDE
            public static Color fondocolor = Color.FromArgb(31, 31, 31); //FONDO

        }
      
        public static void AbrirFormulario<MiForm>() where MiForm : Form, new()
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


        }

        //Nueva cita
        private void rjButton5_Click(object sender, EventArgs e)
        {
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
            

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SeleccionReporteForm seleccionReporteForm = new SeleccionReporteForm();
            ElementosGlobales.UsuarioCondicion = true;
            seleccionReporteForm.ShowDialog();
        }

        private void Panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
