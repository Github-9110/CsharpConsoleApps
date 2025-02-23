using System;
using System.Security.AccessControl;


namespace ConsoleApp1
{
    public class Student
    {
        private string name;
        private string course;
        private int fees;

        public string Name // Properties
        {
            get { return name; }
            set { name = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public int Fees
        {
            get { return fees; }
            set { fees = value; }
        }
    }


    internal class Properties
    {
       static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Shubham Kumar";
            s.Course = "ASP.NET + ASP.NET MVC + MVC Core";
            s.Fees = 15000;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Course);
            Console.WriteLine(s.Fees);
            Console.ReadLine();
        }
    }
}
