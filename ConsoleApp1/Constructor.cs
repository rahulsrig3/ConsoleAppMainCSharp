using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class Constructor
    //{
    //    int i;
    //    public Constructor(int i)
    //    {
    //        this.i = i;
    //    }
    //    public static void Main(String[] args)
    //    {
    //        Constructor cos = new Constructor(10);
    //        Console.WriteLine(cos.i);
    //    }
    //}

    //class StaticConstructor
    //{
    //    static int i;
    //    int j;
    //    static StaticConstructor()
    //    {
    //        i = 10;
    //        Console.WriteLine("inside static const");
    //    }
    //    StaticConstructor()
    //    {
    //        j = 22;
    //    }
    //    public static void Main(String[] args)
    //    {
    //        Console.WriteLine("inside main method");
    //        Console.WriteLine(i);
    //        StaticConstructor sd = new StaticConstructor();
    //        Console.WriteLine(sd.j);

    //    }
    //}

    class CopyConstructor  //what is copy constructor
    {
        int x;
        int y;
        public CopyConstructor()
        {
            //this.x = 10;
            //this.y = 20;
            Console.WriteLine("in copyconstructor");
        }

        public CopyConstructor(CopyConstructor c)
        {
            //x =x + 20;
            // y =y + 20;
            Console.WriteLine("inside 2nd const");
        }

        public static void Main15(String[] args)
        {
            CopyConstructor dd = new CopyConstructor();
           // Console.WriteLine(dd.x);
           // Console.WriteLine(dd.y);
        }
    }
}
