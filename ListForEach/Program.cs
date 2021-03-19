using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEach
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wat wil je doen? \n1. Studentengegevens invoeren\n2. Studentengegevens tonen");
            int keuze = Convert.ToInt32(Console.ReadLine());

            //  switch (keuze)
            {

                //  case 1:
                {
                    Console.WriteLine("Voor welke student wil je de gegevens invullen? Geef een cijfer van 1 tot 5 op.");
                    int student = Convert.ToInt32(Console.ReadLine());
                    List<Student> mijnStudenten = new List<Student>();




                    switch (student)
                    {
                        case 1:
                            Console.WriteLine("Naam: \n Leeftijd: \nPunten Communicatie: \nPunten PP: \nPunten WT: ");
                            mijnStudenten.Add(new Student() { Naam = Console.ReadLine(), Leeftijd = Convert.ToInt32(Console.ReadLine()), PuntenComm = Convert.ToInt32(Console.ReadLine()), PuntenPP = Convert.ToInt32(Console.ReadLine()), PuntenWT = Convert.ToInt32(Console.ReadLine()) });

                            //                  List<Student>.ForEach(item => Console.Write(mijnStudenten));



                            
                            Console.WriteLine($"1: {mijnStudenten[0]}");
                            Console.ReadLine();

                            break;

                        case 2:
                            Console.WriteLine("Naam: \n Leeftijd: \nPunten Communicatie: \nPunten PP: \nPunten WT: ");
                            mijnStudenten.Add(new Student() { Naam = Console.ReadLine(), Leeftijd = Convert.ToInt32(Console.ReadLine()), PuntenComm = Convert.ToInt32(Console.ReadLine()), PuntenPP = Convert.ToInt32(Console.ReadLine()), PuntenWT = Convert.ToInt32(Console.ReadLine()) });

                            Console.WriteLine($"1: {mijnStudenten[0]}");
                            Console.ReadLine();

                            break;

                        
                    }


                    //                case 3:

                    mijnStudenten.Add(new Student() { Naam = "Ken" });
                    //                  break;
                    //               case 4:

                    mijnStudenten.Add(new Student() { Naam = "Ken" });
                    //                   break;
                    //               case 5:

                    mijnStudenten.Add(new Student() { Naam = "Ken" });
                    //                    break;
                }



            }


        }
    }
}



