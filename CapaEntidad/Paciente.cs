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
        private string ApellidoPaterno { get; set; }
        private string ApellidoMaterno { get; set; }
        private string Telefono { get; set; }
        private string Direccion { get; set; }

        private DateTime FechaNacimiento {  get; set; }

        private string Sexo {  get; set; }

        public Paciente(string nombre, string apellidoPaterno, string apellidoMaterno, string telefono, string direccion, DateTime fechaNac, string sexo)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Telefono = telefono;
            Direccion = direccion;
            FechaNacimiento = fechaNac;
            Sexo = sexo;
        }

        public Paciente(int idPaciente, string nombre, string apellidoPaterno, string apellidoMaterno, string telefono, string direccion, DateTime fechaNac, string sexo)
        {
            this.idPaciente = idPaciente;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Telefono = telefono;
            Direccion = direccion;
            FechaNacimiento = fechaNac;
            Sexo = sexo;
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

        public string GetDireccion()
        {
            return Direccion;
        }

        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }

        public string GetSexo()
        {
            return Sexo;
        }
    }
}
