Console.WriteLine("Tardy Train Monitoring Application");


int MinutesLate;
int TrainsLate = 0;

do
{
  
    Console.WriteLine("How many minutes was the train late?");
    MinutesLate = int.Parse(Console.ReadLine());
    if (MinutesLate > 0 )
    {
        TrainsLate+=1;
    }

} while (MinutesLate > 0);

Console.WriteLine(TrainsLate + " out of " + TrainsLate + " trains were late ");
