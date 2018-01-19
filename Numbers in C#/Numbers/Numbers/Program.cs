using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {

        //Working with integers method.
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 16;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }

        //another working with integers method.
        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.ReadLine();

            d = (a + b) - 6 * c + (12 * 3) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;

        }

        //main void method,roept WorkingWithIntegers aan.
        static void Main(string[] args)
        {
            //WorkingWithIntegers();
            OrderPrecedence();
        }
    
    }
}
