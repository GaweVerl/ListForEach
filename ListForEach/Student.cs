using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEach
{

    enum Klassen { EA1, EA2, EA3, EA4 }
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }

        public int PuntenComm { get; set; }
        public int PuntenPP { get; set; }
        public int PuntenWT { get; set; }

        public double BerekTotCijf()
        {
        return (PuntenComm + PuntenPP + PuntenWT)/3.0;
            }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, { Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("***************");
            Console.WriteLine($"Communicatie:\t\t{PuntenComm}");
            Console.WriteLine($"PP: \t\t {PuntenPP}");
            Console.WriteLine($"Web Tech: \t\t{PuntenWT}");
            Console.WriteLine($"Gemiddelde:\t\t{BerekTotCijf():0.0}");

        }

    }
}
