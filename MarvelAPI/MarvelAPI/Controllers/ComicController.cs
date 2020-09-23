using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarvelAPI.Connections;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarvelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        // GET: api/comic/all
        [HttpGet("all")]
        public JsonResult GetAllComic()
        {
            var list = ComicAzure.getAllComics();
            return new JsonResult(list);
        }
        

        // GET api/<ComicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ComicController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
