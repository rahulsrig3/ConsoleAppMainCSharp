using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpPractice
{
    public class StringClass
    {
        
        public static void Main38(String[] args)
        {
            //String s = "Rahul";
            //Console.WriteLine(s.GetHashCode());
            //s = s + "tyss";
            //Console.WriteLine(s.GetHashCode());

            //StringBuilder sb = new StringBuilder("Rahil");
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append("patel");
            //Console.WriteLine(sb.GetHashCode());


            String s = "Rahul";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                s = s + i;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            StringBuilder sb = new StringBuilder();
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i <= 100000; i++)
            {
                s = s + i;
            }
            st.Stop();    //stop watch operations like restart, reset,
            Console.WriteLine(st.ElapsedMilliseconds);
        }
    }
}
