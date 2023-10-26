using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class AntecedentesNoPatologicos
    {

        private int idAntNoPat;
        private int idPaciente;
        private bool parto;
        private bool hiperlaxitud;
        private bool tabaco;
        private bool alcohol;
        private bool drogas;
        private bool actividadFisica;
        private string frecuenciaAlcohol;
        private string frecuenciaActividad;
        private string frecuenciaTabaco;

        public AntecedentesNoPatologicos(int idAntNoPat, int idPaciente, bool parto, bool hiperlaxitud, bool tabaco, bool alcohol, bool drogas, bool actividadFisica, string frecuenciaAlcohol, string frecuenciaActividad, string frecuenciaTabaco)
        {
            this.idAntNoPat = idAntNoPat;
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
        public string GetFrecueciaAlcohol() { return frecuenciaAlcohol; }
        public string GetFrecuenciaActividad() {return frecuenciaActividad; }
        public string GetFrecuenciaTabaco() { return frecuenciaTabaco; }
    }
}
