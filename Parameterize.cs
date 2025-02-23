using System;

namespace ConsoleApp1
{

    public class Add
    {
        int a,b, c;
        public void add(int a, int b)
        {
            c = a + b;
            Console.WriteLine("addition = "+ c);
            
        }
    }
    public class Subs
    {
        int a, b, c;
        public void sub(int a , int b)
        {
            c = a - b;
            Console.WriteLine("substract = "+ c);
          
        }

    }

    public class Mult
    {
        int a, b, c;
        
        public void mult(int a, int b)
        {
            c = a * b;
            Console.WriteLine("multiplicaion = "+ c);
            
        }
    }
    
    public class Div
    {
        int a, b, c;
        public void div(int a, int  b)
        {
            c = a / b;
            Console.WriteLine("Division = "+ c);
            

        }
    }

    internal class Parameterize
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parameterized........");

            Add add = new Add(); // creating object of class 
            add.add(15,5);  // passing parameter

            Subs subs = new Subs();
            subs.sub(15,5);

            Mult mult = new Mult();
            mult.mult(15,5);

            Div div = new Div();
            div.div(15,5);
            Console.ReadLine();

        }
    }
}
