using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/car/list/clear")]
    public ActionResult CarListClear()
    {
      Car.ClearAll();
      return View();
    }
    [HttpPost("/car/create")]
    public ActionResult CreateCar()
    {
      Car newCar = new Car (
      Request.Form["model"],
      Request.Form["miles"],
      Request.Form["description"]
      );
      newCar.Save();
      return View(newCar);
    }
    [HttpPost("/car/list")]
    public ActionResult CarList()
    {
      Car newCar = new Car(
        Request.Form["model"],
        Request.Form["miles"],
        Request.Form["description"]
      );
      newCar.Save();

      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
  }
}
