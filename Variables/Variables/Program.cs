using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            

            Console.WriteLine(y);
            Console.ReadLine();
              */


            Console.WriteLine("What is your name?"); // output: Wat is je naam?
            Console.Write("Type your first name:"); //output: Wat is je voornaam?
            string myFirstName; // Variabelen waar de voornaam gestored kan worden.
        
            myFirstName = Console.ReadLine(); //geef input waarde voor myFirstName


            /*string myLastName; //variabelen waar de achternaam gestored staat
            Console.Write("Type your last name"); //output: Wat is je voornaam?
            myLastName = Console.ReadLine(); // geef input waarde voor myLastName*/

            Console.WriteLine("Type your last name:");//output: Type Je naam
            string myLastname = Console.ReadLine();// geef input waarde voor mylastname

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName); //Output: Hallo, waarde myFirstname plus waarde myLastname
            Console.ReadLine();// Toon in console...
            
       }
    
    }
}
