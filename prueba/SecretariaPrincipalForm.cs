﻿using System;
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
            RellenarListaPodologos();
            RellenarComboBoxPodologos();
            RellenarDataGridPodologos(0);
            AgregarBotonesGrid();
            RenombrarCantidadCitas();

            if (cmbxPodologo.Items.Count == 0)
            {
                cmbxPodologo.SelectedIndex = -1;
                return;
            }
            cmbxPodologo.SelectedIndex = 0;



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
                    
                    Cita cita = new Cita((int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value);
                    ComprobarContraseñaForm comprobarContraseñaForm = new ComprobarContraseñaForm();
                    comprobarContraseñaForm.ShowDialog();
                    EliminarCita(cita);
                    RellenarGridXochitil(ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);
                }
                if (dgXochitl.Columns[e.ColumnIndex].Name == "EditarCol")
                {

                    int FilaSeleccionada = dgXochitl.Rows.IndexOf(dgXochitl.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value;
                    //ElementosGlobales.PodologoGlobal = 2;

                    EditarCitaForm detallesCitaForm = new EditarCitaForm(true);
                    detallesCitaForm.ShowDialog();

                    //FormPanelSecretaria.AbrirFormulario<EditarCitaForm>();
                    //Close();
                    RellenarDataGridPodologos(ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);

                }
                if (dgXochitl.Columns[e.ColumnIndex].Name == "FinalizarCol")
                {
                   
                    int FilaSeleccionada = dgXochitl.Rows.IndexOf(dgXochitl.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value;
                    AnadirResultadoForm detallesCitaForm = new AnadirResultadoForm(false);
                    detallesCitaForm.ShowDialog();
                    RellenarDataGridPodologos(ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);
                }
                if (dgXochitl.Columns[e.ColumnIndex].Name == "DetallesCol")
                {
                    int FilaSeleccionada = dgXochitl.Rows.IndexOf(dgXochitl.Rows[e.RowIndex]);
                    ElementosGlobales.idCitaGlobal = (int)dgXochitl.Rows[FilaSeleccionada].Cells["ID"].Value;
                    DetallesCitaForm detallesCitaForm = new DetallesCitaForm();
                    detallesCitaForm.ShowDialog();
                    RellenarDataGridPodologos(ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbxPodologo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RellenarDataGridPodologos(ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);


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
            
            RellenarDataGridPodologos(ElementosGlobales.idPodologos[cmbxPodologo.SelectedIndex]);
            RenombrarCantidadCitas();
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

        

        private void AgregarBotonesGrid()
        {
            AgregarBotonesDataGridXochitl();
        }

        private void RellenarGridXochitil(int idPodologo)
        {
            dgXochitl.DataSource = ObjLogicaSecretaria.VerConsultasPodologo(CalendarioCitas.SelectionStart,idPodologo);
        }

      

        private void RellenarDataGridPodologos(int idPodologo)
        {
            RellenarGridXochitil(idPodologo);
            if (dgXochitl.Rows.Count != 0)
            {

            dgXochitl.Columns["ID"].Visible = false;
            }
        }

        private void RellenarListaPodologos()
        {
            LogicaSecretaria secretaria = new LogicaSecretaria();
            foreach (DataRow registro in secretaria.GetPodologos().Rows)
            {
                ElementosGlobales.idPodologos.Add(int.Parse(registro[0].ToString()));
            }
        }
        private void RellenarComboBoxPodologos()
        {
            
            LogicaSecretaria secretaria = new LogicaSecretaria();
            foreach (DataRow registro in secretaria.GetPodologos().Rows)
            {
                cmbxPodologo.Items.Add(registro[1].ToString());
            }
        }

        private void EliminarCita(Cita cita)
        {
            if(ElementosGlobales.isAdmin)
            {
                ObjLogicaSecretaria.EliminarCita(cita);
                ElementosGlobales.isAdmin = false;
            }
        }
        private void dgXochitl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgXochitl_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            RenombrarCantidadCitas();
        }

        private void dgXochitl_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RenombrarCantidadCitas();
        }

        private void RenombrarCantidadCitas()
        {
            string fechaConcat = (CalendarioCitas.SelectionStart.DayOfYear == DateTime.Today.DayOfYear) ? "Hoy" : CalendarioCitas.SelectionStart.ToString("dddd dd/MM/yyyy");

            
              
                lblCitas.Text = fechaConcat+"\nTotal de citas: "+ dgXochitl.Rows.Count;
                

            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


    }

