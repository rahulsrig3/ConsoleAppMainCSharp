using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOfThree
    {
        public static void Main9(String[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of Three numbers is: "+(a1+a2+a3));
        }
    }
}
