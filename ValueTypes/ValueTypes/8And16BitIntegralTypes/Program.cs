using System;

namespace _8And16BitIntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                short x = 1;
                short y = 1;
                checked
                {
                    short z = (short)(x + y);
                    Console.WriteLine($"Final:{ x + y}");
                    Console.WriteLine($"Z Value:{z}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
