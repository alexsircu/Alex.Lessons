using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeClassi
{
    internal class Lavoratore : Persona
    {
        decimal _stipendio;
        string _contratto;

        public decimal Stipendio { get { return _stipendio; } set { _stipendio = value; } }
        public string Contratto { get { return _contratto; } set { _contratto = value; } }

        public Lavoratore(string Name, string Surname, int Age, int Maturita, int Università, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune, decimal stipendio, string contratto) : base(Name, Surname, Age, Maturita, Università, FedinaPenale, Figli, Militare, Debiti, PilComune)
        {
            Stipendio = stipendio;
            Contratto = contratto;
        }
    }
}
