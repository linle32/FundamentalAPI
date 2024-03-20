using Microsoft.AspNetCore.Mvc;

namespace FundamentalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("HttpGetMethod")]
        public IActionResult Get()
        {
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Summary = Storage.Database.Summaries[Random.Shared.Next(Storage.Database.Summaries.Count)]
            })
            .ToArray());
        }

        [HttpPost("HttpPostMethod")]
        public IActionResult CreateWeatherType([FromBody]string weather)
        {
            Storage.Database.Summaries.Add(weather);
            return Ok();
        }
    }
}