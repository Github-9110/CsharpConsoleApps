using System;


namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.

    public class AdditionClass
    {
        int a = 15, b = 5, c;
        public void addfun()
        {
            c = a + b;
            Console.WriteLine("Addition of a + b = "+ c);
        }
    }

    public class SubstractClass : AdditionClass
    {
        int a = 15, b = 5, c;
        public void subsfun()
        {
            c = a - b;
            Console.WriteLine("Substraction of a - b = "+c);
        }
    }

    public class MultiClass : SubstractClass
    {
        int a = 15, b = 5, c;
        public void multifun()
        {
            c = a * b;
            Console.WriteLine("Multiplication of a * b = "+c);
        }
    }


    internal class MultiInheritance
    {
        static void Main(string[] args)
        {
            MultiClass arithmatic = new MultiClass();
            Console.WriteLine("MultiInheritance Operations.\n");
            arithmatic.addfun();
            arithmatic.subsfun();
            arithmatic.multifun();
            Console.ReadLine();
        }
    }
}
