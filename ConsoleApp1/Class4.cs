using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        public static void Main3(String[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the qualifications: ");
            string qual = Console.ReadLine();

            Console.WriteLine("Enter the Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The name is "+name+" and the qualification is "+qual+" of "+age);
        }
    }
}
