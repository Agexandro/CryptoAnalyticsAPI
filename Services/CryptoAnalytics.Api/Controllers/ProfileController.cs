using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoAnalytics.Entities;
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
            // TODO: Your code here
            var profiles = await _profileService.GetAsyncAll();

            return profiles;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetAsync(int id)
        {
            // TODO: Your code here
            var profile = await _profileService.GetAsync(id);

            return profile;
        }

    }
}