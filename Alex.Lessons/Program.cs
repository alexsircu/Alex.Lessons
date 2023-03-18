using System;

namespace LeClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona paolo = new Lavoratore("Paolo", "Fumagalli", 26, 97, 24, false, 14, false, false, 12300000M, 2300, "Determinato");
            Persona gianluca = new NonLavoratore("Gianluca", "Rossi", 33, 89, 26, false, 0, false, false, 30000000M, true, false, true, false, 23);

            AssegnoSociale naspi = new Naspi();
            AssegnoSociale bonus = new Bonus();

            bonus.CalcolaAssegno(paolo);
            naspi.CalcolaAssegno(gianluca);

            paolo.GetValues();

            //test con lavoratore in naspi
            //test con nonlavoratore in bonus
        } 
    }
}
