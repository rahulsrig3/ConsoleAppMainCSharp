using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Array
    {
        public static void Main346(String[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            String[] str = { "ab", "bc", "cd", "bc" };
            Console.WriteLine(str.Max()); 
            Console.WriteLine(str.Min());
            //String[] st = { "de", 'c', "2" };
        }
    }
}
