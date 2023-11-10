Console.WriteLine("Enter a list of numbers seperated by spaces.");
Console.WriteLine("The program will output all the odd numbers, then output all the even numbers.");
 
string input = Console.ReadLine();
 
string output = string.Empty;

string[] separatestring = input.Split(" ");

int number = int.Parse(output);

string str = string.Empty;

foreach (string separate in separatestring)
{
    number = int.Parse(str);
    if (number % 3 == 0)
    {
        Console.Write(number + " ");
    }
}