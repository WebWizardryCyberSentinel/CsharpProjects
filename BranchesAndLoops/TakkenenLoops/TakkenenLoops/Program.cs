using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakkenenLoops
{
    class Program
    {

        /*Gebleven bij Branches en loops:
        
     Use loops to repeat operations
    In this section you use loops to repeat statements. Try this code in your Main method:*/

        static void Main(string[] args)
        {
            TakkenenLoops();
        }

        static void TakkenenLoops()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if (a + b > 10)
            {
                Console.WriteLine("Het antwoord is groter dan 10");
                
            }

            else
            {
                Console.WriteLine("The answer isn't greater than 10");
               
            }


            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("Het antwoord is groter dan 10");
                Console.WriteLine(" Het eerste nummer is groter dan de tweede");
            }
            else
            {
                Console.WriteLine("Het antwoord is niet groter dan 10");
                Console.WriteLine("Het eerste nummer is niet groter dan de tweede.");
            }
            
            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("Het antwoord is  groter dan 10");
                Console.WriteLine("of het eerste nummer is groter dan het tweede nummer");
            }
            else
            {
                Console.WriteLine("Het antwoord is niet groter dan 10");
                Console.WriteLine("En het eerste nummer is niet groter dan het tweede nummer");
            }
            Console.ReadLine();
        }



    }
}