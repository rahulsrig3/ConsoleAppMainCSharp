using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpPractice
{
    class Collections01
    {
        public static void Main78(String[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("capacity before adding first element: " + arr.Capacity);
            arr.Add(10);
            Console.WriteLine("capacity after adding the first element: " + arr.Capacity);
            arr.Add(4);
            Console.WriteLine("capacity after adding the second element: " + arr.Capacity);
            arr.Add(8);
            Console.WriteLine("capacity after adding the third element: " + arr.Capacity);
            arr.Add(16);
            Console.WriteLine("capacity after adding the fourth element: " + arr.Capacity);
            arr.Add(67);
            Console.WriteLine("capacity after adding the fifth element: " + arr.Capacity);
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }

            arr.Insert(3, 90);
            Console.WriteLine("****************************");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********************************");
            arr.Remove(67);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
