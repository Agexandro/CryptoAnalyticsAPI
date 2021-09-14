using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpGet("")]
        public List<User> GetUsers()
        {
            return new List<User> { };
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = new User() { Id = 1, FirstName = "Rena", LastName = "Jun" };
            return Ok(user);
        }

        [HttpPost]
        public async Task<User> PostUser([FromBody] User user)
        {
            user.Id = 666;
            return user;
        }

        [HttpPut]
        public async Task<User> PutUser([FromBody] User user)
        {
            user.Id = 333;
            user.FirstName = "Alan";
            return user;
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteUser(int id)
        {
            var result = true;
            return result;
        }
    }
}