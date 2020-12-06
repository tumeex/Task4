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

            Console.WriteLine("Enter your accurate legal age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are "+age+" years young!");
        }
    }
}
