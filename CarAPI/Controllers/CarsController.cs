using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{number}")]
        public IEnumerable<Car> Get(int number)
        {
            var rng = new Random();
            return Enumerable.Range(1, number).Select(index => GetCar())
            .ToArray();
        }

        string[] Conditions = { "Excellent", "Good", "Super", "OK", "Bad", "THE BEST", "What Happened?", "Skip It" };
        string[] Makes = { "Ford", "Honda", "Toyota", "Jeep", "Lexus", "Fiat", "GM", "VW", "Suburu" };
        string[] Years = { "1990", "2001", "2002", "2010", "2020", "2022", "2015", "1998", "2000" };

        public Car GetCar()
        {
            return new Car
            {
                Make = Makes[new Random().Next(0, Makes.Length)],
                Condition = Conditions[new Random().Next(0, Conditions.Length)],
                Year = Years[new Random().Next(0, Years.Length)],
            };
        }
    }
}
