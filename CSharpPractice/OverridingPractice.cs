using System;
using System.Collections.Generic;
//using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class OverridingPractice
    {
        public virtual void over1()
        {
            Console.WriteLine("inside over1 superclass method:");
        }
        public virtual void over2()
        {
            Console.WriteLine("inside over2 superclass method:");
        }
    }
    public class SubClassOver:OverridingPractice
    {
        public void over3()
        {
            Console.WriteLine("inside over3 subclass method");
        }
        public override void over1()
        {
            Console.WriteLine("inside over1 subclass method");
        }
        public override void over2()
        {
            Console.WriteLine("inside over2 subclass method");
        }
        public static void Main37   (String[] args)
        {
            //SubClassOver sub = new SubClassOver();
            //sub.over1();
            //sub.over2();
            //sub.over3();

            //OverridingPractice over = new OverridingPractice();
            //over.over1();
            //over.over2();
            //over.over3();

            OverridingPractice overri = new SubClassOver();
            overri.over1();
            overri.over2();
            //overri.over3(); //subclass methods are not allowed to access when we upcast to super class


            //HashSet<String> set = new HashSet<String>();
            //LinkedList<String> list = new LinkedList<String>();
            //ArrayList<String> array = new ArrayList<String>(); 

        }
    }
}
