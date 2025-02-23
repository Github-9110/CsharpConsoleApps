using System;


namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.

    interface PahalaInterface
    {
       void add();  // No Implementation
    }

    interface SecondInterface
    {
        void substract(); //No implemention
    }

    public class Multiply
    {
        int a = 15, b = 5, c;
        public void multi()
        {
            c = a * b;
            Console.WriteLine("\nMultiplication of a * b = " + c);
        }
    }

    public class ArithmaticOperation : Multiply, PahalaInterface, SecondInterface 
    {
        int a = 15, b = 5, c;
        public void add()
        {
            c = a + b;
            Console.WriteLine("Sum of a + b = "+ c);
        }

        public void substract()
        {
            c = a - b;
            Console.WriteLine("\nSubstraction of a - b = "+c);
        }
       
    }
    internal class ClassAndTwoInterface
    {
        static void Main(string[] args)
        {
            ArithmaticOperation operation = new ArithmaticOperation();
            operation.add();
            operation.substract();
            operation.multi();
            Console.ReadLine();
        }
    }
}
