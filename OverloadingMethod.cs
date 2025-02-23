using System;


namespace ConsoleApp1
{

    public class Arithmatic
    {
        int a, b, c,d;

        public void sum(int a)
        {
            
            Console.WriteLine("Single value" + a);
        }
        public void sum(int a, int b)
        {
            c = a + b;
            Console.WriteLine("Addition a+b = " + c);
        }

        public void sum(int a, int b, int c)
        {
            d = a + b + c;
            Console.WriteLine("Addition a+b+c = " + d);
        }
    }


    internal class OverloadingMethod
    {
        static void Main(string[] args)
        {
            Arithmatic arithmatic = new Arithmatic();
            Console.WriteLine("Method Overloading............\n");
            arithmatic.sum(15);
            arithmatic.sum(15,5);
            arithmatic.sum(15,5,6);
            Console.ReadLine();
        }
    }
}
