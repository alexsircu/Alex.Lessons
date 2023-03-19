using System;

namespace LeClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //se lavoratore può accedere solo al bonus se punteggio > 35
            //se lavoratore non può accedere al NASPI

            //se non lavoratore può accedere al NASPI se punteggio > 10
            //se non lavoratore non può accedere al bonus

            Persona paolo = new Lavoratore("Paolo", "Fumagalli", 26, 97, 24, false, 14, false, false, 12300000M, 2300, "Determinato");
            Persona gianluca = new NonLavoratore("Gianluca", "Rossi", 33, 89, 26, false, 0, false, false, 30000000M, "Indeterminato", "Part-time", 22);

            AssegnoSociale naspi = new Naspi();
            AssegnoSociale bonus = new Bonus();

            bonus.CalcolaAssegno(paolo);
            naspi.CalcolaAssegno(gianluca);

            paolo.GetValues();
            gianluca.GetValues();
        } 
    }
}
