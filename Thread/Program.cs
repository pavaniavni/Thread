using System;
using System.Threading;

namespace Threading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread th = Thread.CurrentThread;
            Console.WriteLine(th);
        }
    }
}

