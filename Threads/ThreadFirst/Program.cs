using System;
using System.Threading;

namespace ThreadFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Main Thread: Do Work...");
                Thread.Sleep(0);
            }

            t.Join();

            Console.ReadKey();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc:{i}");
                Thread.Sleep(0);
            }
        }
    }
}
