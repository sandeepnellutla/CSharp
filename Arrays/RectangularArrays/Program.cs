/*
 * EXAMPLES OF MULTIDIMENSIONAL ARRAYS : RECTANGULAR ARRAYS
 */
using System;

namespace RectangularArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangularArraysBasicWithoutInitialization();
            Console.WriteLine("-----------------------------------------------------------------------------");
            RectangularArraysInitialized();
            Console.WriteLine("-----------------------------------------------------------------------------");
            RectangularArraysShortInitialized();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ReadKey();
        }

        private static void RectangularArraysBasicWithoutInitialization()
        {
            Console.WriteLine("------------ Rectangular Arrays Basic Without Initialization--------------");
            int[,] recArrayBasic = new int[2, 2];
            Console.WriteLine(@"
            int[,] recArrayBasic = new int [2, 2];");
            Console.WriteLine(@"            
            for (int i = 0; i < recArrayBasic.GetLength(0); i++)
            {
                for (int j = 0; j < recArrayBasic.GetLength(1); j++)
                {
                    ...... Print Output here...
                }
            }");

            Console.WriteLine("OUTPUT:");
            ShowOutput(recArrayBasic);
        }

        private static void RectangularArraysInitialized()
        {
            Console.WriteLine("------------ Rectangular Arrays Basic With Initialization--------------");
            int[,] recArrayBasic = new int[2, 2];
            recArrayBasic = new int[,]
                            {
                                {1, 2} ,
                                {3, 4}
                            };

            Console.WriteLine(@"
            int[,] recArrayBasic = new int [2, 2];
            recArrayBasic = new int[,]
                            {
                                {1, 2} ,
                                {3, 4}
                            };");
           
            Console.WriteLine(@"
            for (int i = 0; i < recArrayBasic.GetLength(0); i++)
            {
                for (int j = 0; j < recArrayBasic.GetLength(1); j++)
                {
                    ...... Print Output here...
                }
            }");

            Console.WriteLine("OUTPUT:");
            ShowOutput(recArrayBasic);
        }

        private static void RectangularArraysShortInitialized()
        {
            Console.WriteLine("------------ Rectangular Arrays Basic With Initialization--------------");
            int[,] recArrayBasic = new int[,]
                                    {
                                        {11, 21, 31} ,
                                        {12, 22, 32} ,
                                        {13, 23, 33}
                                    };

            Console.WriteLine(@"
            int[,] recArrayBasic = new int[,]
                                    {
                                        {11, 21, 31} ,
                                        {12, 22, 32} ,
                                        {13, 23, 33}
                                    };");
            Console.WriteLine(@"
            for (int i = 0; i < recArrayBasic.GetLength(0); i++)
            {
                for (int j = 0; j < recArrayBasic.GetLength(1); j++)
                {
                    ...... Print Output here...
                }
            }");

            Console.WriteLine("OUTPUT:");
            ShowOutput(recArrayBasic);
        }

        private static void ShowOutput(int[,] mdArrays)
        {
            var msg = "";

            for (int i = 0; i < mdArrays.GetLength(0); i++)
            {
                for (int j = 0; j < mdArrays.GetLength(1); j++)
                {
                    msg = (j == 0) ? "\n{ " : "";
                    Console.Write(msg);
                    Console.Write($"{mdArrays[i, j]}");
                    msg = (j < mdArrays.GetLength(1) - 1) ? ", " : " }";
                    Console.Write(msg);
                }
                msg = (i < mdArrays.GetLength(0) - 1) ? ", " : "\n";
                Console.Write(msg);
            }
        }
    }
}
