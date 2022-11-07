using customily_test_net6.DataAccess;
using CustomilyNETTest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace customily_test_net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pages : ControllerBase
    {
        // GET: api/<Pages>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Pages>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Pages>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Item value)
        {
            try
            {
                context.Items.Add(value);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
            return Ok();
        }

        [HttpPost]
        [Route("api/pages/GetByPosition/")]
        public IHttpActionResult GetByPosition([FromBody] PositionRequest value)
        {
            var context = new AppicationContext();
            var imagesQuery = (from item in context.Items
                               join img in context.Images on item.Id equals img.ItemId
                               where img.X >= value.X && img.Y >= value.Y
                               select item.Title).ToList();

            var textsQuery = (from item in context.Items
                              join txt in context.Texts on item.Id equals txt.ItemId
                              where txt.X >= value.X && txt.Y >= value.Y
                              select item.Title).ToList();

            var result = imagesQuery.Concat(textsQuery);

            return Ok(result.Distinct().ToList());
        }

        // PUT api/<Pages>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Pages>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
