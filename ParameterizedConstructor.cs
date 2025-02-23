using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ConsoleApp1
{
    internal class ParameterizedConstructor
    {
        public class StudentTwo
        {
            int ids, fees;
            String names, ages;
             
            // Constructor doe not use void and name Case-sensitive as class name
            public StudentTwo(int id, int fee, string name, int age)
            {
                ids = id;
                fees = fees;
                names = name;
                ages = Convert.ToString(age);
            }

            public void display()
            {

                Console.WriteLine("student ids = " + ids);
                Console.WriteLine("student fees = " + fees);
                Console.WriteLine("student names = " + names);
                Console.WriteLine("student ages = " + ages);
            }

        }
        public static void Main()
        {
            StudentTwo student = new StudentTwo(24, 2500, "Shyam Singha", 28);
            student.display();
            Console.ReadLine();
        }
    }
}
