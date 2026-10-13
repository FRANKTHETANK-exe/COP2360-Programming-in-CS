using System;

class Inductees
{
    public string Artist { get; set; }
    public int Year { get; set; }
}

class Program  
{
    static void Main()
    {
        // Create two Inductees objects
        Inductees artist1 = new Inductees();
        artist1.Artist = "Nirvana";
        artist1.Year = 2014;

        Inductees artist2 = new Inductees();
        artist2.Artist = "Tina Turner";
        artist2.Year = 2021;

        // Display the inductees
        Console.WriteLine("Rock and Roll Hall of Fame Inductees:");
        Console.WriteLine($"{artist1.Artist}, inducted in {artist1.Year}");
        Console.WriteLine($"{artist2.Artist}, inducted in {artist2.Year}");
    }
}
