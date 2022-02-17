using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseTheString
    {
        public static void Main55(String[] args)
        {
            string str = "I am an engineer";
            string rev = "";
            String[] s = str.Split(" ");
            for (int i = 0; i < s.Length; i++)
            {
                string r = s[i];
                for (int j = r.Length-1; j >= 0 ; j--)
                {
                    rev = rev + r[j];
                }
                rev = rev + " ";
            }
            Console.WriteLine(rev);
            String[] rev2 = rev.Split(" ");
            for (int i = rev2.Length-1; i >= 0; i--)
            {
                Console.Write(rev2[i]+" ");
            }
        }
    }
}
