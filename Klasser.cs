using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Week4_ovning3
{
    public class Klasser
    {
        public static void MenyMetod()//skapa en meny
        {
            Console.WriteLine("Välkomen");
            Console.WriteLine("1: Lägg till ny elev + Betyg");
            Console.WriteLine("2: Uppdatera befintligt betyg");
            Console.WriteLine("3: Visa alla elever och deras betyg");
            Console.WriteLine("4: Beräkna och visa medelbetyget");
            Console.WriteLine("5: Avsluta");
        }

        //➕ Lägga till en ny elev och betyg
        public static void AddStudentAndGradeMetod(Dictionary<string, int> Elever)
        {
            Console.WriteLine("Skriv ElevNamn");
            string Namn = Console.ReadLine()!;
            Console.WriteLine("Skriv in betyg");
            int Betyg = int.Parse(Console.ReadLine()!);
            Elever.Add(Namn, Betyg);
        }
        public static void ChangeExistingStudentGradeMetod(Dictionary<string, int> Elever)
        {
            //🔁 Uppdatera ett befintligt betyg
            Console.WriteLine("Skriv elevnamn");
            string UppdateraNamn = Console.ReadLine()!;
            if (Elever.ContainsKey(UppdateraNamn))
            {
                Console.Write("Nytt betyg: ");
                int.TryParse(Console.ReadLine(), out int nyttBetyg);
                Elever[UppdateraNamn] = nyttBetyg;
            }
            
        }
        public static void ShowAllStudentsAndGradesMetod(Dictionary<string, int> Elever)
        {
            foreach (var Elev in Elever)
            {
                //📋 Visa alla elever och deras betyg
                Console.WriteLine($"{Elev.Key} {Elev.Value}");
            }
        }
    }
}
