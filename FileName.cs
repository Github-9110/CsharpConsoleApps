using System;


namespace ConsoleApp1
{
    /* This is class and Object Programs*/
    class OneClass
    {
        public void Message()
        {
            Console.WriteLine("One Message of OneClass Program.\n");
        }
    }

    class TwoClass {
         public void Message()
        {
            Console.WriteLine("This is Second message of TwoClass.\n");
            Console.WriteLine("We can create same method name with Different Class, but not same class.");
        }
    }

    internal class FileName
    {
       public static void Main(string[] args)
        {
            OneClass oneClass = new OneClass(); // FileName.cs file
            oneClass.Message();
            TwoClass twoClass = new TwoClass();
            twoClass.Message();
            Console.ReadLine();
        }
    }

}
