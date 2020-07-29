using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test2.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CatController : ControllerBase
    {
        // GET: api/<CatController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<CatController>/5
        [HttpGet("cat")]
        public string Get(string cat)
        {
            switch (cat)
            {
                case "bill":
                    return $"Meow{cat}";
                    break;
                case "mill":
                    return $"Purr{cat}";
                    break;
                default:
                    return "MeowMeow";
                    break;
            }
        }

        // POST api/<CatController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
