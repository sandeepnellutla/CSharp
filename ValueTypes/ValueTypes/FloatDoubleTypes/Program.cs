using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoubleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float fa = 1f;
                double da = 1d;

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("-------------- FLOAT ------------------------");
                Console.WriteLine($"Float fa =1f Value:{fa}");
                Console.WriteLine($"float infinity +:{float.PositiveInfinity}");
                Console.WriteLine($"float infinity -:{float.NegativeInfinity}");
                Console.WriteLine($"float infinity NAN:{float.NaN}");
                Console.WriteLine($"float negative zero:{-0.0f}");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"1.0 / 0.0: {1.0/0.0}");
                Console.WriteLine($"-1.0 / 0.0: {-1.0 / 0.0}");
                Console.WriteLine($"1.0 / -0.0: {1.0 / -0.0}");
                Console.WriteLine($"-1.0 / -0.0: {-1.0 / -0.0}");
                Console.WriteLine($"-0.0 / -0.0: {-0.0 / -0.0}");
                Console.WriteLine($"-0.0 / 0.0: {-0.0 / -0.0}");
                Console.WriteLine($"0.0/0.0 == double.NAN:{(0.0 / 0.0 == double.NaN)}");
                Console.WriteLine($"(0.0 / 0.0).Equals(double.NaN):{(0.0 / 0.0).Equals(double.NaN)}");
                Console.WriteLine($"double.IsNaN(0.0/0.0):{double.IsNaN(0.0 / 0.0)}");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("-------------- DOUBLE -----------------------");
                Console.WriteLine($"Float da =1d Value:{da}");
                Console.WriteLine($"Double infinity +:{double.PositiveInfinity}");
                Console.WriteLine($"Double infinity -:{double.NegativeInfinity}");
                Console.WriteLine($"Double infinity NAN:{double.NaN}");
                Console.WriteLine($"Double negative zero:{-0.0d}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
