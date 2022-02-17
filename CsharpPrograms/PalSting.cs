using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    class PalSting
    {
        public static void Main2(String[] args)
        {
            Console.WriteLine("Enter the Sting: ");
            string str = Console.ReadLine();
            string s = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                s = s + str[i];
            }
            if (str.Equals(s, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("pal: "+s);
            }
            else
            {
                Console.WriteLine("not a pal: "+s);
            }
        }
    }
}
