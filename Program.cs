using System;

namespace prjThreading 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";

            Thread th1 = new Thread(Print);
            th1.Name = "Thread 1";
            th1.Start();

            Thread th2 = new Thread(Print);
            th2.Name = "Thread 2";
            th2.Start();

            Thread th3 = new Thread(Print);
            th3.Name = "Thread 3";
            th3.Start();
        }
        public static void Print()
        {
            Console.WriteLine("Helo I was run inside a thread - {0}", Thread.CurrentThread.Name);

            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine(n + " {0}", Thread.CurrentThread.Name);
            }
            Thread.Sleep(5000);
        }
    }
}