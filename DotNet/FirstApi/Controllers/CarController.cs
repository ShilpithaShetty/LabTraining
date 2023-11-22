using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using static FirstApi.Models.CarEngine;
using FirstApi.Models;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private Car car;
        private iApiLogger loggerr;
        private Accessories accessories;
        public CarController(Car c, iApiLogger logger, Accessories access )
        {
            car= c;
            loggerr = logger;
            loggerr.Log("CarController instance is created");
            accessories = access;
            access.Log("Accessories is working");

        }

        [HttpGet("/drive")]
        public IActionResult Drive()
        {
            loggerr.Log("Driving() api called successfully");
            return Ok("Driving at 100kmph");
        }
    }
}
