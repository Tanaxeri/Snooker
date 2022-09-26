using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{
    class snookers
    {

        readonly int helyezes;
        readonly string nev;
        readonly string orszag;
        readonly int nyeremeny;

        public int Helyezes => helyezes;

        public string Nev => nev;

        public string Orszag => orszag;

        public int Nyeremeny => nyeremeny;

        public snookers(int helyezes, string nev, string orszag, int nyeremeny)
        {
            this.helyezes = helyezes;
            this.nev = nev;
            this.orszag = orszag;
            this.nyeremeny = nyeremeny;
        }

    }
}
