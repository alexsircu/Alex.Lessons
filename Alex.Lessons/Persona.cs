using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeClassi
{
    internal class Persona
    {
        static int counter = 0;
        string _name;
        string _surname;
        int _age;
        int _maturita;
        int _università;
        bool _fedinaPenale;
        int _figli;
        bool _militare;
        bool _debiti;
        bool _isAdult;
        decimal _pilComune;
        decimal _bonus;
        bool _bonusRicevuto = false;

        bool _lavoro;
        bool _cDeterminato;
        bool _cIndeterminato;
        bool _cFullTime;
        bool _cPartTime;
        int _mesiLavoro;
        decimal _naspi;

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public decimal Bonus { 
            get { return _bonus; } 
            set 
            { 
                _bonus = value;
                BonusRicevuto = true;
            } 
        }
        public bool BonusRicevuto { get { return _bonusRicevuto; } set { _bonusRicevuto = value; } }
        public decimal PilComune { get { return _pilComune; } set { _pilComune = value; } }
        public int Maturita { get { return _maturita; } set { _maturita = value; } }
        public int Figli { get { return _figli; } set { _figli = value; } }
        public bool Debiti { get { return _debiti; } set { _debiti = value; } }
        public int Università { get { return _università; } set { _università = value; } }
        public bool FedinaPenale { get { return _fedinaPenale; } set { _fedinaPenale = value; } }
        public string FullName { get { return _name + " " + _surname; } }
        public bool IsAdult { get { return _isAdult; } set { _isAdult = value; } }
        public bool Militare { get { return _militare; } set { _militare = value; } }

        public bool Lavoro { get { return _lavoro; } set { _lavoro = value; } }
        public bool CDeterminato { get { return _cDeterminato; } set { _cDeterminato = value; } }
        public bool CIndeterminato { get { return _cIndeterminato; } set { _cIndeterminato = value; } }
        public bool CFullTime { get { return _cFullTime; } set { _cFullTime = value; } }
        public bool CPartTime { get { return _cPartTime; } set { _cPartTime = value; } }
        public int MesiLavoro { get { return _mesiLavoro; } set { _mesiLavoro = value; } }
        public decimal Naspi { get { return _naspi; } set { _naspi = value; } }

        public Persona(string Name, string Surname, int Age, int Maturita, int Università, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune, bool Lavoro, bool CDeterminato, bool CIndeterminato, bool CFullTime, bool CPartTime, int MesiLavoro)
        {
            this.Name = Name;
            this.Surname = Surname;

            //Bonus
            this.Age = Age;
            this.Maturita = Maturita;
            this.Università = Università;
            this.FedinaPenale = FedinaPenale;
            this.Figli = Figli;
            this.Militare = Militare;
            this.Debiti = Debiti;
            this.PilComune = PilComune;

            this.Lavoro = Lavoro;
            this.CDeterminato = CDeterminato;
            this.CIndeterminato = CIndeterminato;
            this.CPartTime = CPartTime;
            this.CFullTime = CFullTime;
            this.MesiLavoro = MesiLavoro;

            counter++;
            SetIsAdult();
            //CalcolaBonus();
        }

        public void GetValues()
        {
            Console.WriteLine($"Nome:{Name}");
            Console.WriteLine($"Cognome:{Surname}");
            Console.WriteLine($"Age:{this.Age}");
            Console.WriteLine($"Maturita:{this.Maturita}");
            Console.WriteLine($"Debiti:{Debiti}");
            Console.WriteLine($"Bonus ricevuto:{this.Bonus}");
            Console.WriteLine($"Naspi ricevuto:{this.Naspi}");
        }

        public int GetCounter()
        {
            return counter;
        }

        private void SetIsAdult()
        {
            if (this.Age > 18)
            {
                IsAdult = true;
            }
            else
            {
                IsAdult = false;
            }
        }

        /*private void CalcolaBonus()
        {

            if (this.Maturita >= 90)
            {
                Punteggio += 7;
            }

            if (IsAdult && Age <= 28)
            {
                Punteggio += 6;
            }

            if (Università > 28)
            {
                Punteggio += 6;
            }

            if (Figli > 0)
            {
                for (int i = 0; i < Figli; i++)
                {
                    Punteggio += 4;
                }
            }

            if (!FedinaPenale)
            {
                Punteggio += 6;
            }

            if (!Debiti)
            {
                Punteggio += 6;
            }

            if (this.PilComune < 1000000)
            {
                Punteggio += 7;
            }

            if (Punteggio > IndiceBonus && IsAdult)
            {
                this.Bonus = 10000;
            }
        }*/
    }
}
