using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice //Important concept
{
    public interface ISamsung
    {
        void m1();
    }
    
    public interface INokia
    {
        void m1();
    }

    public class User:ISamsung, INokia
    {
        void INokia.m1()
        {
            Console.WriteLine("Samsung");
        }
        void ISamsung.m1()
        {
            Console.WriteLine("Nokia");
        }
        public static void Main94(String[] args)
        {
            User u1;
            u1 = new User(); //User is the only one object using reference of ISamsung and INokia

            ISamsung sam = u1;
            INokia nok = u1;
        }
    }
}

