using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Class3
    {
        public static void Main1(String[] args)
        {
            float r = 345.343f;
            int g = (int)r;
            Console.WriteLine(g);

            char c = 'a';
            Console.WriteLine(c);

            int i = c;
            Console.WriteLine(i);

            long l = i;
            Console.WriteLine(l);

            float f = l;
            Console.WriteLine(f); // prints 97, not 97.0 because c# is typesafe (implicitly takes as 97.0)

            double d = f;
            Console.WriteLine(d);

            Boolean b = true;
            Console.WriteLine(b);

            String s = "hello";
            Console.WriteLine(s);

            decimal dc = 234.2343m; 
            Console.WriteLine(dc);

            // 'var' takes the datetype of the input value
            // 'var' should no be return type
            var v1 = 234;
            var v2 = 254.35;
            var v3 = 244.25425425;
            var v4 = "string";
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
        }
    }
}
