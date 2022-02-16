using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonaProvaComune5App
{
    class Piloti
    {
        class Brani
        {
            public List<Pilota> elencoBrani;

            public Brani()
            {
                elencoBrani = new List<Pilota>();
            }

            public void Aggiungi(Pilota pilota)
            {
                elencoBrani.Add(pilota);
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
                            pilota.TempoImpiegato = campi[2];
                            pilota.CittàInCuiSièCorsaLaMaratona = campi[3];


                            Aggiungi(pilota);

                        }
                    }
                }
            } } } }

   /*lic string CercaArtista(string titolo)
            {
                string artista = titolo + "--NON TROVATO--";

                foreach (var pilota in elencoBrani)
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

                foreach (var brano in elencoBrani)
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

