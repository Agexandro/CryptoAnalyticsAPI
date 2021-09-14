using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Api.Services.Interfaces;
using CryptoAnalytics.Api.Services;

namespace CryptoAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public List<User> GetUsers()
        {
            return new List<User> { };
        }

        [HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {
            var user = _userService.Get(id);
            return user;
        }

        [HttpPost]
        public async Task<User> PostUser([FromBody] User user)
        {
            _userService.Create(user);
            return user;
        }

        [HttpPut]
        public async Task<User> PutUser([FromBody] User user)
        {
            _userService.Update(user);
            return user;
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteUser(int id)
        {
            var result = _userService.Delete(id);
            return result;
        }
    }
}