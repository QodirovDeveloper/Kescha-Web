using Microsoft.AspNetCore.Mvc;

namespace KeschaWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Greet(string name, string age)
        {
            int ageInt;
            if (!int.TryParse(age, out ageInt))
            {
                ViewData["Message"] = "Invalid age input.";
                return View("Index");
            }

            int keschasAge = 3;
            int ageDifference = ageInt - keschasAge;

            ViewData["Message"] = $"Hello, {name}. The difference between your and Kescha's age is {ageDifference}.";
            return View("Index");
        }
    }
}
