using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnagraficApp
{
    class ElencoStudenti
    {
        private List<Studente> studenti;
        public ElencoStudenti()
        {
            studenti = new List<Studente>();
        }
        public void aggiungiStudente(Studente studente)
        {
            studenti.Add(studente);
        }
        public List<Studente> getElencoCompleto()
        {
            return studenti;
        }
        public void scrivi(string percorso)
        {
            FileStream flusso = new FileStream(percorso, FileMode.CreateNew, FileAccess.Write);
            StreamWriter writer = new StreamWriter(flusso);
            foreach (Studente s in studenti)
            {
                    writer.WriteLine(s.getNome() + "," + s.getCognome() + "," + s.getLuogoNascita() + "," + s.getDataNascita() + "," + s.getCodiceFiscale() + "," + s.getClasse());
                    writer.Flush();
            }
            writer.Close();
        }
    }
}
