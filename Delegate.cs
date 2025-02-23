using System;
using System.Security.Policy;


namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.
    public class StudentsOne
    {
        public void studentname()
        {
            Console.WriteLine("I am from functions without passing parameterize in Delegate.");
        }
    }

    //Create a Delegates
    public delegate void MyDelegateOne();
    internal class Delegate
    {
        static void Main(string[] args)
        {
            StudentsOne student = new StudentsOne();

            MyDelegateOne myDelOne = new MyDelegateOne(student.studentname);
            myDelOne();
            Console.ReadLine();
        }
    }
}
