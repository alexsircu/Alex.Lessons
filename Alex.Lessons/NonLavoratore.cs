using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeClassi
{
    internal class NonLavoratore : Persona
    {

        bool _cDeterminato;
        bool _cIndeterminato;
        bool _cFullTime;
        bool _cPartTime;
        int _mesiLavoro;
        decimal _naspi;

        public bool CDeterminato { get { return _cDeterminato; } set { _cDeterminato = value; } }
        public bool CIndeterminato { get { return _cIndeterminato; } set { _cIndeterminato = value; } }
        public bool CFullTime { get { return _cFullTime; } set { _cFullTime = value; } }
        public bool CPartTime { get { return _cPartTime; } set { _cPartTime = value; } }
        public int MesiLavoro { get { return _mesiLavoro; } set { _mesiLavoro = value; } }
        public decimal Naspi { get { return _naspi; } set { _naspi = value; } }

        public NonLavoratore(string Name, string Surname, int Age, int Maturita, int Università, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune, bool CDeterminato, bool CIndeterminato, bool CFullTime, bool CPartTime, int MesiLavoro) : base(Name, Surname, Age, Maturita, Università, FedinaPenale, Figli, Militare, Debiti, PilComune)
        {
            this.CDeterminato = CDeterminato;
            this.CIndeterminato = CIndeterminato;
            this.CFullTime = CFullTime;
            this.CPartTime = CPartTime;
            this.MesiLavoro = MesiLavoro;
        }
    }
}
