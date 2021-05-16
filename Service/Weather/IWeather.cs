using AWS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_Service.Service.Weather
{
    public interface IWeather
    {
        Task<Root> GetWeatherdata(WeatherInput objInput);
    }
}
