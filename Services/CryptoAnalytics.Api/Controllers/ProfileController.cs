using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Http;
using CryptoAnalytics.Api.Services.Interfaces;
//using CryptoAnalytics.Api.Models;

namespace CryptoAnalytics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {


        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Profile>>> GetAsyncAll()
        {

            var profiles = await _profileService.GetAsyncAll();

            return profiles;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetAsync(int id)
        {

            var profile = await _profileService.GetAsync(id);
            if (profile == null)
            {
                return NotFound();
            }

            return profile;
        }

        [HttpPost]
        public async Task<ActionResult<long>> CreateAsync([FromBody] Profile profile)
        {
            var result = await _profileService.CreateAsync(profile);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateAsync([FromBody] Profile profile)
        {
            var result = await _profileService.UpdateAsync(profile);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Response<bool>>> DeleteAsync(int id)
        {
            var result = await _profileService.DeleteAsync(id);
            var response = new Response<bool> { Success = result };
            if (result == false)
            {
                response.Errors.Add("Profile couldn't be deleted");
                return StatusCode(405,response);
            }

            return Ok(result);
        }


    }
}