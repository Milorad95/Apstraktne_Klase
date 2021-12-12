using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktne_klase
{
    public class Student : Osoba
    {
        public int GodinaStudija { get; set; }
        public string BrojIndeksa { get; set; }
        public override string Ime { get; set; }
        public override string Prezime { get; set; }
        public override string Pol { get; set; }


        public Student(string ime, string prezime, string pol, int godina, string brojIndeksa)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pol = pol;
            this.GodinaStudija = godina;
            this.BrojIndeksa = brojIndeksa;
        }

        public override void opis()
        {
            Console.WriteLine($"---------- Student ----------\nIme: {this.Ime}\nPrezime: {this.Prezime}\nPol: {this.Pol}\nGodina studija: {this.GodinaStudija}\nBroj indeksa: {this.BrojIndeksa}");
        }
    }
}
