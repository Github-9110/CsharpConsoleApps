using System;
using System.Data;

public class Students
{
    protected int id;
    protected string name;
    protected int age;
    protected string course;
    protected string address;

}

public class StudentGetClass : Students
{
    public void getStudents()
    {
        Console.WriteLine("Enter Student Details.........\n");

        Console.WriteLine("Enter Student Id.");
        id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter Student Name.");
        name = Console.ReadLine();

        Console.WriteLine("\nEnter Student Age.");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter Student Course.");
        course = Console.ReadLine();

        Console.WriteLine("\nEnter Student Address.");
        address = Console.ReadLine();
    }
}
public class ShowClass : StudentGetClass
{
       
    public void displayData()
    {
       
        Console.WriteLine("\nStudent Details.........\n");
        Console.WriteLine("Student Roll Number = "+id);
        Console.WriteLine("Student name = "+ name);
        Console.WriteLine("Student age = "+ age);
        Console.WriteLine("Student Course = "+ course);
        Console.WriteLine("Student Course = "+ address);

    }
}



namespace ConsoleApp1
{
    internal class MultiInheritance01
    {
        static void Main(string[] args)
        {
            ShowClass showData = new ShowClass();
            showData.getStudents();
            showData.displayData();
            Console.ReadLine();
        }
    }
}
