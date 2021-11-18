using System;
using System.Threading;

namespace ConsoleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(HandleThread1);
            
            Thread thread2 = new Thread(HandleThread2);

            thread1.Start();
            thread2.Start();

            Console.WriteLine("Hello Thread!");

            while (true)
            {
                Thread.Sleep(3000);

            }
        }

        private static void HandleThread2(object obj)
        {
            while (true)
            {
                Console.WriteLine("Thread 2");
                Thread.Sleep(3000);
            }
        }

        private static void HandleThread1(object obj)
        {
            while(true)
            {
                Console.WriteLine("Thread 1");
                Thread.Sleep(3000);
            }
         }

    }
}
