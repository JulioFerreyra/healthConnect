using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Paciente
    {
        private int idPaciente;
        private string Nombre { get; set; }
        private string ApellidoPaterno { get; set;}
        private string ApellidoMaterno { get; set;}
        private string Telefono { get; set;}

        public Paciente(string nombre, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Telefono = telefono;
        }

        public Paciente(int idPaciente, string nombre, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            this.idPaciente = idPaciente;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Telefono = telefono;
        }

        public Paciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public string GetApellidoPaterno()
        {
            return ApellidoPaterno;
        }
        public string GetApellidoMaterno()
        { 
            return ApellidoMaterno;
        }
        public string GetTelefono()
        {
            return Telefono;
        }
        public int GetIdPaciente()
        {
            return idPaciente;
        }
    }
}
