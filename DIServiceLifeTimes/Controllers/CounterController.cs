using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIServiceLifeTimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly IFirstCounter firstCounter;
        private readonly ISecondCounter secondCounter;

        public CounterController(IFirstCounter firstCounter,ISecondCounter secondCounter)
        {
            this.firstCounter = firstCounter;
            this.secondCounter = secondCounter;
        }

        [HttpGet]
        public int Get()
        {
            firstCounter.IncrementAndGet();
            return secondCounter.IncrementAndGet();
        }
    }
}
