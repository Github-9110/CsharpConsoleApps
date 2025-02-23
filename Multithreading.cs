using System;
using System.Threading;

namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.

    public class MultithreadClass
    {
        public void printNumbers()
        {
            for (int i =1; i<=5; i++)
            {
                Console.WriteLine("Number = "+ i);
            }
        }
    }
    internal class Multithreading
    {
        
       static void Main(string[] args)
        {
            MultithreadClass multithreads = new MultithreadClass();

            Thread thread = new Thread(() => multithreads.printNumbers());
            thread.Start(); // start the execution of method
            thread.Join(); // main waite until execution is not completed
            Console.WriteLine();
        }
    }
}
