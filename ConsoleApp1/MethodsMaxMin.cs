using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodsMaxMin
    {

        public static int maximum(int a, int b, int c)
        {
            int a1 = a;
            int a2 = b;
            int a3 = c;
            int max;
            if (a1 > a2)
                if (a1 > a3)
                    max = a1;
                else
                    max = a3;
            else
                if (a2 > a3)
                    max = a2;
                else
                    max = a3;
            return max;
        }

        public static int minimum(int a, int b, int c)
        {
            int a1 = a;
            int a2 = b;
            int a3 = c;
            int min;
            if (a1 < a2)
                if (a1 < a3)
                    min = a1;
                else
                    min = a3;
            else
                if (a2 < a3)
                    min = a2;
                else
                    min = a3;
            return min;
        }
        public static void Main44(String[] args)
        {
            int max = maximum(10, 20, 30);
            int min = minimum(10, 20, 30);

            Console.WriteLine("maximum number is: "+max);
            Console.WriteLine("minimum number is: "+min);
        }
    }
}
