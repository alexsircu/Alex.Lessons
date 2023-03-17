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
            if (person.Lavoro == false)
            {
                Punteggio += 5;
            }
            if (person.CDeterminato)
            {
                Punteggio += 4;
            }
            if (person.CIndeterminato)
            {
                Punteggio += 5;
            }
            if (person.CFullTime)
            {
                Punteggio += 5;
            }
            if (person.CPartTime)
            {
                Punteggio += 3;
            }
            if (person.MesiLavoro > 6)
            {
                Punteggio += 3;
            }

            if (Punteggio >= IndiceNaspi && person.IsAdult)
            {
                person.Naspi = 5000M;
            }
        } 
    }
}
