using System;


namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.

    public class Addition
    { 
        int a = 15, b = 5, c; // Instance variable
        public void addition()
        {
            c = a + b;
            Console.WriteLine("Addition = "+c);

        }
    }
    
    public class Substract
    {
        int a =15, b = 5, c;
        public void substract()
        {
            c = a - b;

            Console.WriteLine("Substract = "+c);
        }
    }
    
    
    public class Multiplication
    {
        int a = 15, b = 5, c;

        public void multiplication()
        {
            c = a * b;
            Console.WriteLine("Multiplication = "+ c);
        }

    }

    public class Division
    {
        int a = 15, b = 5, c;

        public void division()
        {
            c = a / b;

            Console.WriteLine("Division = "+ c);
        }
    }
    
    internal class Arithmatics
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            addition.addition();

            Substract substract = new Substract();
            substract.substract();

            Multiplication multiplication = new Multiplication();
            multiplication.multiplication();

            Division division = new Division();
            division.division();

            Console.ReadLine();
        }
    }
}
