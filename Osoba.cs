using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktne_klase
{
    public abstract class Osoba
    {
        public abstract string Ime { get; set; }
        public abstract string Prezime { get; set; }
        public abstract string Pol { get; set; }

        public abstract void opis();
    }
}
