using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIService;
using Microsoft.AspNetCore.Mvc;

namespace ciservice.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        // GET api/greeting
        [HttpGet]
        public ActionResult<string> Get()
        {
            var greeterService = new GreeterService();
            var result = greeterService.GetGreetText("Micros");
            return result;
        }

        // GET api/greeting/tom
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            var greeterService = new GreeterService();
            var result = greeterService.GetGreetText(name ?? "Micros");
            return result;
        }
    }
}
