/*
 * EXAMPLES OF MULTIDIMENSIONAL ARRAYS : JAGGED ARRAYS
 */
 ***************MULTIDIMENSIONAL ARRAYS - JAGGED ARRAYS* *****************

------------ Jagged Arrays Basic Without Initialization--------------

                                int[][] jaggedArraysBasic = new int [3][];

                                for (int i = 0; i < jaggedArraysBasic.Length; i++)
                                {
                                    for (int j = 0; j < jaggedArraysBasic[i].Length; j++)
                                    {
                                        ...... Print Output here...
                                    }
                                }

Expected to see an error since second/inner array is not initialized.

OUTPUT:
Error:Object reference not set to an instance of an object.
Error:Object reference not set to an instance of an object.
Error:Object reference not set to an instance of an object.
-----------------------------------------------------------------------------

------------ Jagged Arrays With Initialization--------------

                                int[][] jaggedArraysBasic = new int [3][]
                                {
                                    new int[]{1,2},
                                    new int[]{3,4,5},
                                    new int[]{6,7,8,9,10}
                                };

                                for (int i = 0; i < jaggedArraysBasic.Length; i++)
                                {
                                    for (int j = 0; j < jaggedArraysBasic[i].Length; j++)
                                    {
                                        ...... Print Output here...
                                    }
                                }
OUTPUT:

{ 1, 2 },
{ 3, 4, 5 },
{ 6, 7, 8, 9, 10 }
-----------------------------------------------------------------------------

------------ Jagged Arrays Basic With Shorthand Initialization--------------

                                int[][] jaggedArraysBasic =
                                {
                                    new int[]{11,12},
                                    new int[]{21,22,23},
                                    new int[]{31,32,33,34,35},
                                    new int[]{41,42,43,44}
                                };

                                for (int i = 0; i < jaggedArraysBasic.Length; i++)
                                {
                                    for (int j = 0; j < jaggedArraysBasic[i].Length; j++)
                                    {
                                        ...... Print Output here...
                                    }
                                }
OUTPUT:

{ 11, 12 },
{ 21, 22, 23 },
{ 31, 32, 33, 34, 35 },
{ 41, 42, 43, 44 }
-----------------------------------------------------------------------------
