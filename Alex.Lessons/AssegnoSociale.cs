using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeClassi
{
    internal class AssegnoSociale
    {
        int _punteggio;
        public int Punteggio { get => _punteggio; set => _punteggio = value; }

        public virtual void CalcolaAssegno(Persona person)
        {

        }
    }
}
