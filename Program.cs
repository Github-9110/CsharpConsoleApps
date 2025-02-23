using System;  // This is the namespace which contains to classes like Console.write,writeline ect;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace FirstProjectC_
{

  //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.
    internal class Program // This is class which contains to data and methods i.e. these are members.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worlds"); // This is write line and moved for next paragraph line

            Console.Write("I love to c#"); // This is write the line but not moves for next paragraph while the next content start from current line
            Console.WriteLine("C#.Net");

            Console.WriteLine("\nDATATYPES IN C#");
            // DataTypes in C# 

            /* Integer - int --> 4 bytes 
               long - 8 bytes
               Floating - float --> 4 bytes
               Double - 8 bytes
               Character - char ---> 2bytes 
               String - 2 bytes per character
               boolean - 1 bits

            Note - we must be specify to Double value with D and Float with F.
            EXample : Double x = 67.8D , Float y = 67.8F;
            */
            int a = 2; int b = 3;
            float c = 12.0F; float d = 21.0F;
            Double e = 10.1D;
            Boolean isOK = true;
            String s = "First gives to priority of Bracket's operant then concatinate to string. \nWithout bracket concatinate all as string. ";
            Console.WriteLine("Sume = " + (a + b));
            Console.WriteLine("Sume = " + (c + d));
            Console.WriteLine("Sume of Double & Float = " + (d + e));
            Console.WriteLine(isOK);
            Console.WriteLine(s);

            /* Type Casting / Datatype Conversion - 
             1 - Implecite - Converted by Compiler
                 (char -> Int -> long -> float -> Double) : Datatype conversion convert to datatype by this heirarichy not Opposite direction heirarichy.
             2-  Explicite - Converted by Users : Convert to datatype forcefully by using prefix before data or data's variable.
                 Explain : float x = 5.12F;
                 Converted : int y = (int) x; int -> (prefix) Data/variable;
             */
            Console.WriteLine("\nDatatype conversion\n");
            /* This is implecite conversion. */
            char cr = 'b'; /* --> */ int it = cr;
            int f = 11;    /* --> */ long lg = f;

            long lng = 341; /* --> */ float flt = lng;

            float ft = 5.9f; /* --> */ double db = ft;

            Console.WriteLine("char -> int = " + it);
            Console.WriteLine("int -> long = " + lg);
            Console.WriteLine("long -> float = " + flt);
            Console.WriteLine("float -> double = " + db);

            /*This Explecite conversion. */
            Console.WriteLine("\nExplicite Conversion.\n");
            char ch = 'a';
            int chI = (int)ch;

            float fl = 4.4F;
            int ftI = (int)fl;

            double dbl = 45.01D;
            long dblg = (long)dbl;

            Console.WriteLine(chI);
            Console.WriteLine(ftI);
            Console.WriteLine(dblg);

            /* Operators in C#
             
             arithmatic operator
             logical operator
             binary operator
             ternary operator
             aasignment operator
             
             */

            Console.WriteLine("\nArithmatic operator.");
            int x = 4; int y = 2;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine("\n");


            if (x > y)
            {
                Console.WriteLine("X value is greater.");
            }
            if (x / y == y)
            {
                Console.WriteLine("Y value is equal to division's value.\n");
            }
            String sa = (x >= x) ? "X is greater value " + x : "X is smaller value";

            Console.WriteLine("Assignment Operator\n");
            x += x;
            Console.WriteLine("x += x => " + x);
            x -= y;
            Console.WriteLine("x -= x => " + x);
            x /= y;
            Console.WriteLine("x /= x => " + x);
            x *= y;
            Console.WriteLine("x *= x => " + x);

            Console.WriteLine("Ternary Operator\n");
            Console.WriteLine(sa);

            /* Control & Loop statement
               if, if...else, if..elseIf....else
             */
            Console.WriteLine("Control& Loop statement \n");
            if (x > y)
            {
                Console.WriteLine("X value is greater.\n");
            }

            Console.WriteLine("Print number by loop.");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); // This is hold to console for readline 

            
        }
    }
}
