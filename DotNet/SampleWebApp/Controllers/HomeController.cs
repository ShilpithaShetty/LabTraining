using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace SampleWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return Ok("Hi");
        }

        [HttpGet("/simplegreet/{pName}")]
        public string SimpleGreet(string pName)
        {
            return $"Welcome to MVC, {pName}";
        }

        [HttpGet("/getnames")]
        public List<string> GetNames()
        {
            var names = new List<string>() { "James", "David", "Greg" };
            return names;
        }

        [HttpGet("/adddata/{pName}/{pMarks}/{isPassed}")]
        public string AddData(string pName, int pMarks, bool isPassed)
        {

            return $"{pName} scored {pMarks} in Science and their status is {isPassed}";

        }

        [HttpGet("/main")]
        public IActionResult GetIndex()
        {
            ViewBag.ReturnValue = "Data passed from controller to view";
            return View("MainPage");
        }
    }
}
