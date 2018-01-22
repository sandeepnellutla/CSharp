/*
 * EXAMPLES OF MULTIDIMENSIONAL ARRAYS : RECTANGULAR ARRAYS
 */
 *************** MULTIDIMENSIONAL ARRAYS - RECTANGLEARRAYS ******************

------------ Rectangular Arrays Basic Without Initialization--------------

            int[,] recArrayBasic = new int [2, 2];

            for (int i = 0; i < recArrayBasic.GetLength(0); i++)
            {
                for (int j = 0; j < recArrayBasic.GetLength(1); j++)
                {
                    ...... Print Output here...
                }
            }
OUTPUT:

{ 0, 0 },
{ 0, 0 }
-----------------------------------------------------------------------------
------------ Rectangular Arrays Basic With Initialization--------------

            int[,] recArrayBasic = new int [2, 2];
            recArrayBasic = new int[,]
                            {
                                {1, 2} ,
                                {3, 4}
                            };

            for (int i = 0; i < recArrayBasic.GetLength(0); i++)
            {
                for (int j = 0; j < recArrayBasic.GetLength(1); j++)
                {
                    ...... Print Output here...
                }
            }
OUTPUT:

{ 1, 2 },
{ 3, 4 }
-----------------------------------------------------------------------------
------------ Rectangular Arrays Basic With Initialization--------------

            int[,] recArrayBasic = new int[,]
                                    {
                                        {11, 21, 31} ,
                                        {12, 22, 32} ,
                                        {13, 23, 33}
                                    };

            for (int i = 0; i < recArrayBasic.GetLength(0); i++)
            {
                for (int j = 0; j < recArrayBasic.GetLength(1); j++)
                {
                    ...... Print Output here...
                }
            }
OUTPUT:

{ 11, 21, 31 },
{ 12, 22, 32 },
{ 13, 23, 33 }
-----------------------------------------------------------------------------
