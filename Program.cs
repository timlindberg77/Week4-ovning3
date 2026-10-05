using System.Xml;

namespace Week4_ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en konsolapplikation som lagrar och hanterar studentbetyg med hjälp av en Dictionary<string, int>.

            //I menyn ska användaren kunna:

            bool KeepRunning = true;
            Dictionary<string, int> Elever = new Dictionary<string, int>();
            while (KeepRunning)
            {
                Console.WriteLine("Välkomen");
                Console.WriteLine("1: Lägg till ny elev + Betyg");
                Console.WriteLine("2: Uppdatera befintligt betyg");
                Console.WriteLine("3: Visa alla elever och deras betyg");
                Console.WriteLine("4: Beräkna och visa medelbetyget");
                Console.WriteLine("5: Avsluta");
                string UsersChoice = Console.ReadLine()!;
                switch (UsersChoice)
                { 
                 case "1":
                        
                            //➕ Lägga till en ny elev och betyg
                            Console.WriteLine("Skriv ElevNamn");
                            string Namn = Console.ReadLine()!;
                            Console.WriteLine("Skriv in betyg");
                            int Betyg = int.Parse(Console.ReadLine()!);
                            Elever.Add(Namn, Betyg);
                            break;
                        

                    case "2":
                        
                            //🔁 Uppdatera ett befintligt betyg
                            Console.WriteLine("Skriv elevnamn");
                            string UppdateraNamn = Console.ReadLine()!;
                            if (Elever.ContainsKey(UppdateraNamn))
                            {
                                Console.Write("Nytt betyg: ");
                                int.TryParse(Console.ReadLine(), out int nyttBetyg);
                                Elever[UppdateraNamn] = nyttBetyg;
                            }
                            break;
                    case "3":
                        //📋 Visa alla elever och deras betyg
                        foreach (var Elev in Elever)
                        {
                            Console.WriteLine($"{Elev.Key} {Elev.Value}");
                        }
                        break;

                    case "4":
                        //🧮 Beräkna och visa medelbetyget
                        Console.WriteLine($"Medelvärdet {Elever.Values.Average():F1}");
                        break;
                    case "5":
                        KeepRunning = false;
                        break;
                }
            }


            //💡 Tips:
            //Använd dictionary.ContainsKey() för att kontrollera om eleven redan finns.
            //Använd foreach (var elev in dictionary) för att visa alla.
        }
    }
}
