using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeClassi
{
    internal class Bonus : AssegnoSociale
    {
        const int indiceBonus = 35;
        public static int IndiceBonus => indiceBonus;

        public override void CalcolaAssegno(Persona person)
        {
            try
            {
                Lavoratore lavoratore = (Lavoratore)person;

                if (lavoratore.BonusRicevuto == true)
                {
                    Console.WriteLine($"{lavoratore.Name} ha già ricevuto un bonus");
                    return;
                }

                if (lavoratore.Maturita >= 90)
                {
                    Punteggio += 7;
                }

                if (lavoratore.IsAdult && lavoratore.Age <= 28)
                {
                    Punteggio += 6;
                }

                if (lavoratore.Università > 28)
                {
                    Punteggio += 6;
                }

                if (lavoratore.Figli > 0)
                {
                    for (int i = 0; i < lavoratore.Figli; i++)
                    {
                        Punteggio += 4;
                    }
                }

                if (!lavoratore.FedinaPenale)
                {
                    Punteggio += 6;
                }

                if (!lavoratore.Debiti)
                {
                    Punteggio += 6;
                }

                if (lavoratore.PilComune < 1000000)
                {
                    Punteggio += 7;
                }

                if (Punteggio > IndiceBonus && lavoratore.IsAdult)
                {
                    lavoratore.Bonus = 10000M;
                }
            } 
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Solo un lavoratore può accedere al bonus\n");
            }
            
        }
    }
}
