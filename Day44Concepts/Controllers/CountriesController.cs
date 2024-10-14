using Day44Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day44Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        [BindProperty(SupportsGet = true)]
        public CountryModel Country { get; set; }

        //public string Name { get; set; }
        //public int Population { get; set; }
        //public int Area { get; set; }

        /// <summary>
        /// BindProperty is used to map incoming form data to the public properties.
        /// it is used to for single and complex data types.we can set bindproperty 
        /// to individual fields or we can use BindProperties to all fileds.By default
        /// BindPoperty will not work with HttpGet request so we have to use SupportsGet=true
        /// </summary>
        [HttpGet("")]
        public IActionResult GetCountries()
        {
            return Ok($"Name;{this.Country.Name}" +
                $"Population:{this.Country.Population} Area:{this.Country.Area}");
        }

        [HttpGet("{name}/{area}")]
        public IActionResult GetCountry(string name, int area)
        {
            return Ok($"Name={name}");
        }

        [HttpPost("")]
        public IActionResult AddCountry(CountryModel countryModel)
        {
            return Ok($"Name={countryModel.Name}");
        }

        // <summary>
        /// we can't send the query string values to complex types
        /// to get the values from query string we use fromQuery Attribute.
        /// </summary>
        [HttpPost("add")]
        public IActionResult AddNewCountry([FromQuery] CountryModel country)
        {
            return Ok($"Name={country.Name}");
        }

        /// <summary>
        /// From Route attribute is used to bind the values in Route
        /// it will ignore the values that we are passing in the query string and 
        /// Body 
        /// </summary>
        [HttpPost("{name}/{Population}/{Area}")]
        public IActionResult GetCountry([FromRoute] CountryModel country)
        {
            return Ok($"Name={country.Name}");
        }

        /// <summary>
        /// From Body attribute is used to bind the values from the body
        /// it will ignores the values from query string and route
        /// </summary>
        [HttpPost("{id}")]
        public IActionResult GetId([FromBody] int id)
        {
            return Ok(id);
        }

        /// <summary>
        /// FromForm attribute is used to bind the values from 
        /// form
        /// </summary>
        [HttpPost("form")]
        public IActionResult GetNewCountry([FromForm] CountryModel country)
        {
            return Ok($"Name={country.Name}");
        }
    }
}
