using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClassLibrary1
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "ddd";
        }

       
    }
}
