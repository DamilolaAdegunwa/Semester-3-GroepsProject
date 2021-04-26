using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeaAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static string[] TeaTypes = new[]
        {
            "Aardbeien", "Bosvruchten","Citroen","Ne3ne3","Shiba",
        };

        [HttpGet]
        public ActionResult Get()
        {
            Random rnd = new Random();
            return Ok(TeaTypes[rnd.Next(TeaTypes.Length)]);
        }
    }
}
