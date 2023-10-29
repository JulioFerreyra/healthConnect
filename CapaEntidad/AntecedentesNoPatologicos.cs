using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AntecedentesNoPatologicos
    {

        private int idAntNoPat;
        private int idPaciente;
        private bool parto;
        private bool hiperlaxitud;
        private bool tabaco;
        private bool alcohol;
        private bool drogas;
        private bool actividadFisica;
        private int frecuenciaAlcohol;
        private int frecuenciaActividad;
        private int frecuenciaTabaco;

        public AntecedentesNoPatologicos(int idPaciente, bool parto, bool hiperlaxitud, bool tabaco, bool alcohol, bool drogas, bool actividadFisica, int frecuenciaAlcohol, int frecuenciaActividad, int frecuenciaTabaco)
        {
           
            this.idPaciente = idPaciente;
            this.parto = parto;
            this.hiperlaxitud = hiperlaxitud;
            this.tabaco = tabaco;
            this.alcohol = alcohol;
            this.drogas = drogas;
            this.actividadFisica = actividadFisica;
            this.frecuenciaAlcohol = frecuenciaAlcohol;
            this.frecuenciaActividad = frecuenciaActividad;
            this.frecuenciaTabaco = frecuenciaTabaco;
        }

        public int GetIdAntNoPat() {  return idAntNoPat; }
        public int GetIdPaciente() {  return idPaciente; }
        public bool GetParto() { return parto; }
        public bool GetHiperlaxitud() { return hiperlaxitud; }
        public bool GetDrogas() {  return drogas; }
        public bool GetAlcohol() { return alcohol; }
        public bool GetActividadFisica() {  return actividadFisica; }
        public bool GetTabaco() {  return tabaco; }
        public int GetFrecueciaAlcohol() { return frecuenciaAlcohol; }
        public int GetFrecuenciaActividad() {return frecuenciaActividad; }
        public int GetFrecuenciaTabaco() { return frecuenciaTabaco; }
    }
}
