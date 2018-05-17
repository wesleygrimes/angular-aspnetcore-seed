using System.Collections.Generic;
using DotnetApp.Models;

namespace DotnetApp.Interfaces
{
    public interface IDataService
    {
        IEnumerable<WeatherForecast> GetWeatherData();
    }
}