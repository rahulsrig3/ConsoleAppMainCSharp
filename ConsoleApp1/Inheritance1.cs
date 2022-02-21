using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance1
    {
        public Inheritance1()
        {
           
        }
        public void supPubMeht1()
        {
            Console.WriteLine("inside super class public method");
        }
        private void supPriMeth2()
        {
            Console.WriteLine("inside super class private method");
        }
        internal void supIntMeth3()
        {
            Console.WriteLine("inside super class internal mehtod");
        }
        protected void supProMeth4()
        {
            Console.WriteLine("inside super class protected method");
        }
        protected internal void supProIntMeth5()
        {
            Console.WriteLine("inside super class protected internal method");
        }
    }
    public class Inheritance2
    {
        //public static void subMeth1()
        //{
        //    Console.WriteLine("inside subclass method");
        //}
        public static void Main83(String[] args)
        {
            Inheritance1 in1 = new Inheritance1();
            in1.
        }
    }
}
