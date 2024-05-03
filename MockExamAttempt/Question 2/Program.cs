
//Below is some code in a basic console application that should create an array of size 20 and assign all the elements of the array that have an odd index to the value 1

//There is an error in the code.


int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) //the issue was swtiching >= to !=, its now correct
    {
        array[i] = 1;
    }
}

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(array[3]);
Console.WriteLine(array[4]);
Console.WriteLine(array[5]);
Console.WriteLine(array[6]);
Console.WriteLine(array[7]);
Console.WriteLine(array[8]);
