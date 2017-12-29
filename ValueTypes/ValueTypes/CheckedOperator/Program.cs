using System;

namespace CheckedOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "";
            int a = int.MinValue;
            int b = int.MaxValue;

            try
            {
                checked
                {
                    a = a - 1;
                    b = b + 1;
                }
            }
            catch (Exception ex)
            {
                a = 0;
                b = 0;
                value = ex.ToString();

                Console.WriteLine($"Exception: {ex}");
            }
            value = a.ToString();
            Console.WriteLine($"Min Value -1:{value}");

            value = b.ToString();
            Console.WriteLine($"Max Value +1 Unchecked:{value}");
            Console.ReadKey();
        }
    }
}
