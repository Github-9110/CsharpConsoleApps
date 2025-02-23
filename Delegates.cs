using System;
using System.Security.Policy;


namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.
    public class Studentss
    {
        public void studentname(string name)
        {
            Console.WriteLine(name);
        }
    }

    //Create a Delegates
    public delegate void MyDelegate(string name);
    internal class Delegates
    {
        static void Main(string[] args)
        {
            Studentss student = new Studentss();

            MyDelegate myDel = new MyDelegate(student.studentname);
            myDel("This is Delegate concept, We have printed itself by Delegate call. myDel();.");
            Console.ReadLine();
        }
    }
}
