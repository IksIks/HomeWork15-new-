using System;
using System.Threading;

namespace HomeWork15_new_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(new TextForConsole().PrintText));
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
