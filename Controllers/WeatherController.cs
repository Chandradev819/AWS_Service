using AWS_Service.Model;
using AWS_Service.Service.Weather;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace AWS_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeather _weather;
        public WeatherController(IWeather weather)
        {
            _weather = weather;
        }
        // GET: api/<CurrencyController>
        [HttpGet]
        public async Task<Root> Get(WeatherInput weatherInput)
        {
            var result = new Root();
            if (weatherInput.APIKey == "1bb9bd6ec8fc1ef91dd15e0c456dc193erw567")
            {
                result = await _weather.GetWeatherdata(weatherInput);
            }
            return result;
        }

        // POST api/<WeatherController>
        [HttpPost("GetWeatherData")]
        public async Task<Root> GetWeatherData(WeatherInput weatherInput)
        {
            var result = new Root();
            if (weatherInput.APIKey == "1bb9bd6ec8fc1ef91dd15e0c456dc193erw567")
            {
                result = await _weather.GetWeatherdata(weatherInput);
            }
            return result;

        }
    }
}
