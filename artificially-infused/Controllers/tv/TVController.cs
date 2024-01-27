using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace artificially_infused.Controllers.tv
{
    [ApiController]
    [Route("[controller]")]
    public class TVController : ControllerBase
    {
        // GET: 
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("code")]
        public Game GetCode()
        {
            // Write your logic here to return a string
            return new Game() { Code = "123" };
        }

        // GET api/<TVController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TVController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TVController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TVController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
