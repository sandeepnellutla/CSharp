/*
 * EXAMPLES OF SINGLE DIMENSIONAL ARRAYS
 * */
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDimensionalArrayBasic();
            SingleDimensionalArrayWithoutInitialization();
            SingleDimensionalArrayWithLaterInitialization();

            Console.ReadKey();
        }

        private static void SingleDimensionalArrayBasic()
        {
            int[] sampleArray = new int[] { 10, 20 };

            Console.WriteLine("Single Dimensional Array Declarations & Initializations");

            Console.WriteLine("int[] sampleArray = new int[] {10,20};");

            Console.WriteLine("for (int i=0;i<sampleArray.Length;i++) { Write(sampleArray[i]); }");
            Console.WriteLine("OUTPUT:-");
            for (int i = 0; i < sampleArray.Length; i++)
            {
                Console.WriteLine($@"   sampleArray[{i}]: {sampleArray[i]}");
            }
        }

        private static void SingleDimensionalArrayWithoutInitialization()
        {
            Console.WriteLine("----------------------------------------------");
            int[] sampleArray2 = new int[3];
            Console.WriteLine("Array with out initialization. Default Values...");
            Console.WriteLine("int[] sampleArray2 = new int[3];");
            Console.WriteLine("for (int i=0;i<sampleArray2.Length;i++) { Write(sampleArray2[i]); }");
            Console.WriteLine("OUTPUT:-");
            for (int i = 0; i < sampleArray2.Length; i++)
            {
                Console.WriteLine($@"   sampleArray2[{i}]: {sampleArray2[i]}");
            }
        }

        private static void SingleDimensionalArrayWithLaterInitialization()
        {
            Console.WriteLine("----------------------------------------------");
            int[] sampleArray3 = new int[3];
            sampleArray3 = new int[] { 1, 2, 3 };
            Console.WriteLine("Array with out initialization. Later Initialized");
            Console.WriteLine(@"int[] sampleArray3 = new int[3];
sampleArray3 = new int[] { 1, 2, 3 };");

            Console.WriteLine(@"for (int i=0;i<sampleArray3.Length;i++) 
{ 
    Write(sampleArray3[i]); 
}");
            Console.WriteLine("OUTPUT:-");
            for (int i = 0; i < sampleArray3.Length; i++)
            {
                Console.WriteLine($@"   sampleArray3[{i}]: {sampleArray3[i]}");
            }
        }

    }
}
