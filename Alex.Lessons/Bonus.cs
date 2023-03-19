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

                if (person.BonusRicevuto == true)
                {
                    Console.WriteLine($"{person.Name} ha già ricevuto un bonus");
                    return;
                }

                if (person.Maturita >= 90)
                {
                    Punteggio += 7;
                }

                if (person.IsAdult && person.Age <= 28)
                {
                    Punteggio += 6;
                }

                if (person.Università > 28)
                {
                    Punteggio += 6;
                }

                if (person.Figli > 0)
                {
                    for (int i = 0; i < person.Figli; i++)
                    {
                        Punteggio += 4;
                    }
                }

                if (!person.FedinaPenale)
                {
                    Punteggio += 6;
                }

                if (!person.Debiti)
                {
                    Punteggio += 6;
                }

                if (person.PilComune < 1000000)
                {
                    Punteggio += 7;
                }

                if (Punteggio > IndiceBonus && person.IsAdult)
                {
                    person.Bonus = 10000M;
                }
            } 
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Solo un lavoratore può accedere al bonus");
            }
            
        }
    }
}
