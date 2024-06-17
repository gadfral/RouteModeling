using Microsoft.AspNetCore.Mvc;
using RouteModelingApp.Entities;
using RouteModelingApp.Mapper;
using RouteModelingCore;
using RouteModelingCore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RouteModelingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        [HttpGet]
        public List<RouteModel> Get([FromQuery] GetRouteQuery request)
        {
            return RouteCalculator.CalculateRoutes(request.MapToFreight())
                .Select(x => x.MapToModel())
                .ToList();
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
