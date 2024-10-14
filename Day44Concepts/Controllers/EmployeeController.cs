using Day44Concepts.Models;
using Day44Concepts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day44Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public string GetEmployees()
        {
            return "All employees";
        }

        [Route("model")]
        public EmployeeModel GetEmployee()
        {
            return new EmployeeModel() { Id=1,Name="Savar"};
        }

        [Route("list")]
        public List<EmployeeModel> GetEmployeeList()
        {
            return new List<EmployeeModel>
            { new EmployeeModel() { Id = 1, Name = "Sandhya" },
              new EmployeeModel() { Id = 2, Name = "Mani" } };
        }

        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel>
            { new EmployeeModel() { Id = 1, Name = "Sandhya" },
              new EmployeeModel() { Id = 2, Name = "Mani" } });
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { Id = 1, Name = "Sandhya" };
        }

        [HttpGet("name")]
        public IActionResult GetName([FromServices]IProductRepository productRepository)
        {
            var name = productRepository.GetName();
            return Ok(name);
        }
    }
}
