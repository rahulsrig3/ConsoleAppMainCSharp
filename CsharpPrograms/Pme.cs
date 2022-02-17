using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    class Pme
    {
        public static void Main1(String[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rem, sum = 0;

            while (temp > 0)
            {
                rem = temp % 10;
                sum = rem + (sum * 10);
                temp = temp / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("pal: " + sum);
            }
            else
            {
                Console.WriteLine("not a pal: " + sum);
            }
        }
    }
}
