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
                Klasser.MenyMetod();
                string UsersChoice = Console.ReadLine()!;
                switch (UsersChoice)
                { 
                 case "1":

                        //➕ Lägga till en ny elev och betyg
                        Klasser.AddStudentAndGradeMetod(Elever);
                        break;
                        

                    case "2":

                        //🔁 Uppdatera ett befintligt betyg
                        Klasser.ChangeExistingStudentGradeMetod(Elever);
                            break;
                    case "3":
                        //📋 Visa alla elever och deras betyg
                        Klasser.ShowAllStudentsAndGradesMetod(Elever);
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
