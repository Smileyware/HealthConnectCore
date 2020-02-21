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
    [Route("api/User")]
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                using (var context = new healthconnectdbContext())
                {
                    var exists = context.User.Where(x => x.Email.ToLower() == user.Email.ToLower()).Any();

                    if(exists)
                    {
                        return BadRequest("User Exists");
                    }
                    var newUser = context.User.Add(user);
                    context.SaveChanges();

                    return Ok(newUser);
                }
            }
            catch (Exception e)
            {
                        return BadRequest($"Server Error {e}");
            }
        }
    }
}
