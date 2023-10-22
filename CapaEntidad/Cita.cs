using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cita
    {
        private int idCita;
        private int idPaciente;
        private DateTime FechaCita;
        private string HoraCita;
        private int idPodologo;
        private string DetallesCita;
        private string TipoCita;
        private string EstadoCita;
        private string HistoriaClinica;
       
        
        //editar
        public Cita(int idCita, int idPaciente, DateTime fechaCita, string horaCita, int idPodologo, string detallesCita, string historiaClinica, string tipoCita, string estadoCita)
        {
            this.idCita = idCita;
            this.idPaciente = idPaciente;
            this.FechaCita = fechaCita;
            this.HoraCita = horaCita;
            this.idPodologo = idPodologo;
           
            
            this.DetallesCita = detallesCita;
            this.HistoriaClinica = historiaClinica;
            this.TipoCita = tipoCita;
            this.EstadoCita = estadoCita;
        }
        public Cita(int idCita, int idPaciente, DateTime fechaCita, string horaCita, int idPodologo, string detallesCita, string tipoCita, string estadoCita)
        {
            this.idCita = idCita;
            this.idPaciente = idPaciente;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            this.idPodologo = idPodologo;
       
            
            DetallesCita = detallesCita;
            TipoCita = tipoCita;
            EstadoCita = estadoCita;
        }
        
        //eliminar
        public Cita(int idCita)
        {
            this.idCita = idCita;
        }

        //añadir historial clinical
        public Cita(int idCita, string historiaClinica)
        {
            this.idCita = idCita;
            HistoriaClinica = historiaClinica;
          
        }

        //crear
        public Cita(int idPaciente, DateTime fechaCita, string horaCita, int idPodologo, string detallesCita, string tipoCita)
        {
            this.idPaciente = idPaciente;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            this.idPodologo = idPodologo;
           
          
            DetallesCita = detallesCita;
            TipoCita = tipoCita;
        }


        public int GetIdCita()
        {
            return idCita;
        }
        public int GetIdPaciente()
        {
            return idPaciente;
        }
        public DateTime GetFechaCita()
        {
            return FechaCita;
        }
        public string GetHoraCita()
        {
            return HoraCita;
        } 
        public int GetIdPodologo() { 
            return idPodologo; 
        }
    
       
        public string GetDetallesCita()
        {
            return DetallesCita;
        }
        public string GetHistoriaClinica()
        {
            return HistoriaClinica;
        }
        public string GetTipoCita()
        {
            return TipoCita;
        }
        public string GetEstadoCita()
        {
            return EstadoCita;
        }
    }
    
}
