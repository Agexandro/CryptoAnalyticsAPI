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
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users =  await _userService.GetAsyncAll();
            return Ok(users);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _userService.GetAsync(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<long>> PostUser([FromBody] User user)
        {
            var result = await _userService.CreateAsync(user);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> PutUser([FromBody] User user)
        {
            var result = await _userService.UpdateAsync(user);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            var result = await _userService.DeleteAsync(id);
            return Ok(result);
        }
    }
}