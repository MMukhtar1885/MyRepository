Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a list of numbers seperated by spaces.");
Console.WriteLine("The program will output all the even numbers.");

string input = Console.ReadLine();

string output = string.Empty;

string[] separateStrings = input.Split(' ');

foreach (string str in separateStrings)
{
    string seperateStrings = str;   

}

int number = int.Parse(output); 

Console.WriteLine(number);  

if (number % 2 == 0)
{
    Console.Write(number + " ");
}