using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EvenOdd
    {
        public static void Main5(String[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Even number: " + num);
            else
                Console.WriteLine("Odd number: " + num);
        }
    }
}
