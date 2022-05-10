using System.Collections.Generic;
namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    private static List<Car> _carList = new List<Car>(){};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _carList.Add(this);
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void UpdateWeekendPrice()
    {
      Price = (Price - (Price / 10));
    }
    
    public static List<Car> GetList()
    {
      return _carList;
    }

    // public void SetPrice(int newPrice)
    // {
    //   Price = newPrice;
    // }

    // public static string MakeSound(string sound)
    // {
    //   return "Our cars sound like " + sound;
    // }
  }
}