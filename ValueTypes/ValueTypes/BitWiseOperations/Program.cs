using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWiseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 11;

            var result = a & b;
            ShowOperationMsg(a, b, "&", result.ToString(), Convert.ToString(result, 2));

            result = a | b;
            ShowOperationMsg(a, b, "|", result.ToString(), Convert.ToString(result, 2));

            result = ~b;
            ShowOperationMsg(null, b, "~", result.ToString(), Convert.ToString(result, 2));

            Console.ReadKey();
        }

        protected internal static void ShowOperationMsg(int? a, int b, string operation, string value, string binaryValue)
        {
            var binaryA = Convert.ToString(a ?? 0, 2);
            var binaryB = Convert.ToString(b, 2);
            Console.WriteLine(
                $"{a ?? 0}{operation}{b} == {binaryA}{operation}{binaryB} == {value} == {binaryValue}");
        }
    }
}
