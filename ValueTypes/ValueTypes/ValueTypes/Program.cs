using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.MinValue;

            Console.WriteLine($"Min Value :: {a}");

            //this will overflow. resulting in int.MaxValue. This is called "Wraparound" behaviour.
            a = a-1;

            Console.WriteLine($"Min Value :: {a}");

            Console.ReadKey();
        }
    }
}
