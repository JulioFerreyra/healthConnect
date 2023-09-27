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
    public partial class FormPanelPodologo : Form
    {
       
        public FormPanelPodologo()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panel1.Controls.Add(leftBorderBtn);
        }


        /// <summary>
        /// load
        /// </summary>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario<PodologoPrincipalForm>();
        }
        private IconButton currentbtn;
        private Panel leftBorderBtn;


        /// <summary>
        /// Paneles de carga
        /// </summary>
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
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
 
        //estructura para almacenar colores rgb

        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(59, 59, 59);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.White;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
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
        private void rjButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<SeleccionarPacienteForm>();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PodologoPrincipalForm>();
        }
        private void rjButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ElementosGlobales.PodologoGlobal = ElementosGlobales.idUsuarioGlobal;
            ElementosGlobales.UsuarioCondicion = false;
            SeleccionReporteForm seleccionReporteForm = new SeleccionReporteForm();
            seleccionReporteForm.ShowDialog();
        }
    }
}
