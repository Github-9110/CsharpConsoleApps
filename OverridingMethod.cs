using System;

namespace ConsoleApp1
{
    public class BaseClass
    {
        int a = 15, b = 5, c;

       public virtual void sum()
        {
            c = a + b;
            Console.WriteLine("Addition of Parent/Base Class a + b = " + c);
        }

    }
   public  class DerivedClass: BaseClass
    {
        int a = 15, b = 5, c = 5, d;

        
        public override void sum()
        {
            d = a + b +c ; 
            base.sum(); // Override base class function
            Console.WriteLine("Addition of Derived/child class a + b + c = " + d);
        }
    }

    internal class OverridingMethod
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.sum();
          
            Console.ReadLine();
        }
    }
}
