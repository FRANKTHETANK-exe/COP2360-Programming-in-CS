using System;

// Base class Scooter
class Scooter
{
    // Fields
    private double weight;
    private decimal price;

    // Property for the weight
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    // Property for the price
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }
}

// Subclass ElectricScooter
class ElectricScooter : Scooter
{
    // Additional field
    private double wattHours;

    // Property for the watthours
    public double WattHours
    {
        get { return wattHours; }
        set { wattHours = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate a Scooter object
        Scooter manualScooter = new Scooter();
        manualScooter.Weight = 9.5; 
        manualScooter.Price = 79.99m; 

        // Instantiate an ElectricScooter object
        ElectricScooter electricScooter = new ElectricScooter();
        electricScooter.Weight = 27.0; 
        electricScooter.Price = 499.99m; 
        electricScooter.WattHours = 280.8; // typical value in Wh

        // Output details
        Console.WriteLine("Manual Scooter Details:");
        Console.WriteLine($"Weight: {manualScooter.Weight} lbs");
        Console.WriteLine($"Price: ${manualScooter.Price}");

        Console.WriteLine("\nElectric Scooter Details:");
        Console.WriteLine($"Weight: {electricScooter.Weight} lbs");
        Console.WriteLine($"Price: ${electricScooter.Price}");
        Console.WriteLine($"Battery Capacity: {electricScooter.WattHours} Wh");
    }
}
