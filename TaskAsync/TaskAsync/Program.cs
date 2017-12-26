using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = false;
            Console.WriteLine("Started....");

            var task =
                    Task.Run(() =>
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"....{i}.... ");
                            Thread.Sleep(2000);
                        }
                    });

            task.ContinueWith((t) =>
            {
                try
                {
                    Console.WriteLine("Async With Task...");
                    Console.WriteLine("End");
                    cont = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error:{ex.ToString()}");
                }
            });


            var task2 =
                Task.Run(() =>
                {
                    while (!cont)
                    {
                        Thread.Sleep(4000);
                        Console.WriteLine($"--{task.AsyncState} --{cont}---{task.IsCompleted}--");
                    }
                });

            Task.Run(() =>
            {
                try
                {
                    while (!task2.IsCompleted)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Task 2 continues.."+ Task.CurrentId);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Task 2 " + ex.ToString());
                }
            });

            Console.ReadKey();
        }
    }
}
