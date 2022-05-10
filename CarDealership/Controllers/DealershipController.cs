using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class DealershipController : Controller
  {
    [HttpGet("/dealership")]
    public ActionResult Index()
    {
      List<Car> carList = Car.GetList();
      return View(carList);
    }

    [HttpGet("/dealership/form")]
    public ActionResult DealershipForm()
    {
      return View();
    }

    [HttpPost("/dealership")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }
  }
}