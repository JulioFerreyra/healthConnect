using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaLogica
{
    public class ElementosGlobales
    {
        public static int PodologoGlobal = 0;
        public static int idUsuarioGlobal =0;
        public static int idPacienteGlobal = 0;
        public static int idCitaGlobal = 0;
        public static Dictionary<int,string> DiccionarioUsuarios = new Dictionary<int,string>();

        //Para reportes
        public static bool UsuarioCondicion = true;
        public static int TipoReporte = 0;
        public static Dictionary<DateTime,DateTime> FechasReporte = new Dictionary<DateTime,DateTime>();
        public static string tipoCita = string.Empty;
        public static string EstadoCita = string.Empty;
    }
   
}
