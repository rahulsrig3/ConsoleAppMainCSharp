using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GuessTheNumber
    {   
        public static void Main88(String[] args)
        {
            //Console.WriteLine("Random number:" + num);
            int count = 0;
            while (count < 5)
            {
                Random ran = new Random();
                int num = ran.Next(20);

                Console.WriteLine("Guess the number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > num)
                {
                    Console.WriteLine("The number is greater than Random number");
                    Console.WriteLine("The Original Random number was: " + num);
                }
                else if (guess < num)
                {
                    Console.WriteLine("The number is less than Random number");
                    Console.WriteLine("The Original Random number was: " + num);
                }
                else
                {
                    Console.WriteLine("The number is equal to Random number: "+num);
                    Console.WriteLine("YOU WON!!!");
                    break;
                }
                count++;
            }
            if (count == 5)
            {
                Console.WriteLine("Sorry...The number of trials are over.");
            }
        }
    }
}
