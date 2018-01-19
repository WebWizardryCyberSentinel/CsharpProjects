using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Martin's Big Giveaway"); // OUTPUT
            Console.Write("Choose a door: 1, 2 or 3"); // OUTPUT
            string userValue = Console.ReadLine(); // Geef input waarde aan variabelen en print in de console.


            string message = "";// string voor antwoorden...

            //IF functie, dus als waarde userValue gelijk is aan 1, OUTPUT message : You've won a new car!
            if (userValue == "1")
                message = "You've won a new car!";
            

            //ELSE IF functie, dus als waarde userValue niet gelijk is aan 1 maar gelijk is aan 2; OUTPUT message: You've won a new boat!
            else if (userValue == "2")
                     message = "You've won a new boat!";
            

            //ELSE IF functie, dus als waarde userValue niet gelijk is aan 1 of 2 maar gelijk is aan 3; OUTPUT message: You've won a new cat!
            else if (userValue == "3")
                     message = "you've won a new cat!";
           
            //ELSE functie, dus als waardes userValue niet gelijk zijn aan 1,2 of 3. OUTPUT message: sorry we didn't understand.
            else
            {
                message = "Sorry, we didn't understand.";
                message = message +"You Lose, Sucker.";
            }

            Console.WriteLine(message); //OUTPUT: Bericht a.d.v input userValue variabele
            Console.ReadLine();
            */

            Console.WriteLine("Martin's Big Giveaway"); // OUTPUT
            Console.Write("Choose a door: 1 or 2"); // OUTPUT
            string userValue = Console.ReadLine(); // Geef input waarde aan variabelen en print in de console.


            //Ifelse conditie met een tweetal keuzes.

            //Als waarde gelijk is aan 1 OUTPUT Boat. Alse waarde negatief is OUTPUT Strand of lint.
            string message = (userValue == "1") ? "boat" : "strand of lint";

            // Manier om output te tonen:
            //Console.Write("You've won a ");//OUTPUT:
            //Console.Write(message);//OUTPUT: Variabele message.
            //Console.Write(".");


            //Efficiënterre manier om output te tonen a.d.v tweetal of meerdere keuzes.
            
            //Console.WriteLine("You've won a {0}", message)

            // 0 geeft waarde userValue, 1 geeft waarde message.
            Console.WriteLine("You've entered: {0}, Therefore you've won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}
