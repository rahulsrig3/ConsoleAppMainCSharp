using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FindMinOfThree
    {
        public static void Main7(String[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int a3 = Convert.ToInt32(Console.ReadLine());

            if (a1 <= a2)
                if (a1 <= a3)
                    Console.WriteLine(a1 + " : is the Minimum");
                else
                    Console.WriteLine(a3 + " : is the Minimum");
            else
                if (a2 <= a3)
                    Console.WriteLine(a2 + " : is the Minimum");
                else
                    Console.WriteLine(a3 + " : is the Minimum");
        }
    }
}
