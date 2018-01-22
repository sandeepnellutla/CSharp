Single Dimensional Array Declarations & Initializations

int[] sampleArray = new int[] {10,20};
for (int i=0;i<sampleArray.Length;i++) { Write(sampleArray[i]); }
OUTPUT:-
   sampleArray[0]: 10
   sampleArray[1]: 20

----------------------------------------------

Array with out initialization. Default Values...

int[] sampleArray2 = new int[3];
for (int i=0;i<sampleArray2.Length;i++) { Write(sampleArray2[i]); }
OUTPUT:-
   sampleArray2[0]: 0
   sampleArray2[1]: 0
   sampleArray2[2]: 0

----------------------------------------------

Array with out initialization. Later Initialized.

int[] sampleArray3 = new int[3];
sampleArray3 = new int[] { 1, 2, 3 };
for (int i=0;i<sampleArray3.Length;i++)
{
    Write(sampleArray3[i]);
}
OUTPUT:-
   sampleArray3[0]: 1
   sampleArray3[1]: 2
   sampleArray3[2]: 3
