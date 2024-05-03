using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
//Below is code for a basic console application which should count all of the characters in a string and then print the result out to the console window.It will not currently compile.The insertion of a single keyword will fix this problem.

//You should use Visual Studio to help you determine the keyword to insert.


// THE BELOW ANSWER IS CORRECR

string myVariable = "Hello World";
Console.WriteLine(CalculateLength(myVariable));

int CalculateLength(string toProcess)
{
    int length = 0; // the issue was to add int to 'length', its now correct
    foreach (char c in toProcess)
    {
        length++;
    }
    return length;
}
