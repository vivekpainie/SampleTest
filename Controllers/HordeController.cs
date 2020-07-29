using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test2.Controllers
{
    public class HordeController : ControllerBase
    {
        private static Dictionary<string, string> _catList = new Dictionary<string, string>();

        public HordeController()
        {

        }

        // GET: api/<HordeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HordeController>/5
        [HttpGet("horde/{cat}")]
        public string Get(string cat)
        {
            if (_catList.ContainsKey(cat))
            {
                return _catList[cat];
            }
            return $"Doesnt Contain {cat}";
        }

        // POST api/<HordeController>
        [HttpPost("horde/{cat}")]
        public string Post(string cat, [FromBody] string sound)
        {
            if (!_catList.ContainsKey(cat))
            {
                _catList[cat] = sound;
            }
            return String.Format("{0} added to the horde!", cat);
        }


        // PUT api/<HordeController>/5
        [HttpPut("{cat}")]
        public void Put(string cat, [FromBody] string value)
        {
        }

        // DELETE api/<HordeController>/5
        [HttpDelete("horde/{cat}")]
        public string Delete(string cat)
        {
            if(_catList.ContainsKey(cat))
            {
                _catList.Remove(cat);
            }

            return String.Format("{0} removed to the horde!", cat);
        }
    }
}
