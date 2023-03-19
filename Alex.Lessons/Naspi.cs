using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeClassi
{
    internal class Naspi : AssegnoSociale
    {
        const int indiceNaspi = 10;
        public static int IndiceNaspi => indiceNaspi;

        public override void CalcolaAssegno(Persona person)
        {
            try
            {
                NonLavoratore nonLavoratore = (NonLavoratore)person;

                if (nonLavoratore.NaspiRicevuto == true)
                {
                    Console.WriteLine($"{nonLavoratore.Name} ha già ricevuto il NASPI");
                }

                if (nonLavoratore.Contratto == "Determinato")
                {
                    Punteggio += 4;
                } 
                else if (nonLavoratore.Contratto == "Indeterminato")
                {
                    Punteggio += 5;
                }

                if (nonLavoratore.TipologiaContratto == "Full-time")
                {
                    Punteggio += 5;
                } 
                else if (nonLavoratore.Contratto == "Part-time")
                {
                    Punteggio += 4;
                }
               
                if (nonLavoratore.MesiLavoro > 6)
                {
                    Punteggio += 3;
                }

                if (Punteggio >= IndiceNaspi && person.IsAdult)
                {
                    nonLavoratore.Naspi = 5000M;
                }
            } 
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Solo un non lavoratore può accedere al NASPI");
            }
        } 
    }
}
