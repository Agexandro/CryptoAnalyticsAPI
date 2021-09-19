using CryptoAnalytics.Api.Services.Interfaces;
using CryptoAnalytics.Api.Repositories;
using CryptoAnalytics.Api.Repositories.Interfaces;
using CryptoAnalytics.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CryptoAnalytics.Api.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _repository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _repository = profileRepository;
        }

        public async Task<List<Profile>> GetAsyncAll()
        {
            var profiles = await _repository.GetAsyncAll();
            return profiles;
        }
        public async Task<Profile> GetAsync(int id)
        {
            var profile = await _repository.GetAsync(id);
            return profile;
        }
        public async Task<long> CreateAsync(Profile profile)
        {
            return 0;
        }
        public async Task<bool> UpdateAsync(Profile profile)
        {
            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            return true;
        }
    }
}