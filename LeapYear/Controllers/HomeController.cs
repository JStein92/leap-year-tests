using Microsoft.AspNetCore.Mvc;
using LeapYear.Models;
using System;

namespace LeapYear.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/LeapYearResult")]
    public ActionResult LeapYearResult()
    {
      int userYear = int.Parse(Request.Form["year"]);
      LeapYearConverter newYear = new LeapYearConverter(userYear);

      return View(newYear);
    }
  }
}
