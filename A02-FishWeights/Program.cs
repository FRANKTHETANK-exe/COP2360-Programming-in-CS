using System;

class Program
{
    static void Main()
    {
        // Declare five int variables for fish weights
        int fish1 = 10;
        int fish2 = 15;
        int fish3 = 8;
        int fish4 = 12;
        int fish5 = 14;

        // Calculate the total weight
        int totalWeight = fish1 + fish2 + fish3 + fish4 + fish5;

        // Compute the average
        double averageWeight = (double)totalWeight / 5;

        // Display the average
        Console.WriteLine("Average fish weight: " + averageWeight.ToString("F1") + " pounds");
    }
}
