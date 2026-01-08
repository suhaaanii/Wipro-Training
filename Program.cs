using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Whos this");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + " !");

            Console.WriteLine("Whats ur age?");
            string ageInput = Console.ReadLine();
            int age;
            bool isValidAge = int.TryParse(ageInput, out age);
            if (isValidAge)
            {
                if (age>=18)
                {
                    Console.WriteLine(" Can Vote");
                }
                else
                {
                    Console.WriteLine(" Can't Vote");
                }
            }
            else
            {
                Console.WriteLine(" Error invalid");
            }

            }
    }
}