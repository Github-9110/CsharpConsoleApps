using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student1
    {
        int stid, fees;
        string name, address;

        // Constructor does not use void return type
        public  Student1()
        {
            stid = 1;
            fees = 2500;
            name = "shubham kumar";
            address = "Varansi Uttar Pradesh";

        }

        public void Displays()
        {
            Console.WriteLine("student id = "+stid);
            Console.WriteLine("student Fees = " + fees);
            Console.WriteLine("student name = " + name);
            Console.WriteLine("student address = " + address);

        }
    }
    
    internal class UserDefineDefaultConstructor
    {
        public static void Main(string[] args)
        {
            Student1 obj = new Student1();
            obj.Displays();
        }
    }
}
