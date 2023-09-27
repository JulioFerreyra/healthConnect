using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class LogicaPodologo
    {
        /// <summary>
        /// Select
        /// </summary>
        /// <param name="FechaCita"></param>
        /// <param name="idPodologo"></param>
        /// <returns></returns>
        public DataTable VerCitasPodologo(DateTime FechaCita, int idPodologo)
        {
            PodologoDAO podologoDAO = new PodologoDAO();
            return podologoDAO.VerCitasPodologo(FechaCita, idPodologo);
            
                
        }
        public DataTable GetNombrePodologo(int idPodologo)
        {
            PodologoDAO podologoDAO=new PodologoDAO();
            return podologoDAO.GetNombrePodologo(idPodologo);
        }


        public void EliminarCita(Cita cita)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la cita?\n Una vez eliminado no se podrá recuperar", "Confirmación necesario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                PodologoDAO podologoDAO = new PodologoDAO();
                podologoDAO.EliminarCita(cita);
            }
            return;
        }
    }
}
