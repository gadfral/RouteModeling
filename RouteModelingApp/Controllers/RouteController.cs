using Microsoft.AspNetCore.Mvc;
using RouteModelingApp.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RouteModelingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        // GET: api/<RouteController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        [HttpGet]
        public async Task<List<RouteModel>> Get()
        {
            return new List<RouteModel>()
            {
                new RouteModel()
                {
                    Name = "Путь 1",
                }
            };
        }


        // GET api/<RouteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RouteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RouteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RouteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
