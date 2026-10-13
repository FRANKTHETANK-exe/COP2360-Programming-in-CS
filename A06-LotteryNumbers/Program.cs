using System;

class Program 
{
    static void Main()
    {
        int[] winningNumbers = { 18, 20, 50, 52, 56 }; 
        int powerball = 20; // Separate Powerball number
        int powerPlay = 2; // Power Play value
        string drawingDate = "March 3, 2025";

        // Display the date of the drawing
        Console.WriteLine($"Florida Lottery Winning Numbers for {drawingDate}");
        Console.Write("Winning Numbers: ");
        foreach (int number in winningNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine($"\nPowerball: {powerball}");
        Console.WriteLine($"Power Play: {powerPlay}\n");

        // Prompt user for input
        Console.Write("Enter a lottery number to check: ");
        int userNumber;

        // Validate user input
        while (!int.TryParse(Console.ReadLine(), out userNumber))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        // Check if the number is a winning number
        bool isWinner = false;
        foreach (int number in winningNumbers)
        {
            if (number == userNumber)
            {
                isWinner = true;
                break;
            }
        }

        // Output result
        if (isWinner || userNumber == powerball) // Check Powerball separately
        {
            Console.WriteLine("We have an amazing winner!");
        }
        else
        {
            Console.WriteLine("We have a super loser!");
        }
    }
}
