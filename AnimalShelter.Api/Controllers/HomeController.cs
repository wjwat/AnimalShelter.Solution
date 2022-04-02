using Microsoft.AspNetCore.Mvc;

namespace AnimalShelter.Api.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return Redirect("/swagger/index.html?urls.primaryName=V2.0");
    }
  }
}