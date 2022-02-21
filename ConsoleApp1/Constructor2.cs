using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Constructor1
    {
        public Constructor1()
        {
            Console.WriteLine("inside constructor1 zero parameter");
        }
    }
    class Constructor2:Constructor1
    {
        public Constructor2():this(10,20)
        {
            Console.WriteLine("inside zero parameter constructor");
        }
        public Constructor2(int a, int b):this(10,20,30)
        {
            Console.WriteLine("inside two int parameter constructor");
        }
        public Constructor2(int a, int b, int c):this("CSharp",10,35.342552)
        {
            Console.WriteLine("inside three int parameter constructor");
        }
        public Constructor2(String name, int a, double b)
        {
            
            Console.WriteLine("inside different three parameter constructor");
        }
        public static void Main47(String[] args)
        {
            Constructor2 cc = new Constructor2();
        }
    }
}
