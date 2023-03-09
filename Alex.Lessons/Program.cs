using System;

namespace LeClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(
                "Bruno",
                "Ferreira",
                40,
                92,
                29,
                false,
                0,
                false,
                true,
                900000M
                );

            person1.GetValues();
        }

        internal class Person
        {
            static int counter = 0;
            string _name;
            string _surname;
            int _age;
            bool _isAdult;
            decimal _bonus;
            decimal _pilComune;
            int _maturita;
            int _universita;
            bool _fedinaPenale;
            int _figli;
            bool _militare;
            bool _debiti;
            int _punteggio;
            const int indiceBonus = 35;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public string FullName { get { return _name + " " + _surname; } }
            public bool IsAdult { get { return _isAdult; } }

            public Person(

                string Name,
                string Surname,
                int Age,
                int Maturita,
                int Universita,
                bool FedinaPenale,
                int Figli,
                bool Militare,
                bool Debiti,
                decimal PilComune
                ) // firma del costruttore
            {
                _name = Name;
                _surname = Surname;
                // variabili per il BONUS 
                _age = Age;
                _maturita = Maturita;
                _universita = Universita;
                _fedinaPenale = FedinaPenale;
                _figli = Figli;
                _militare = Militare;
                _debiti = Debiti;
                _pilComune = PilComune;

                counter++;
                SetIsAdult();
                CalcolaBonus();
            }
            public void GetValues()
            {
                //Console.WriteLine(
                //$"Nome:{_name}\n " +
                //$"Cognome:{_surname}\n" +
                //$"Age:{_age}" +
                //$"Maturita:{_maturita}" +
                //$"FedinaPenale:{_fedinaPenale}" +
                //$"Debiti: {_debiti}"
                //);
                Console.WriteLine($"Nome:{_name}");
                Console.WriteLine($"Cognome:{_surname}");
                Console.WriteLine($"Age:{_age}");
                Console.WriteLine($"Maturita:{_maturita}");
                Console.WriteLine($"Debiti:{_debiti}");
                Console.WriteLine($"Bonus ricevuto:{_bonus}");
            }

            public int GetCounter()
            {
                return counter;
            }

            private void SetIsAdult()
            {
                if (_age > 18)
                {
                    _isAdult = true;
                }
                else
                {
                    _isAdult = false;
                }
            }

            private void CalcolaBonus()
            {

                if (_maturita >= 90)
                {
                    _punteggio += 7;
                }

                if (_isAdult && _age <= 28)
                {
                    _punteggio += 6;
                }

                if (_universita > 28)
                {
                    _punteggio += 6;
                }

                if (_figli > 0)
                {
                    for (int i = 0; i < _figli; i++)
                    {
                        _punteggio += 4;
                    }
                }

                if (!_fedinaPenale)
                {
                    _punteggio += 6;
                }

                if (!_debiti)
                {
                    _punteggio += 6;
                }

                if (_pilComune < 1000000)
                {
                    _punteggio += 7;
                }

                if (_punteggio > indiceBonus && IsAdult)
                {
                    _bonus = 10000;
                }
            }
        }
    }
}
