// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Programming Portfolio Results Calculator 44");
Console.WriteLine("What  was the digital portfolio mark (out of 35)");

int digitalportfolio = int.Parse(Console.ReadLine());
while (0 > digitalportfolio || digitalportfolio > 35)
{
    Console.WriteLine(digitalportfolio + " is not a valid mark for the digital portfolio");
    return;
}
  
Console.WriteLine("What was the open book programming exam mark (out of 7)");

int openbook = int.Parse(Console.ReadLine());
while (0 > openbook || openbook > 7)
{
    Console.WriteLine(openbook + " is not a valid mark for the digital portfolio");
    return;
}

Console.WriteLine("What was the capstone project mark? (out of 100)");

int capstoneproject = int.Parse(Console.ReadLine());
while (0 > capstoneproject || capstoneproject > 100)
{
    Console.WriteLine(capstoneproject + " is not a valid mark for the digital portfolio");
    return;
}

double dpinpercentage = 0.5 * digitalportfolio * 100/35;
double obinpercentage = 0.25 * openbook * 100/7;
double cpinpercentage = 0.25 * capstoneproject;
double moduleMark = dpinpercentage + obinpercentage + cpinpercentage;
moduleMark = (float)Math.Round(moduleMark, 2);



if (moduleMark >= 70)
{
    Console.WriteLine(moduleMark + "% - 1st");
}

else if (60 < moduleMark || moduleMark < 70)
{
    Console.WriteLine(moduleMark + "% - 2:1");
}

