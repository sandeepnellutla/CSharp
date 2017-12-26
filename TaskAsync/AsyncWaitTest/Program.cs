using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWaitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunLoopAsync();
            Console.WriteLine("Back to main...");
            Console.ReadKey();
        }

        private async static Task RunLoopAsync()
        {
            int taskid = -1;
            for (int i = 0; i < 10; i++)
            {
                var result =
                       await Task.Run(() =>
                        {
                            Random r = new Random();
                            var sleepCntr = r.Next(1, 1000);                            
                            Thread.Sleep(sleepCntr);
                            taskid = Task.CurrentId??0;
                            Console.WriteLine($"...{sleepCntr}..."); 
                            return i;
                        });

                Console.WriteLine($"--{result}--{taskid}");
            }

            Console.WriteLine("Completed Loop...");
        }
    }
}
