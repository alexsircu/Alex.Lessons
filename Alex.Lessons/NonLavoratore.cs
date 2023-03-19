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
        string _contratto;
        string _tipologiaContratto;
        bool _cFullTime;
        bool _cPartTime;
        int _mesiLavoro;
        decimal _naspi;
        bool _naspiRicevuto = false;

        public string Contratto { get { return _contratto; } set { _contratto = value; } }
        public string TipologiaContratto { get { return _tipologiaContratto; } set { _tipologiaContratto = value; } }
        public int MesiLavoro { get { return _mesiLavoro; } set { _mesiLavoro = value; } }
        public decimal Naspi { get { return _naspi; } set { _naspi = value; NaspiRicevuto = true; } }
        public bool NaspiRicevuto { get { return _naspiRicevuto; } set { _naspiRicevuto = value; } }

        public NonLavoratore(string Name, string Surname, int Age, int Maturita, int Università, bool FedinaPenale, int Figli, bool Militare, bool Debiti, decimal PilComune, string Contratto, string TipologiaContratto, int MesiLavoro) : base(Name, Surname, Age, Maturita, Università, FedinaPenale, Figli, Militare, Debiti, PilComune)
        {
            this.Contratto = Contratto; //det o indet
            this.TipologiaContratto = TipologiaContratto; //ft o pt
            this.MesiLavoro = MesiLavoro;
        }

        public override void GetValues()
        {
            base.GetValues();
            Console.WriteLine($"Ha lavorato con contratto: {this.Contratto}");
            Console.WriteLine($"Tipologia contratto: {this.TipologiaContratto}");

            if (this.NaspiRicevuto)
            {
                Console.WriteLine($"NASPI ricevuto: {this.Naspi}\n");
            }
            else
            {
                Console.WriteLine("NASPI non ricevuto\n");
            }
        }
    }
}
