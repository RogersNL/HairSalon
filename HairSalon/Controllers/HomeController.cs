using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(); //Test will pass
            // return new EmptyResult(); //Test will fail
        }
    }
}
