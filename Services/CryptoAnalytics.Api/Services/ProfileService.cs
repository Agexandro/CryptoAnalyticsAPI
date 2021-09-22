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
            var id = await _repository.CreateAsync(profile);
            return id;
        }
        public async Task<bool> UpdateAsync(Profile profile)
        {
            var updated = await _repository.UpdateAsync(profile);
            return updated;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            if (await _repository.ValidateDelete(id) > 0)
            {
                return false;
            }
            var result = await _repository.DeleteAsync(id);

            return result;
        }
    }
}