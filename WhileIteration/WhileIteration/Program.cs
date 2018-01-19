using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {

        //start punt applicatie
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }


        }


        //punten counter method.
        ///Echter nog niet in gebruik.
        /*private static void Punten()
        {
        int punten = 0;
        punten = Punten + 10;
          */

        //Main menu method. Maakt een menu met wat opties
        private static bool MainMenu()
        {

        
            //int punten;
           // Console.WriteLine("Je hebt: {0} punten!", punten);
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1) Printing Number");
            Console.WriteLine("2) Gok spelletje");
            Console.WriteLine("3) Exit ");
            string result = Console.ReadLine();

            //if else if om terug te komen in MainMenu, else QUIT
            ///Werkt wel, maar bugje, optie 3 moet 2 maal gebruikt worden voor EXIT.
          if (result == "1")
            { 
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if(result == "3")
            {
                return false;
            }
           else
            {
                return true;
            }
       


        }

        //Print numbers game!
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");

            Console.Write("Type een nummer:");
                          int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;

            }
            Console.ReadLine();
        }


        //Guessing game!
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(0, 11);

            int  beurten = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Raad een nummer tussen 1 en 10: ");
                string result = Console.ReadLine();
                beurten++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Fout!");
                // do while, do: voer bovenstaande code uit, tot correct returns true.
            } while (incorrect);Console.WriteLine("Yahoo! Correct, het heeft je {0} beurten gekost", beurten);
            int punten = 0;
            punten = punten + 10;
            Console.WriteLine("Je hebt {0} gewonnen! Hiep hiep, HOERA!!", punten);
            Console.ReadLine();
            

        }

    }
}
