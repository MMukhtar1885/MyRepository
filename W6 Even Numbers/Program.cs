Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a list of numbers seperated by spaces.");

Console.WriteLine("The program will output all the even numbers.");

string input = Console.ReadLine();

string output = input;

int number = int.Parse(output);

string[] separateStrings = input.Split(' ');

foreach (string str in separateStrings)
{

    separateStrings = str;
    if (number % 2 == 0)
    {
        Console.Write(number + " ");
    }

    Console.WriteLine(number);
}





