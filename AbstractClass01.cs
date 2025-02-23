using System;

namespace ConsoleApp1
{

    public abstract class Operations
    {
        public abstract void arithmatic();
    }

    public class Sum_digit : Operations
    {
        int a = 15, b = 5, c;
        public override void arithmatic()
        {
            c = a + b;
            Console.WriteLine("sum of a + b = " + c);
        }
    }

    public class Subs_digit : Operations
    {
        int a = 15, b = 5, c;
        public override void arithmatic()
        {
            c = a - b;

            Console.WriteLine("Substraction of a - b = " + c);

        }
    }





    internal class AbstractClass01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction class and methode............");
            Sum_digit sum = new Sum_digit();
            sum.arithmatic();

            Subs_digit substract = new Subs_digit();
            substract.arithmatic();

            Console.ReadLine();
        }
    }
}
