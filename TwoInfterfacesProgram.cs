using System;

namespace ConsoleApp1
{
     interface One_Interface
    {
        void add();
    }

    interface Second_Interface
    {
        void substract();
    }

    public class Operation: One_Interface, Second_Interface
    {
        int a, b, c;
        public void add()
        {
            Console.WriteLine("Enter value of a and b....\n");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum of a + b = "+ c);
        }


        public void substract()
        {

            c = a - b;
            Console.WriteLine("\nSubstraction of a - b = "+c);
        }


    }


    internal class TwoInfterfacesProgram
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.add();
            operation.substract();
            Console.ReadLine();
        }
    }
}
