using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktne_klase
{
    public class Profesor : Osoba
    {
        public string Zvanje { get; set; }
        public override string Ime { get; set; }
        public override string Prezime { get; set; }
        public override string Pol { get; set; }

        public Profesor(string ime, string prezime, string pol, string zvanje)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pol = pol;
            this.Zvanje = zvanje;
        }

        public override void opis()
        {
            Console.WriteLine($"---------- Profesor ----------\nIme: {this.Ime}\nPrezime: {this.Prezime}\nPol: {this.Pol}\nZvanje: {this.Zvanje}");
        }
    }
}
