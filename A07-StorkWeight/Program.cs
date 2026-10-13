using System;

class Program
{
    const double OUNCES_PER_INCH = 2.77;

    static double InchesToOunces(double inches)
    {
        return inches * OUNCES_PER_INCH;
    }

    static void Main()
    {
        Console.Write("Enter the stork's height in inches: ");

        if (double.TryParse(Console.ReadLine(), out double heightInInches))
        {
            double weightInOunces = InchesToOunces(heightInInches);
            Console.WriteLine($"The stork's weight is {weightInOunces:F3} ounces.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}
