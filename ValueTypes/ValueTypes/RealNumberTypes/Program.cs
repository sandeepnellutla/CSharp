using System;

namespace RealNumberTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float tenth = 0.1f;
            float one = 1f;
            float result = one - tenth * 10f;
            Console.WriteLine($"1f-0.1f *10f:{result}");

            float f = 1f / 6f;
            float fresult = f + f + f + f + f + f;
            double d = 1d / 6d;
            double dresult = d + d + d + d + d + d;
            decimal m = 1M / 6M;
            decimal mresult = m + m + m + m + m + m;

            Console.WriteLine($"1f/6f =>(float)f:{f}");
            Console.WriteLine($"1d/6d =>(double)d:{d}");
            Console.WriteLine($"1M/6M =>(decimal)m:{m}");
            Console.WriteLine($"f+f+f+f+f+f=>fresult:{fresult}");
            Console.WriteLine($"d+d+d+d+d+d=>dresult:{dresult}");
            Console.WriteLine($"m+m+m+m+m+m=>mresult:{mresult}");
            Console.WriteLine($"mresult==1M: {mresult==1M}");
            Console.WriteLine($"dresult<1.0: {dresult < 1.0}");
            Console.ReadKey();
        }
    }
}
