﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AntecedentesPatologicos
    {
        private int idPaciente;
        private string diabetes;
        private string presionArterial;
        private string tiroides;
        private string hepatitis;
        private bool cardiopatias;
        private string intervenciones;
        private bool neoplasia;
        private string medicacion;
        private string alergias;

        public AntecedentesPatologicos(int idPaciente, string diabetes, string presionArterial, string tiroides, string hepatitis, bool cardiopatias, string intervenciones, bool neoplasia, string medicacion, string alergias)
        {
            this.idPaciente = idPaciente;
            this.diabetes = diabetes;
            this.presionArterial = presionArterial;
            this.tiroides = tiroides;
            this.hepatitis = hepatitis;
            this.cardiopatias = cardiopatias;
            this.intervenciones = intervenciones;
            this.neoplasia = neoplasia;
            this.medicacion = medicacion;
            this.alergias = alergias;
        }

        public int GetIdPaciente() {  return idPaciente; }
        public string GetDiabetes() {  return diabetes; }
        public string GetPresionArterial() { return presionArterial; }
        public string GetTiroides() {  return tiroides; }
        public bool GetCardiopatias() { return cardiopatias; }
        public string GetHepatitis() { return hepatitis; }
        public string GetIntervenciones() {  return intervenciones; }
        public string GetMedicacion() {  return medicacion; }
        public string GetAlergias() { return alergias; }
        public bool GetNeoplasia() { return neoplasia; }
    }
}
