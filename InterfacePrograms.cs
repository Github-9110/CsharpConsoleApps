using System;


namespace ConsoleApp1
{
    interface OneInterface
    {
        void sum(); // No Implementation
        void multi(); // No Implementation
    }

    class SecondClass : OneInterface
    {
        int a = 15, b = 5, c, d;

       public void sum()
        {
            c = a + b;
            Console.WriteLine("Addition  by interface of c = "+c);
        }

        public void multi()
        {
            Console.WriteLine("Enter two value\n");
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            d = e * f;
            
            Console.WriteLine("Mulitplicaion of e * f = "+ d);
        }
    }


    internal class InterfacePrograms
    {
        static void Main(string[] args)
        {
            SecondClass secondClass = new SecondClass();
            secondClass.sum();
            secondClass.multi();
            Console.ReadLine();
        }
    }
}
