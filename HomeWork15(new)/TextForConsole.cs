using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork15_new_
{
    internal class TextForConsole
    {
        private Random random = new Random();
        public void PrintText(object o)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"ID текущего потока {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(random.Next(2000,4000));
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Конец работы потока с ID {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
