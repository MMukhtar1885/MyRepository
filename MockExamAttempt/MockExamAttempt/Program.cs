int TipTapTop = 0;


for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0 && i % 6 == 0)
    {
        if (sumofstring(i.ToString()) % 2 != 0)
        {
            TipTapTop++;
        }
    }

}
Console.WriteLine($"TipTapTop is {TipTapTop}"); 

    int sumofstring(string tosString)
{
    int sumofstring = 0;
        foreach (char c in tosString)
        {
            sumofstring += c - '0';
        }
        return sumofstring;
}







//TickTockSock question
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int tickCount = 0;
//            int tockCount = 0;
//            int tickTockCount = 0;
//            int shockCount = 0;

//            for (int num = 1; num <= 100; num++)
//            {
//                switch (num)
//                {
//                    case var _ when num % 3 == 0 && num % 5 == 0:
//                        Console.WriteLine("TickTock");
//                        tickTockCount++;
//                        break;
//                    case var _ when num % 3 == 0:
//                        Console.WriteLine("Tick");
//                        tickCount++;
//                        break;
//                    case var _ when num % 5 == 0:
//                        Console.WriteLine("Tock");
//                        tockCount++;
//                        break;
//                    case var _ when num % 7 == 0 && num % 3 != 0 && num % 5 != 0:
//                        Console.WriteLine("SHOCK");
//                        shockCount++;
//                        break;
//                    default:
//                        Console.WriteLine(num);
//                        break;
//                }
//            }

//            Console.WriteLine("\nSummary:");
//            Console.WriteLine($"Total numbers displayed: 100");
//            Console.WriteLine($"Tick count: {tickCount}");
//            Console.WriteLine($"Tock count: {tockCount}");
//            Console.WriteLine($"TickTock count: {tickTockCount}");
//            Console.WriteLine($"SHOCK count: {shockCount}");
//        }
//    }
//}

//static void Main()
//{
//    int tickCount = 0;
//    int tockCount = 0;
//    int ticktockCount = 0;
//    int shockCount = 0;
//    int numberCount = 0;

//        for (int num = 1; num <= 100; num++)
//        {


//            if (num % 3 == 0)
//            {
//                tickCount++;
//            }

//            else if (num % 5 == 0)
//            {
//                tockCount++;
//            }
//            else if (num % 3 == 0 && num % 5 == 0)
//            {
//                ticktockCount++;
//            }

//            else if (num % 7 == 0 && num % 3 != 0 && num % 5 != 0)
//            {
//                shockCount++;
//            }


//            else //(num % 3 != 0 && num % 5 != 0 && num % 7 != 0)
//            {
//                numberCount++;
//            }
//        }

//        Console.WriteLine($"Tick= {tickCount}");
//        Console.WriteLine($"Tock= {tockCount}");
//        Console.WriteLine($"TickTock= {ticktockCount}");
//        Console.WriteLine($"SHOCK= {shockCount}");
//        Console.WriteLine($"numbers= {numberCount}");
//    }
//}

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