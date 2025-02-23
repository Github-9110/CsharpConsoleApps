using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Run another program from right click C#ConsoleApp1's Properties and change Startup Object.

    public class Multithread
    {
        public void printNumber(int start, int end)
        {
            for (int i = start;i<=end; i++)
            {
                Console.WriteLine("Number = "+ i);
            }
        }
    }
    internal class Multithreading01
    {
        static void Main(string[] args)
        {
            Multithread multiClass = new Multithread();

            int start = 1;
            int end = 5;

            //create thread using lamda express
            Thread thread = new Thread(() => multiClass.printNumber(start, end));

            thread.Start();   // Start the execution of thead method
            thread.Join();  // main waite untill the thread execution is not completed.

            Console.ReadLine();
        }
    }
}
