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
    public partial class ConfiguracionForm : Form
    {
        public ConfiguracionForm()
        {
            InitializeComponent();
            ttAyuda.SetToolTip(pctTiposCita, "Ingrese o Modifique los Tipos de Cita: \n Para eliminar: Seleccione el Tipo de Cita y presione la tecla suprimir (Puede encontrase también como 'DEL' o 'SUPR'). \n Para agregar: Desplácese hastas el final y escriba El Tipo de Cita deseada en el espacio en blanco");
            ttAyuda.SetToolTip(pctHorario, "Ingrese o Modifique su horario: \n Para eliminar: Seleccione el horario y presione la tecla suprimir (Puede encontrase también como 'DEL' o 'SUPR'). \n Para agregar: Desplácese hastas el final y escriba la hora deseada en el espacio en blanco");
            ttAyuda.SetToolTip(dgTiposCita, "Ingrese o Modifique los Tipos de Cita: \n Para eliminar: Seleccione el Tipo de Cita y presione la tecla suprimir (Puede encontrase también como 'DEL' o 'SUPR'). \n Para agregar: Desplácese hastas el final y escriba El Tipo de Cita deseada en el espacio en blanco");
            ttAyuda.SetToolTip(dgHorario, "Ingrese o Modifique su horario: \n Para eliminar: Seleccione el horario y presione la tecla suprimir (Puede encontrase también como 'DEL' o 'SUPR'). \n Para agregar: Desplácese hastas el final y escriba la hora deseada en el espacio en blanco");
            ttAyuda.SetToolTip(btnAplicar, "Aplicar y guardar los cambios hechos en el Horario");
            ttAyuda.SetToolTip(btnEditar, "Aplicar y guardar los cambios hechos en los Tipos de Cita");

        }





        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            RellenarTiposCita();
            RellenarHoras();
            
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            CrearHoras();
          

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CrearTiposCita();
            
            

        }
        private void tagControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tagControl.SelectedIndex == 1) RellenarLogs();
        }

        /// <summary>
        /// Métodos
        /// </summary>
        private void RellenarTiposCita()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            dgTiposCita.DataSource = logicaPodologo.GetTiposDeCita();
            
        }
        private void RellenarHoras()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            dgHorario.DataSource = logicaPodologo.GetHoras();
        }
        private void RellenarLogs()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            dgLogs.DataSource = logicaPodologo.VerLogs();
        }

        private void CrearHoras()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.EliminarHoras();
            for (int fila = 0; fila < dgHorario.Rows.Count - 1; fila++)
            {

                logicaPodologo.CrearHoras(Convert.ToString(dgHorario.Rows[fila].Cells[0].Value));
            }

        }

        private void CrearTiposCita()
        {
            LogicaPodologo logicaPodologo = new LogicaPodologo();
            logicaPodologo.EliminarTiposCita();
           
            for (int fila = 0; fila < dgTiposCita.Rows.Count-1; fila++)
            {
               
            logicaPodologo.CrearTiposCita(Convert.ToString(dgTiposCita.Rows[fila].Cells[0].Value));
            }

        }
        private void textBoxD1__TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
