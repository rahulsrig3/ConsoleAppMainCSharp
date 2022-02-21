using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodsMaxMin
    {
        public void maximum(int a, int b, int c)
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
            Console.WriteLine("Maximum value is: "+max);
        }

        public void minimum(int a, int b, int c)
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
            Console.WriteLine("Minimum value is: "+min);
        }
        public static void Main98(String[] args)
        {
            MethodsMaxMin mm = new MethodsMaxMin();
            mm.maximum(10, 20, 30);
            mm.minimum(10, 20, 30);
        }
    }
}
