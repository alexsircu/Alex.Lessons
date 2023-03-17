using System;

namespace LeClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona person1 = new Persona("Bruno", "Ferreira", 40, 92, 29, false, 3, false, true, 900000M, true, false, true, true, false, 5);

            AssegnoSociale naspi = new Naspi();
            AssegnoSociale bonus = new Bonus();

            if (person1.Lavoro)
            {
                bonus.CalcolaAssegno(person1);
            } 
            else if (person1.BonusRicevuto == false)
            {
                naspi.CalcolaAssegno(person1);
            }

            person1.GetValues();
        } 
    }
}
