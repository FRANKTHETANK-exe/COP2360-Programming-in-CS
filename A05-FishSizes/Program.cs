using System;

class Program
{
    static void Main()
    {
        // Variables for counting and accumulating fish sizes
        int fishCount = 0;
        double totalSize = 0;
        double fishSize;

        // Priming read (initial input prompt)
        Console.Write("Enter fish size in inches (-1 to stop): ");
        fishSize = Convert.ToDouble(Console.ReadLine());

        // Loop to collect fish sizes
        while (fishSize != -1)
        {
            fishCount++; // Increment count
            totalSize += fishSize; // Accumulate size

            // Get next input
            Console.Write("Enter fish size in inches (-1 to stop): ");
            fishSize = Convert.ToDouble(Console.ReadLine());
        }

        // Output results
        if (fishCount > 0)
        {
            double averageSize = totalSize / fishCount;
            Console.WriteLine($"Total fish sizes collected: {fishCount}");
            Console.WriteLine($"Sum of fish sizes: {totalSize:F2} inches");
            Console.WriteLine($"Average fish size: {averageSize:F2} inches");
        }
        else
        {
            Console.WriteLine("No fish sizes were entered.");
        }
    }
}
