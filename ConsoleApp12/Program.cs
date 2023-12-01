using System;
using ConsoleApp12.Builders;
using ConsoleApp12.Directors;

class Program
{
    static void Main()
    {
        CarDirector director = new CarDirector();
        CarBuilder standardBuilder = new StandardCarBuilder();
        CarBuilder luxuryBuilder = new LuxuryCarBuilder();
        CarBuilder sportsBuilder = new SportsCarBuilder();

        var standardCar = director.Construct(standardBuilder);
        var luxuryCar = director.Construct(luxuryBuilder);
        var sportsCar = director.Construct(sportsBuilder);

        Console.WriteLine("Standard Car:");
        standardCar.DisplayInfo();

        Console.WriteLine("\nLuxury Car:");
        luxuryCar.DisplayInfo();

        Console.WriteLine("\nSports Car:");
        sportsCar.DisplayInfo();
    }
}