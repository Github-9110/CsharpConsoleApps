using System;

namespace ConsoleApp1
{    

    public abstract class Students
    {
        protected int id;
        protected string name;
        protected string course;
        protected string address;

        public abstract void showDatas();  // which contains abstract the abstract and public the method declaration and 
        public void getData() // method definition and we can create the instance of the abstract class.
        {
            Console.WriteLine("Enter Student details..\n");
            Console.WriteLine("Enter Student id..");

            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name...");
            name = Console.ReadLine();

            Console.WriteLine("Enter Student course....");
            course = Console.ReadLine();

            Console.WriteLine("Enter Student Address....");
            address = Console.ReadLine();
        }

    }

    public class StudentsDetails : Students
    {
        public override void showDatas()
        {
            Console.WriteLine("\nStudent Details....");
            Console.WriteLine("student id = "+ id);
            Console.WriteLine("student name = " + name);
            Console.WriteLine("student course = " + course);
            Console.WriteLine("student address = " + address);
        }
    }

    internal class AbstractClass
    {
        static void Main(string[] args)
        {
            StudentsDetails details = new StudentsDetails();
            details.getData();
            details.showDatas();
            Console.ReadLine();
        }
    }
}
