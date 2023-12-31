﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
using CapaPresentacion;

namespace prueba
{
    public partial class LoginForm : Form
    {
     
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(31, 31, 31);
            panel1.BackColor = Color.FromArgb(165,0,0,0);
        }


        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtCorreoLogin.Texts,txbPasswordLogin.Texts);
            InicarSesion(usuario);
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Métodos
        /// </summary>
        /// <param name="usuario"></param>
        private void InicarSesion(Usuario usuario)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
           ElementosGlobales.idUsuarioGlobal= logicaUsuario.InciarSesion(usuario);
           
            switch (ElementosGlobales.idUsuarioGlobal)
            {
                case 1:
                    Hide();
                    FormPanelPodologo principalForm = new FormPanelPodologo();
                    principalForm.ShowDialog();
                    Show();
                   ;
                    break;
                case 2:
                    Hide(); 
                    FormPanelPodologo principalpodologo = new FormPanelPodologo();
                    principalpodologo.ShowDialog();
                    Show();
                    break;
                case 3:
                    Hide();
                    FormPanelSecretaria principal = new FormPanelSecretaria();
                    principal.ShowDialog();
                    Show();
                    break;

                default:
                    break;

                    
            }
            RestablecerValores();


        }
        private void RestablecerValores()
        {
            txtCorreoLogin.Texts = string.Empty;
            txbPasswordLogin.Texts = string.Empty;
            ElementosGlobales.idCitaGlobal = 0;
            ElementosGlobales.PodologoGlobal = 0;
            ElementosGlobales.idPacienteGlobal = 0;
            ElementosGlobales.tipoCita = string.Empty;
            ElementosGlobales.EstadoCita = string.Empty;
            ElementosGlobales.FechasReporte.Clear();
            ElementosGlobales.TipoReporte = 0;
        }
    }
}
