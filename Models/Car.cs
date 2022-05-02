namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public void UpdateWeekendPrice()
    {
      Price = (Price - (Price * 10 / 100));
    }

    // public bool SaleWeekend(string response)
    // {
    //   return (response.ToUpper() == "Y");
    // }

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