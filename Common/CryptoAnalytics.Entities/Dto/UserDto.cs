using CryptoAnalytics.Entities;

namespace CryptoAnalytics.Entities.Dto
{
    public class UserDto : User
    {
        public Profile Profile{get; set;}
        
    }
}