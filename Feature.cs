using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Feature
    {
        public static void Name()
        {

            Console.WriteLine("Enter your mother's birth year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("You were born in "+year+" !");
        }
    }
}
