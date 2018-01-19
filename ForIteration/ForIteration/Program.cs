using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loop, I is 0. Als I kleiner is dan of gelijk aan 10, increment op i met 1.

            for (int i = 0; i <= 10; i++) //zolang i kleiner is dan of gelijk is aan 10
            {
                //Console.WriteLine(i);//execute code totdat i 10 is
                if (i == 7) //if statement in de loop. Als i gelijk is aan 7
               
                {
                    Console.WriteLine("FOund Seven!"); // write message, 7 is gevonden!
                    break;
                }

            }

            for (int MyValue = 0; MyValue <= 12; MyValue++)
            {
                Console.WriteLine(MyValue);
            }

            Console.ReadLine();//als i 12 is, wordt de code geschreven naar screen

        }
    }
}
