using System.Collections.Generic;

namespace DotnetApp
{
    public interface IDataService
    {
        IEnumerable<WeatherForecast> GetWeatherData();
    }
}