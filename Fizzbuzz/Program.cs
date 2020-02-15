using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        { 
            int brojac = 0;
            Console.Write("Unesi broj: ");
            int broj = int.Parse(Console.ReadLine());
            for (brojac = 1; brojac<=broj; brojac++)
            {
                if (brojac%3==0 && brojac%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (brojac%3==0)

                {
                    Console.WriteLine("Fizz");
                }
                else if (brojac%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(brojac);
                    Console.ReadKey();
                }
                
            }
        }
    }
}
