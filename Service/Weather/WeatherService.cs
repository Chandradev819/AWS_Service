using AWS_Service.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AWS_Service.Service.Weather
{
    public class WeatherService : IWeather
    {
        private readonly HttpClient httpClient;
        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }
        public async Task<Root> GetWeatherdata(WeatherInput objInput)
        {
            string apiId = Environment.GetEnvironmentVariable("ApiId");
            string apiURL = $"https://api.openweathermap.org/data/2.5/weather?q={objInput.data.CityName}&appid={apiId}";
            var result = await httpClient.GetFromJsonAsync<Root>(apiURL);
            return result;
        }
    }
}
