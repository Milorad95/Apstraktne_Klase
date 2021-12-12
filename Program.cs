using System;

namespace Apstraktne_klase
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Profesor("Marko", "Markovic", "Musko", "Profesor strukovnih studija");
            p.opis();

            Console.WriteLine();
            Console.WriteLine();

            var s = new Student("Jovana", "Jovanovic", "Zensko", 3, "1i1/0012/19");
            s.opis();

            Console.ReadLine();
        }
    }
}
