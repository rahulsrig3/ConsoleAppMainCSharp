using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AvgOfThree
    {
        public static void Main8(String[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            double a3 = Convert.ToDouble(Console.ReadLine());

            double avg = (a1 + a2 + a3) / 3;
            Console.WriteLine("The average of the Three numbers is: " + avg);
        }
    }
}
