/*
 * EXAMPLES OF MULTIDIMENSIONAL ARRAYS : JAGGED ARRAYS
 */
 using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************MULTIDIMENSIONAL ARRAYS - JAGGED ARRAYS* *****************");
            JaggedArraysBasicWithoutInitialization();
            Console.WriteLine("-----------------------------------------------------------------------------");
            JaggedArraysInitialized();
            Console.WriteLine("-----------------------------------------------------------------------------");
            JaggedArraysShortInitialized();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ReadKey();
        }

        private static void JaggedArraysBasicWithoutInitialization()
        {
            int[][] jaggedArraysBasic = new int[3][];

            Console.WriteLine("------------ Jagged Arrays Basic Without Initialization--------------");

            Console.WriteLine(@"
                                int[][] jaggedArraysBasic = new int [3][];");
            Console.WriteLine(@"            
                                for (int i = 0; i < jaggedArraysBasic.Length; i++)
                                {
                                    for (int j = 0; j < jaggedArraysBasic[i].Length; j++)
                                    {
                                        ...... Print Output here...
                                    }
                                }");

            Console.WriteLine("\nExpected to see an error since second/inner array is not initialized.\n");
            ShowOutput(jaggedArraysBasic);
        }

        private static void JaggedArraysInitialized()
        {
            int[][] JaggedArraysInitialized = new int[3][]
                                                {
                                                    new int[]{1,2},
                                                    new int[]{3,4,5},
                                                    new int[]{6,7,8,9,10}
                                                };

            Console.WriteLine("------------ Jagged Arrays With Initialization--------------");

            Console.WriteLine(@"
                                int[][] jaggedArraysBasic = new int [3][]
                                {
                                    new int[]{1,2},
                                    new int[]{3,4,5},
                                    new int[]{6,7,8,9,10}
                                };");
            Console.WriteLine(@"            
                                for (int i = 0; i < jaggedArraysBasic.Length; i++)
                                {
                                    for (int j = 0; j < jaggedArraysBasic[i].Length; j++)
                                    {
                                        ...... Print Output here...
                                    }
                                }");

            ShowOutput(JaggedArraysInitialized);
        }

        private static void JaggedArraysShortInitialized()
        {
            int[][] JaggedArraysShortInitialized = 
            {
                new int[]{11,12},
                new int[]{21,22,23},
                new int[]{31,32,33,34,35},
                new int[]{41,42,43,44}
            };

            Console.WriteLine("------------ Jagged Arrays Basic With Shorthand Initialization--------------");

            Console.WriteLine(@"
                                int[][] jaggedArraysBasic = 
                                {
                                    new int[]{11,12},
                                    new int[]{21,22,23},
                                    new int[]{31,32,33,34,35},
                                    new int[]{41,42,43,44}
                                };");
            Console.WriteLine(@"            
                                for (int i = 0; i < jaggedArraysBasic.Length; i++)
                                {
                                    for (int j = 0; j < jaggedArraysBasic[i].Length; j++)
                                    {
                                        ...... Print Output here...
                                    }
                                }");

            ShowOutput(JaggedArraysShortInitialized);
        }

        private static void ShowOutput(int[][] jaggedArrays)
        {
            var msg = "";

            Console.WriteLine("OUTPUT:");

            for (int i = 0; i < jaggedArrays.Length; i++)
            {
                try
                {
                    for (int j = 0; j < jaggedArrays[i].Length; j++)
                    {
                        msg = (j == 0) ? "\n{ " : "";
                        Console.Write(msg);
                        Console.Write($"{jaggedArrays[i][j]}");
                        msg = (j < jaggedArrays[i].Length - 1) ? ", " : " }";
                        Console.Write(msg);
                    }
                    msg = (i < jaggedArrays.Length - 1) ? ", " : "\n";
                    Console.Write(msg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
        }

    }
}
