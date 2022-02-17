using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonaProvaComune5App
{
    class Piloti
    {
        internal IEnumerable elencoMaratone;

        class Brani
        {
            public List<Pilota> elencoMaratone;

            public Brani()
            {
                elencoMaratone = new List<Pilota>();
            }

            public void Aggiungi(Pilota pilota)
            {
                elencoMaratone.Add(pilota);
            }
            public int CalcolaTempo(string Tempo)
            {
                int minuti = 0;
                int ore = int.Parse(Tempo.Substring(0, 2));
                int minutiParziali = int.Parse(Tempo.Substring(3, 2));



                return minuti;
            }
          public string CercaTempo(string nome, string citta)
            {
                string tempo = "";
                foreach (var maratona in elencoMaratone)
                {
                    if (maratona.NomeAtleta == nome && maratona.Citta == citta)
                    {
                        tempo = maratona.Tempo;


                    }
                }


            }
            public void LeggiDati()
            {

                using (FileStream flussoDati = new FileStream("discografia.txt", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader lettoreDati = new StreamReader(flussoDati))
                    {
                       



                        while (!lettoreDati.EndOfStream)
                        {
                            string linea = lettoreDati.ReadLine();
                            string[] campi = linea.Split('%');

                            Pilota pilota = new Pilota();
                            pilota.NomeAtleta = campi[0];
                            pilota.SocietàDiAppartenenza = campi[1];
                            pilota.Tempo = CercaTempo(campi[2]);
                            pilota.Citta = campi[3];


                            Aggiungi(pilota);

                        }
                    }
                }
            }

            private string CercaTempo(string v)
            {
                throw new NotImplementedException();
            }
        }

        internal string ContaMaratona(string album)
        {
            throw new NotImplementedException();
        }

        internal string Nome(object citta)
        {
            throw new NotImplementedException();
        }

        internal string Atleta(object nome)
        {
            throw new NotImplementedException();
        }

        internal string CercaAtleta(object citta)
        {
            throw new NotImplementedException();
        }

        internal string NomeAtleta(object citta)
        {
            throw new NotImplementedException();
        }

        internal void LeggiDati()
        {
           
        }


         string CercaArtista(string titolo)
                 {
                     string artista = titolo + "--NON TROVATO--";

                     foreach (var pilota in NomeAtleta)
                     {
                         if (pilota.CittàInCuiSièCorsaLaMaratona == città)
                         {
                             artista = pilota.NomeArtista;
                         }
                     }

                     return artista;
                 }

                 public string ContaBrani(string album)
                 {
                     string numBraniStr = album + "--NON TROVATO--";
                     int numBrani = 0;

                     foreach (var brano in elencoAtleti)
                     {
                         if (brano.TitoloAlbum == album)
                         {
                             numBrani++;
                         }
                     }

                     if (numBrani != 0)
                     {
                         numBraniStr = numBrani.ToString();
                     }
                     return numBraniStr;
                 }

                 public string CalcolaDurata()
                 {
                     string durata = "0";

                     return durata.ToString();
                 }
             }
         }
        }

        
    }
}