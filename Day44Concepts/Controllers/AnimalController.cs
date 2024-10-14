using Day44Concepts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Day44Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private List<AnimalModel> animals = null;

        public AnimalController()
        {
            animals = new List<AnimalModel>()
            {
                 new AnimalModel() {Id=1, Name="Dog" },
                 new AnimalModel() {Id=2, Name="Cat" }
            };
        }

        [Route("",Name = "All")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            //return Accepted("~/api/animal");
            //return AcceptedAtAction("GetAnimals");
            //return AcceptedAtRoute("All");
            return LocalRedirect("~/api/animal");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
             
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok(animals.FirstOrDefault(animal=>animal.Id==id));
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);

            //return Created("~/api/animal/"+animal.Id,animal);
            return CreatedAtAction("GetAnimalById", new { id = animal.Id }, animal);
        }
    }
}
