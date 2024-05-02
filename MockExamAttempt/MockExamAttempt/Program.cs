using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        int tickCount = 0;
        int tockCount = 0;
        int ticktockCount = 0;
        int shockCount = 0;
        int numberCount = 0;

        for (int num = 1; num <= 100; num++)
        {
            string output = "";

            if (num % 3 == 0)
            {
                output = "Tick";
                tickCount++;
            }

            else if (num % 5 == 0)
            {
                output = "Tock";
                tockCount++;
            }

            else if (num % 3 == 0 && num % 5 == 0)
            {
                output = "TikTock";
                ticktockCount++;
            }
            else if (num % 7 == 0 && num % 3 != 0 && num % 5 != 0)
            {
                output = "SHOCK";
                shockCount++;
            }


            else //(num % 3 != 0 && num % 5 != 0 && num % 7 != 0)
            {
                output = num.ToString();
                numberCount++;
            }
        }

        Console.WriteLine($"Tick= {tickCount}");
        Console.WriteLine($"Tock= {tockCount}");
        Console.WriteLine($"TickTock= {ticktockCount}");
        Console.WriteLine($"SHOCK= {shockCount}");
        Console.WriteLine($"numbers= {numberCount}");
    }
}

//Write a program that automatically plays the TickTock SHOCK game from 1 to 10,000 (inclusive of the values 1 and 10,000)

//You will need to calculate: 

//How many times “Tick” is displayed (Note: count “Tick” only, so “TickTock” would not count)
//How many times “Tock” is displayed (Note: count “Tock” only, so “TickTock” would not count)
//How many times “TickTock” is displayed
//How many times “SHOCK” is displayed (Note the special rule for SHOCK above)
//How many numbers are displayed
//TickTock SHOCK rules:

//For any number that is divisible by three, the output should be "Tick"

//For any number that is divisible by five, the output should be "Tock"

//Numbers divisible by both three and five should produce the output "TickTock"

//Numbers divisible by seven should produce the output "SHOCK" but only when the number is not also divisible by three or five.

//Numbers divisible by neither three, five nor seven should just output the number

 

//For example, a typical round of TickTock SHOCK would start as follows:

//1, 2, Tick, 4, Tock, Tick, SHOCK, 8, Tick, Tock, 11, Tick, 13, SHOCK, TickTock...

//There are 6 numbers displayed (1,2,4,8,11,13)
//Tick is displayed 4 times(in place of 3, 6, 9, 12)
//Tock is displayed 2 times(in place of 5, 10)
//TickTock is displayed 1 time(in place of 15)
//SHOCK is displayed 2 times(in place of 7, 14)
//Etc......Use this example to test your code from 1 - 100 (inclusive of the values 1 and 100) before changing it to run 1-10000:

//Input Expected Output
//Game from 1 - 100 (inclusive)	Tick    27
//Tock	14
//TickTock	6
//SHOCK	8
//numbers	45
 

//For the game of TickTock SHOCK (numbers 1 - 10,000 inclusive):