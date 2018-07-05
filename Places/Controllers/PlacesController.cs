using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesVisited.Models;

namespace PlacesVisited.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places/list")]
    public ActionResult List()
    {
      List<Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }

    [HttpPost("/places/list")]
    public ActionResult AddNewPlace()
    {
      Places newPlace = new Places(Request.Form["new-location"], Request.Form["new-dates"], Request.Form["new-picture"]);
      List<Places> allPlaces = Places.GetAll();
      return View("List", allPlaces);
    }

    [HttpGet("/places/add")]
    public ActionResult Add()
    {
      return View();
    }


  }
}
