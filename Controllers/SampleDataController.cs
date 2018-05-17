using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotnetApp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IDataService _dataService;

        public SampleDataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            return _dataService.GetWeatherData();
        }


    }
}
