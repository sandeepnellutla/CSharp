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
            Console.WriteLine($"Before Checked: a-1: {a - 1}");
            Console.WriteLine($"Before Checked: b+1: {b + 1}");
            

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
