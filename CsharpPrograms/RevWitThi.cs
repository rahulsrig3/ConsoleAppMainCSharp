using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class RevWitThi
    {
        public static void Main3(String[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int count = 0;
            foreach (char c in ch)
            {
                count++;
            }
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
