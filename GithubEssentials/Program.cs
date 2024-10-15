using System;

class Program
{
    static void Main()
    {
        string message = "Hello, World!";
        ConsoleColor[] backgroundColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        Random rand = new Random();
        
        for (int i = 0; i < 20; i++) // Repeat printing multiple times
        {
            // Randomly pick background and foreground colors
            ConsoleColor background = backgroundColors[rand.Next(backgroundColors.Length)];
            ConsoleColor foreground = backgroundColors[rand.Next(backgroundColors.Length)];

            // Ensure foreground and background colors are not the same
            while (foreground == background)
            {
                foreground = backgroundColors[rand.Next(backgroundColors.Length)];
            }

            // Set console colors
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;

            // Print message
            Console.WriteLine(message);
        }

        // Reset console colors
        Console.ResetColor();
    }
}
