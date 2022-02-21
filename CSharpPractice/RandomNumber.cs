using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class RandomNumber
    {
        //public void random()
        //{

        //}
        public static void Main2452(String[] args)
        {
            Random random = new Random();
            int rNum;
            for (int i = 0; i < 52; i++)
            {
                rNum = random.Next(53);
                Console.Write(rNum + " ");
            }
           // Console.WriteLine(rNum);
        }
    }
}
