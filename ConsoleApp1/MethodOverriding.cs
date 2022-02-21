using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodOverriding
    {
        public void add(int i )
        {
            Console.WriteLine("in superclass method");
        }
    }
    class MethodOverriding2:MethodOverriding
    {
        
    }
}
