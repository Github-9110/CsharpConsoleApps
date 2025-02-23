using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class StudentFour
    {
        /* Constructor does not use any datatype like void and it is case-sensitive like Classname
         * 
         * Static constructor are used to use to static members like variable or method
         */

        static int day;
        static int month;
        static int year;
        static StudentFour()
        {
            day = System.DateTime.Now.Day;
            month = System.DateTime.Now.Month;
            year = System.DateTime.Now.Year;
        }

        public static void Display()
        {
            Console.WriteLine("{0}-{1}-{2}",day,month,year);
        }
    }
    internal class StaticConstructors
    {
        static void Main(string[] args)
        {
            /* Class name Dot dispay*/
            StudentFour.Display();
            Console.ReadLine();
        }
    }
}
