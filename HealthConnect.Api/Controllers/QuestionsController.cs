using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HealthConnect.Accessor.healthconnectdb;

namespace HealthConnect.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Questions")]
    public class QuestionsController : Controller
    {
        [HttpGet]
        public IActionResult Questions()
        {
            using (var context = new healthconnectdbContext())
            {
                var questions = context.Question.ToList();
                return Ok(questions);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Answer> answers)
        {
            try
            {
                using (var context = new healthconnectdbContext())
                {
                    //null check

                    foreach(var answer in answers)
                    {
                        context.Answer.Add(answer);
                        context.SaveChanges();
                    }
                    context.SaveChanges();

                    return Ok("Success");
                }
            }
            catch (Exception e)
            {
                        return BadRequest($"Server Error {e}");
            }
        }

        //// GET: api/QuestionsController/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/QuestionsController
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/QuestionsController/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
