using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    class PrimeOrNot
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i <= num)
            {
                if (num % i == 0)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            if (i == num)
            {
                Console.WriteLine("prime: " + num);
            }
            else
            {
                Console.WriteLine("Not a prime: " + num);
            }
        }
    }
}
