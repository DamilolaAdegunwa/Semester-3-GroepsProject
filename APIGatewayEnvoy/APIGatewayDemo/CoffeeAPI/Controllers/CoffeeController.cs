using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static string[] CoffeeTypes = new[]
        {
            "Flat White", "Long Black","Latte","Americano","Cappuccino",
        };

        [HttpGet]
        public ActionResult Get()
        {
            Random rnd = new Random();
            return Ok(CoffeeTypes[rnd.Next(CoffeeTypes.Length)]);
        }
    }
}
