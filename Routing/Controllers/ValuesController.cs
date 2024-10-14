using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// we can multiple urls for single method,
        /// but not same url for multiple methods 
        /// </summary>
        [Route("~/api/get-all")]
        [Route("~/get-all")]
        [Route("~/getall")]
        //[Route("[action]/[controller]")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        [Route("get-all-authors")]
        //[Route("[controller]/[action]")]
        //[Route("[action]/[controller]")]
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

        [Route("books/{id}")]
        [Route("/{id}")]
        public string GetById(int id)
        {
            return $"hello from {id}";
        }

        [Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id,int authorId)
        {
            return $"Hello author address {id} {authorId}";
        }

        [Route("search")]
        public string SearchBooks(int id,int authorId,string name,int price)
        {
            return $"Book Name :{name} id:{id} authorId:{authorId} and Price:{price}";
        }
    }
}
