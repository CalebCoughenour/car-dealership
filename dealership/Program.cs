using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{ 
  public class Program
  {
    public static void Main()
    {
      Car volkswagon = new Car("1974 Volkswagon Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagon, yugo, ford, amc };

      List<Car> CarsMatchingSearch = new List<Car>(0);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("What day of the week is it?");
      string weekendResponse = Console.ReadLine();
      if (SaleWeekend(weekendResponse))
      {
        foreach(Car automobile in Cars)
        {
          automobile.UpdateWeekendPrice();
        }
      }

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("--------------------");
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine("$" + automobile.Price);
        Console.WriteLine(automobile.Miles + " miles");
      }

    bool SaleWeekend(string response)
    {
      response.ToUpper();
      return (response == "SATURDAY" || response == "SUNDAY");
    }

      


    }
  }
}