using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Dto;
using CryptoAnalytics.Api.Services.Interfaces;
using CryptoAnalytics.Api.Services;
using CryptoAnalytics.Entities.Http;

namespace CryptoAnalytics.Api.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("api/[controller]")]

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _userService.GetAsyncAll();
            return Ok(users);
        }

        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<ActionResult<Response<UserDto>>> GetUserDtoAsync(int id)
        {
            var response = new Response<UserDto>();
            try
            {
                var user = await _userService.GetUserDtoAsync(id);
                response.Success = true;
                response.Data = user;

                if (user == null)
                {
                    response.Success = false;
                    response.Errors.Add("The user id was not found.");
                    return NotFound(response);
                }

                return Ok(response);
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Errors.Add(e.Message);
                return response;
            }
        }

        [Route("api/[controller]/login/{loginName}")]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetUserDtoAsync(string loginName)
        {
            var user = await _userService.GetUserDtoAsync(loginName);
            return Ok(user);
        }
        [Route("api/[controller]")]

        [HttpPost]
        public async Task<ActionResult<long>> PostUser([FromBody] User user)
        {
            var result = await _userService.CreateAsync(user);
            return Ok(result);
        }
        [Route("api/[controller]")]

        [HttpPut]
        public async Task<ActionResult<bool>> PutUser([FromBody] User user)
        {
            var result = await _userService.UpdateAsync(user);
            return Ok(result);
        }
        [Route("api/[controller]")]

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteUser(int id)
        {
            var result = await _userService.DeleteAsync(id);
            return Ok(result);
        }
    }
}