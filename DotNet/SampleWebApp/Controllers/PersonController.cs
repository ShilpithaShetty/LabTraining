using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;


namespace SampleWebApp.Controllers
{
    
    public class PersonController : Controller
    {
        [HttpGet("/people", Name ="GetPeople", Order = 1)]
        [HttpGet("/person", Name ="DisplayPeople", Order = 2)]
        public IActionResult GetPeople()
        {
            var people = PersonOp.GetPeople();
            var uri = Url.Link("DisplayPeople",people);
            return Created(uri, people);
            return View("PeopleList", people);
        }

        public IActionResult AccessRoute()
        {
            var response = HttpContext.Response;
            var uri = Url.Link("GetPeople", "created");
            return Created(uri, "created");
        }

        [HttpGet("/search/{pAadhar}")]
        public IActionResult GetPersonDetails(string pAadhar)
        {
            var found = PersonOp.Search(pAadhar);
            return View("Search", found);

        }

        [HttpGet("/people/of/age/{startAge}/{endAge}")]
        public IActionResult GetPeopleWithinAge(int startAge, int endAge) 
        {
            var sage = PersonOp.Age(startAge,endAge);
            return View("PeopleofAge", sage);

        }
        [HttpGet("/create")]
        public IActionResult Create() 
        {
            return View("Create", new Person());
        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Person p) 
        {
            PersonOp.CreateNew(p);
            return View("PeopleList", PersonOp.GetPeople());
        }

        [HttpGet("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar)
        {
            var found = PersonOp.Search(pAadhar);
            return View("Edit", found);

        }

        [HttpPost("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar, [FromForm] Person p) 
        {
            var found = PersonOp.Search(p.Aadhar);
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
            return View("PeopleList", PersonOp.GetPeople());
        }
    }
}
