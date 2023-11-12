using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Profesionista
    {
        private int idProfesionista;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string telefono;
        public Profesionista() { 

        }

        /// <summary>
        /// Crear
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidoPaterno"></param>
        /// <param name="apellidoMaterno"></param>
        /// <param name="telefono"></param>
        public Profesionista(string nombre, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.telefono = telefono;
        }

        /// <summary>
        /// Actualizar
        /// </summary>
        /// <param name="idProfesionista"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidoPaterno"></param>
        /// <param name="apellidoMaterno"></param>
        /// <param name="telefono"></param>
        public Profesionista(int idProfesionista, string nombre, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            this.idProfesionista = idProfesionista;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.telefono = telefono;
        }

        public int GetIdProfesionista()
        {
            return idProfesionista;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellidoPaterno()
        {
            return apellidoPaterno;
        }

        public string GetApellidoMaterno()
        {
            return apellidoMaterno;
        }

        public string GetTelefono()
        {
            return telefono;
        }
    }
}
