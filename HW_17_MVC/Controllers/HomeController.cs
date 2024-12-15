using Microsoft.AspNetCore.Mvc;

namespace Lesson_17_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    ////GetPost
    //public class HomeController : Controller
    //{
    //    [HttpGet]
    //    public string Index()
    //    {
    //        return "Hello world";
    //    }
    //    ////Тоже самое
    //    //[HttpGet]
    //    //public string Index() => "Hello world";


    //    [HttpPost]
    //    public string Hello() => "Hello ASP.NET";

    //}
}
