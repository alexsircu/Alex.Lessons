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

            AssegnoSociale bonus = new Bonus();
            AssegnoSociale naspi = new Naspi();

            Person lavoratore = new Lavoratore(
                "Bruno",
                "Ferreira",
                40,
                92,
                29,
                false,
                0,
                false,
                true,
                900000M);
            Person nonLavoratore = new NonLavoratore(
                "Bruno",
                "Ferreira",
                40,
                92,
                29,
                false,
                0,
                false,
                true,
                900000M);

            bonus.calcolaAssegno(lavoratore);
            naspi.calcolaAssegno(nonLavoratore);
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

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int Age { get { return _age; } set { _age = value; } }
            public decimal Bonus { get { return _bonus; } set { _bonus = value; } }
            public decimal PilComune { get { return _pilComune; } set { _pilComune = value; } }
            public int Maturita { get { return _maturita; } set { _maturita = value; } }
            public int Punteggio { get { return _punteggio; } set { _punteggio = value; } }
            public int Figli { get { return _figli; } set { _figli = value; } }
            public bool Debiti { get { return _debiti; } set { _debiti = value; } }
            public int Università { get { return _universita; } set { _universita = value; } }
            public bool FedinaPenale { get { return _fedinaPenale; } set { _fedinaPenale = value; } }

            public string FullName { get { return _name + " " + _surname; } }
            public bool IsAdult { get { return _isAdult; } set { _isAdult = value; } }
            
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
                )
            {
                _name = Name;
                _surname = Surname;
                // variabili per il BONUS 
                this.Age = Age;
                this.Maturita = Maturita;
                _universita = Universita;
                _fedinaPenale = FedinaPenale;
                _figli = Figli;
                _militare = Militare;
                _debiti = Debiti;
                this.PilComune = PilComune;

                counter++;
                SetIsAdult();
                //CalcolaBonus();
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
                Console.WriteLine($"Nome:{Name}");
                Console.WriteLine($"Cognome:{Surname}");
                Console.WriteLine($"Age:{this.Age}");
                Console.WriteLine($"Maturita:{this.Maturita}");
                Console.WriteLine($"Debiti:{Debiti}");
                Console.WriteLine($"Bonus ricevuto:{this.Bonus}");
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

        internal class Lavoratore : Person
        {
            bool lavoro = true;
            decimal _stipendio;

            public Lavoratore(string Name, string Surname, int Age, int Maturita, int Universita, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune) : base(Name, Surname, Age, Maturita, Universita, FedinaPenale, Figli, Militare, Debiti, PilComune)
            {
            }
        }

        internal class NonLavoratore : Person
        {
            bool _lavoro = false;
            bool _cDeterminato;
            bool _cFullTime;
            int _mesiLavoro;

            public NonLavoratore(string Name, string Surname, int Age, int Maturita, int Universita, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune) : base(Name, Surname, Age, Maturita, Universita, FedinaPenale, Figli, Militare, Debiti, PilComune)
            {
            }

            public bool Lavoro { get => _lavoro; set => _lavoro = value; }
            public bool CDeterminato { get => _cDeterminato; set => _cDeterminato = value; }
            public bool CFullTime { get => _cFullTime; set => _cFullTime = value; }
            public int MesiLavoro { get => _mesiLavoro; set => _mesiLavoro = value; }
        }

        internal class AssegnoSociale
        {
            decimal _contributo;

            public decimal Contributo { get => _contributo; set => _contributo = value; }

            public virtual void calcolaAssegno(Person person)
            {

            }
        }

        internal class Bonus : AssegnoSociale
        {
            const int indiceBonus = 35;
            public static int IndiceBonus => indiceBonus;

            public override void calcolaAssegno(Person lavoratore)
            {
                if (lavoratore.Maturita >= 90)
                {
                    lavoratore.Punteggio += 7;
                }

                if (lavoratore.IsAdult && lavoratore.Age <= 28)
                {
                    lavoratore.Punteggio += 6;
                }

                if (lavoratore.Università > 28)
                {
                    lavoratore.Punteggio += 6;
                }

                if (lavoratore.Figli > 0)
                {
                    for (int i = 0; i < lavoratore.Figli; i++)
                    {
                        lavoratore.Punteggio += 4;
                    }
                }

                if (!lavoratore.FedinaPenale)
                {
                    lavoratore.Punteggio += 6;
                }

                if (!lavoratore.Debiti)
                {
                    lavoratore.Punteggio += 6;
                }

                if (lavoratore.PilComune < 1000000)
                {
                    lavoratore.Punteggio += 7;
                }

                if (lavoratore.Punteggio > IndiceBonus && lavoratore.IsAdult)
                {
                    Contributo = 10000M;
                }
            }
        }

        internal class Naspi : AssegnoSociale
        {
            const int _indiceNaspi = 4;

            public static int IndiceNaspi => _indiceNaspi;

            public override void calcolaAssegno(Person nonLavoratore)
            {
                /*if (!_lavoro)
                {
                    _punteggio += 1;
                }
                if (_cDeterminato)
                {
                    _punteggio += 0;
                }
                if (_cFullTime)
                {
                    _punteggio += 1;
                }
                if (_mesiLavoro > 6)
                {
                    _punteggio += 1;
                }

                if (IndiceNaspi >= 4)
                {
                    Contributo = 5000M;
                }*/
            }
        }
    }
}
