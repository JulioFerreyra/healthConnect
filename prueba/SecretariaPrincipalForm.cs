using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using FontAwesome.Sharp;


namespace prueba
{
    public partial class SecretariaPrincipalForm : Form
    {

        LogicaSecretaria ObjLogicaSecretaria = new LogicaSecretaria();


        public SecretariaPrincipalForm()
        {
            InitializeComponent();


        }


        /// <summary>
        /// Foarm Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SecretariaPrincipalForm_Load(object sender, EventArgs e)
        {

            RellenarDataGridPodologos();
            AgregarBotonesGrid();



        }

        ///
        ///<summary>
        ///DataGrid Xochitl
        /// </summary>
        /// 

        private void dgXochitl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgXochitl.Columns[e.ColumnIndex].Name == "EliminarCol")
                {
                    int FilaSeleccionada = dgXochitl.Rows.IndexOf(dgXochitl.Rows[e.RowIndex]);
                    int idCita = (int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value;
                    Cita cita = new Cita(idCita);
                    ObjLogicaSecretaria.EliminarCita(cita);
                    RellenarGridXochitil();
                }
                if (dgXochitl.Columns[e.ColumnIndex].Name == "EditarCol")
                {
                    int FilaSeleccionada = dgXochitl.Rows.IndexOf(dgXochitl.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value;
                    ElementosGlobales.PodologoGlobal = 2;
                    EditarCitaForm editarcita = new EditarCitaForm();
                    editarcita.ShowDialog();
                    RellenarDataGridPodologos();

                }
                if (dgXochitl.Columns[e.ColumnIndex].Name == "FinalizarCol")
                {
                    int FilaSeleccionada = dgXochitl.Rows.IndexOf(dgXochitl.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value;
                    AnadirResultadoForm detallesCitaForm = new AnadirResultadoForm();
                    detallesCitaForm.ShowDialog();
                    RellenarDataGridPodologos();
                }
                
            }
            catch (Exception)
            {

            }
        }



        /// <summary>
        /// DataGrid Ignacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       


        ///
        ///<summary>
        /// Control de fechas
        /// </summary>
        /// 
        private void CalendarioCitas_DateChanged(object sender, DateRangeEventArgs e)
        {
            RellenarDataGridPodologos();
        }

       
        /// <summary>
        /// Métodos de clase
        /// </summary>
        private void AgregarBotonesDataGridXochitl()
        {
            DataGridViewImageColumn EditarBtnGrid = new DataGridViewImageColumn();
            EditarBtnGrid.HeaderText = "Editar";
            EditarBtnGrid.Name = "EditarCol";
            EditarBtnGrid.Width = 45;
            EditarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            EditarBtnGrid.Image = CapaPresentacion.Properties.Resources.editar;


            DataGridViewImageColumn EliminarBtnGrid = new DataGridViewImageColumn();
            EliminarBtnGrid.HeaderText = "Eliminar";
            EliminarBtnGrid.Name = "EliminarCol";
            EliminarBtnGrid.Width = 45;
            EliminarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            EliminarBtnGrid.Image = CapaPresentacion.Properties.Resources.eliminar;

            DataGridViewImageColumn FinalizarBtnGrid = new DataGridViewImageColumn();
            FinalizarBtnGrid.HeaderText = "Finalizar cita";
            FinalizarBtnGrid.Name = "FinalizarCol";
            FinalizarBtnGrid.Width = 45;
            FinalizarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            FinalizarBtnGrid.Image = CapaPresentacion.Properties.Resources.finalizar;


            DataGridViewImageColumn DetallesBtnGrid = new DataGridViewImageColumn();
            DetallesBtnGrid.HeaderText = "Ver Detalles";
            DetallesBtnGrid.Name = "DetallesCol";
            DetallesBtnGrid.Width = 45;
            DetallesBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            DetallesBtnGrid.Image = CapaPresentacion.Properties.Resources.detalles;

            dgXochitl.Columns.Add(EditarBtnGrid);
            dgXochitl.Columns.Add(EliminarBtnGrid);
            dgXochitl.Columns.Add(DetallesBtnGrid);
            dgXochitl.Columns.Add(FinalizarBtnGrid);

        }

        private void AgregarBotonesDataGridIgnacio()
        {
            DataGridViewImageColumn EditarBtnGrid = new DataGridViewImageColumn();
            EditarBtnGrid.HeaderText = "Editar";
            EditarBtnGrid.Width = 45;
            EditarBtnGrid.Name = "EditarCol";
            EditarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            EditarBtnGrid.Image = CapaPresentacion.Properties.Resources.editar;

            DataGridViewImageColumn EliminarBtnGrid = new DataGridViewImageColumn();
            EliminarBtnGrid.HeaderText = "Eliminar";
            EliminarBtnGrid.Name = "EliminarCol";
            EliminarBtnGrid.Width = 45;
            EliminarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            EliminarBtnGrid.Image = CapaPresentacion.Properties.Resources.eliminar;

            DataGridViewImageColumn FinalizarBtnGrid = new DataGridViewImageColumn();
            FinalizarBtnGrid.HeaderText = "Finalizar cita";
            FinalizarBtnGrid.Name = "FinalizarCol";
            FinalizarBtnGrid.Width = 45;
            FinalizarBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            FinalizarBtnGrid.Image = CapaPresentacion.Properties.Resources.finalizar;

            DataGridViewImageColumn DetallesBtnGrid = new DataGridViewImageColumn();
            DetallesBtnGrid.HeaderText = "Ver Detalles";
            DetallesBtnGrid.Name = "DetallesCol";
            DetallesBtnGrid.Width = 45;
            DetallesBtnGrid.ImageLayout = DataGridViewImageCellLayout.Normal;
            DetallesBtnGrid.Image = CapaPresentacion.Properties.Resources.detalles;

          

        }

        private void AgregarBotonesGrid()
        {
            AgregarBotonesDataGridIgnacio();
            AgregarBotonesDataGridXochitl();
        }

        private void RellenarGridXochitil()
        {
            dgXochitl.DataSource = ObjLogicaSecretaria.VerConsultasPodologo(CalendarioCitas.SelectionStart,2);
        }

        private void RellenarGridIgnacio()
        {
            LogicaSecretaria logicaSecretaria = new LogicaSecretaria();
           
        }

        private void RellenarDataGridPodologos()
        {
            RellenarGridXochitil();
            RellenarGridIgnacio();
        }

 
    }


    }

