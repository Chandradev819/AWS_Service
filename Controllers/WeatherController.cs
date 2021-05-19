using AWS_Service.Model;
using AWS_Service.Service.Weather;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;


namespace AWS_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeather _weather;
        private IConfiguration config;
        public WeatherController(IWeather weather, IConfiguration configuration)
        {
            _weather = weather;
            config = configuration;
        }
        // GET: api/<CurrencyController>
        [HttpGet]
        public async Task<Root> Get(WeatherInput weatherInput)
        {
            var result = new Root();
            //string apiKey = config.GetValue<string>("GlobalKeyValue:ApiKey");
            //if (weatherInput.APIKey == apiKey)
            //{
            result = await _weather.GetWeatherdata(weatherInput);
            //}
            return result;
        }

        // POST api/<WeatherController>
        [HttpPost("GetWeatherData")]
        public async Task<Root> GetWeatherData(WeatherInput weatherInput)
        {
           
            var result = new Root();
            result = await _weather.GetWeatherdata(weatherInput);
            return result;

        }
    }
}
