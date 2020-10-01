using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficApp
{
    class Studente
    {
        private string nome;
        private string cognome;
        private string luogoNascita;
        private DateTime dataNascita;
        private string codiceFiscale;
        private string classe;

        public Studente(string nome, string cognome, string luogoNascita, DateTime dataNascita, string codiceFiscale, string classe)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.luogoNascita = luogoNascita;
            this.dataNascita = dataNascita;
            this.codiceFiscale = codiceFiscale;
            this.classe = classe;
        }
        public string getNome()
        {
            return nome;
        }
        public string getCognome()
        {
            return cognome;
        }
        public string getLuogoNascita()
        {
            return luogoNascita;
        }
        public DateTime getDataNascita()
        {
            return dataNascita;
        }
        public string getCodiceFiscale()
        {
            return codiceFiscale;
        }
        public string getClasse()
        {
            return classe;
        }
    }
}
