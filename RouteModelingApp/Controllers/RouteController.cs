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
        public RouteModel Get(int id)
        {
            return RouteCalculator.CalculateRoute(new Freight
            {
                Way = new Way
                {
                    From = new Location
                    {
                        Latitude = 1,
                        Longitude = 2,
                    },
                    To = new Location
                    {
                        Longitude = 3,
                        Latitude = 4,
                    }
                },
                Dimensions = new Dimensions
                {
                    Length = 1,
                    Height = 2,
                    Width = 3,
                },
                AutoType = AutoType.Car,
                Valuation = new Valuation
                {
                    AvailabilityOfInsurance = true,
                    CostOfInsurance = 213123,
                    CoveredAmount = 2132,
                }
            }).MapToModel();
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
