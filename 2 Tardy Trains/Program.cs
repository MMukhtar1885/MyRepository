Console.WriteLine("Tardy Train Monitoring Application");
Console.WriteLine("How many minutes was the train late?");

int MinutesLate = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("How many minutes was the train late?"); 
} while (MinutesLate > 0);