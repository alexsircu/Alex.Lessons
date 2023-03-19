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

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public decimal Bonus { get { return _bonus; } set { _bonus = value; BonusRicevuto = true; } }
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

        public Persona(string Name, string Surname, int Age, int Maturita, int Università, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune)
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

            counter++;
            SetIsAdult();
        }

        public virtual void GetValues()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Cognome: {Surname}");
            Console.WriteLine($"Age: {this.Age}");
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
    }
}
