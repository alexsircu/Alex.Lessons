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

                if (nonLavoratore.CDeterminato)
                {
                    Punteggio += 4;
                }
                if (nonLavoratore.CIndeterminato)
                {
                    Punteggio += 5;
                }
                if (nonLavoratore.CFullTime)
                {
                    Punteggio += 5;
                }
                if (nonLavoratore.CPartTime)
                {
                    Punteggio += 3;
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
                Console.WriteLine("Un lavoratore non può accedere al NASPI");
            }
        } 
    }
}
