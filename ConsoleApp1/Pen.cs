
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pen
    {
        public String brand;
        public int price;
        public String color;
        public Pen(String brand, int price, String color)
        {
            this.brand = brand;
            this.price = price;
            this.color = color;
        }

        public static void write()
        {
            Console.WriteLine("write with this pen");
        }
        public override string ToString()
        {
            return this.brand+" "+this.price+" "+this.color;
        }
        public static void Main90()
        {
            Pen op = new Pen("parker", 1000, "red");
            Console.WriteLine(op); //we will get the address without using toString and override
        }
    }

    //public class Pen2
    //{
    //    public static void Main(String[] args)
    //    {

    //    }
    //}
}
