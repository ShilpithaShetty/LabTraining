using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private iApiLogger llogger;
        public PersonController(iApiLogger logger)
        {
            llogger = logger;
                
        }

        [HttpGet("/apis")]
        public IActionResult GetPeople()
        {
            llogger.Log("Start Logging GetPeople()");
            llogger.Log("GetPeople() api call was successful");
            return Ok(PersonOp.GetPeople());

        }

        [HttpPost("/api/create")]
        public IActionResult CreatePerson([FromForm] Person p)
        {
            PersonOp.CreateNew(p);
            llogger.Log("CreatePerson() api call was successful");
            return Created($"Created person with aadhar {p.Aadhar} successfull", p);
        }

        [HttpPut("/api/update/{aadhar}")]
        public IActionResult UpdatePerson([FromRoute] string aadhar, Person updatedP)
        {
            try
            {
                PersonOp.Update(aadhar, updatedP);
                llogger.Log("UpdatePerson() api call was successful");
                return Ok("Update Successful");

            }
            catch (Exception e)
            {
                llogger.Log(e.Message);
                return NotFound(e.Message);
            }
            

        }

        [HttpDelete("/api/delete")] //Eg: https://localhost:7114/api/delete?aadhar=23456342
        public IActionResult DeletePerson([FromQuery] string aadhar) 
        {
            try
            {
                PersonOp.Delete(aadhar);
                llogger.Log("DeletePerson() api call was successful");
                return Ok("Deletion successful");

            }
            catch (Exception e)
            {
                llogger.Log(e.Message);
                return NotFound(e.Message);
            }
            

        }


    }
}
