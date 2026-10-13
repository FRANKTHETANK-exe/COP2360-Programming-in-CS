using System;

class Program
{
    public static void RaisePuppy(double salary, double raisePercent)
    {

        double raiseAmount = salary * raisePercent;

        double newSalary = salary + raiseAmount;

        Console.WriteLine("\nRaise Calculation Method 1 (Percentage):");
        Console.WriteLine($"Initial Salary: {salary:C2}");
        Console.WriteLine($"Raise Percentage: {raisePercent:P2}");
        Console.WriteLine($"Raise Amount: {raiseAmount:C2}");
        Console.WriteLine($"Total Salary After Raise: {newSalary:C2}");
    }
    public static void RaisePuppy(double salary, int raiseAmount)
    {
        double newSalary = salary + raiseAmount;

        Console.WriteLine("\nRaise Calculation Method 2 (Fixed Amount):");
        Console.WriteLine($"Initial Salary: {salary:C2}");
        Console.WriteLine($"Raise Amount: {raiseAmount:C2}");
        Console.WriteLine($"Total Salary After Raise: {newSalary:C2}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Raise Calculation - Percentage Method");
        Console.Write("Enter your current salary: $");
        double salary1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the raise percentage (as a decimal, e.g., 0.042 for 4.2%): ");
        double raisePercent = Convert.ToDouble(Console.ReadLine());

        RaisePuppy(salary1, raisePercent);

        Console.WriteLine("\nRaise Calculation - Fixed Amount Method");
        Console.Write("Enter your current salary: $");
        double salary2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fixed raise amount: $");
        int raiseAmount = Convert.ToInt32(Console.ReadLine());

        RaisePuppy(salary2, raiseAmount);

        // Prevents console from closing immediately (DONT TOUCH EVER EVER EVER)
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
