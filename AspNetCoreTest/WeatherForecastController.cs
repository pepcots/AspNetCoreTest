using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCoreTest
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Sunny", "Cloudy", "Rainy" };
        }
    }
}