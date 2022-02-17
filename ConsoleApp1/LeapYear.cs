using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class LeapYear
    //{
    //    public static void Main4(String[] args)
    //    {
    //        Console.WriteLine("Enter the year: ");
    //        int year = Convert.ToInt32(Console.ReadLine());

    //        if (year%4!=0)
    //        {
    //            Console.WriteLine("not a leap year");
    //        }
    //        else if (year%400==0)
    //        {
    //            Console.WriteLine("is a leap year");
    //        }
    //        else if (year % 100 == 0)
    //        {
    //            Console.WriteLine("not a leap year");
    //        }
    //        else
    //        {
    //            Console.WriteLine("is a leap year");
    //        }
    //    }
    //}

    class Sample
    {
        public static void Main4(String[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 400 == 0) && (year % 100 == 0))
            {
                Console.WriteLine("is a leap year");
            }
            else if (year % 4 == 0 && year % 100 == 0)
            {
                Console.WriteLine("not a leap year");
            }
            else
            {
                Console.WriteLine("is leap year");
            }
        }
    }
}
