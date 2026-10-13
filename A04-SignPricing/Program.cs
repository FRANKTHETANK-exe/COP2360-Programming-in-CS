using System;

class Program
{
    static void Main()
    {
        // Named constants for sign height thresholds
        const double SMALL_HEIGHT_LIMIT = 5.0;
        const double MEDIUM_HEIGHT_LIMIT = 8.0;

        // Named constants for pricing
        const double SMALL_PRICE = 39.95;
        const double MEDIUM_PRICE = 89.99;
        const double LARGE_PRICE = 139.95;

        // Prompt the user for input
        Console.Write("Enter the height of the sign (in feet): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Determine the price using nested decisions
        double price;
        if (height < SMALL_HEIGHT_LIMIT)
        {
            price = SMALL_PRICE;
        }
        else
        {
            if (height <= MEDIUM_HEIGHT_LIMIT)
            {
                price = MEDIUM_PRICE;
            }
            else
            {
                price = LARGE_PRICE;
            }
        }

        // Display the price
        Console.WriteLine($"The price for a {height}-foot sign is ${price:F2}");
    }
}
