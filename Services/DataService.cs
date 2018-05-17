using System;
using System.Collections.Generic;
using System.Linq;
using DotnetApp.Interfaces;
using DotnetApp.Models;

namespace DotnetApp.Services
{
    public class DataService : IDataService
    {
        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}