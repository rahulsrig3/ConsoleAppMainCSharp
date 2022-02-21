using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpPractice
{
    class Collection02
    {
        public static void Main454(String[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Rahul");
            ht.Add(27, "age");
            ht.Add("location", "bengaluru");
            ht.Add("number", 23);
            
            foreach (Object key in ht.Keys)
            {
                Console.WriteLine(key+":"+ht[key]);  //insertion order is not maintained
            }
        }
    }
}
