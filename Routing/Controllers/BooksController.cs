using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return $"hello int :{id}";
        }

        [Route("{id:length(5):alpha}")]
        public string GetByString(string id)
        {
            return $"hello string :{id}";
        }

        [Route("{id:range(100,200)}")]
        public string GetByRange(int id)
        {
            return $"hello Range {id}";
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByRegex(string id)
        {
            return $"hello Regex {id}";
        }
    }
}
