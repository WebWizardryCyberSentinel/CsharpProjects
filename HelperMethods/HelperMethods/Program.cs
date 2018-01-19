using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Name Game");// The name game!    

            

            Console.Write("What's your first name?  "); /// wat is je voornaam?
            string firstname = Console.ReadLine(); /// geef input
            
            Console.Write("What's your last name? "); /// wat is je achternaam?
            string lastname = Console.ReadLine(); ///geef input

            Console.Write("In what city were you born? "); /// waar ben je geboren?
            string city = Console.ReadLine();/// geef input

            DisplayResult(ReverseString(firstname), ReverseString(lastname), ReverseString(city));


            Console.ReadLine();
        }

        private static string ReverseString(string message) // ReverseString method, Neem string waarde en reverse.
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
          
        }

        private static void DisplayResult(
            string reversedFirstname, 
            string reversedLastName, 
            string reversedcity)
        {
            Console.Write("Results: ");
            Console.Write(string.Format("{0} {1} {2}",
                reversedFirstname,
                reversedLastName,
                reversedcity)); 
        }

    }
}
