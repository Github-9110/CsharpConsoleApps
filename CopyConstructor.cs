using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentThree
    {
        int stid;
        string stname;
        public  StudentThree(int id, string name)
        {
            stid = id;
            stname = name;
        }

        public  StudentThree(StudentThree obj) //Copy constructors pass Class name as parameter
        {
            stid = obj.stid;
            stname = obj.stname;
        }

        public void display()
        {
            Console.WriteLine("student id = " + stid);
            Console.WriteLine("student name = " + stname);
        }
    }
    internal class CopyConstructor
    {
        public static void Main(string[] args)
        {
                StudentThree obj = new StudentThree(12, "Vishwa sir"); // create instance of class
                StudentThree obj1 = new StudentThree(obj); // create copy of main instance created of class

               Console.WriteLine("Main constructors..");
               obj.display();

            Console.WriteLine("\n Created copy constructor of Object obj..");
            obj.display();
            Console.WriteLine();
        }
    }
}
