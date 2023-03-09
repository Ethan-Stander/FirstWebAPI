using FirstWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("All")]

        public string[]? GetAll(string Language)
            {

            if (Language == null)
            {
                return null;
            }

            else
            {
                WordFactory factory = WordFactory.getInstance();
                WordInterface word = factory.getWordInterface(Language);
                return word.GetAll();
            }
            }
        [HttpGet("AllSorted")]

        public string[]? GetSorted(string Language)
        {

            if (Language == null) { 
            
                return null;
            }

            else
            {
                WordFactory factory = WordFactory.getInstance();
                WordInterface word = factory.getWordInterface(Language);
                return word.GetSorted();
            }
        }


        [HttpGet("One")]
        public string? GetOne(string Language)
        {
            if(Language == null) {

                return null;
            }

            else
            { 

            WordFactory factory = WordFactory.getInstance();
            WordInterface word = factory.getWordInterface(Language);
            return word.GetOne();
            }

        }



    }
}