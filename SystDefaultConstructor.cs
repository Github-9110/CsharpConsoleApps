using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ConsoleApp1
{

     public class Employee
        {
            int emId;
            String name, address;

        // Constructor does not use void return type if it use it means a regular method not constructor
        public void Emplyoee()
            {
            Console.WriteLine("In this system default constructor\n Default Value will be initialized.\n For inter will zero and for string NULL value\n which will not visible null value\n. ");
                Console.WriteLine("Employee " + emId);
                Console.WriteLine("Employee'name" + name);
                Console.WriteLine("Employee = " + address);

            }

        }
    internal class SystDefaultConstructor
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadLine();
        }

    }
}
