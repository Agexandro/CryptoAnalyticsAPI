using CryptoAnalytics.Api.Repositories.Interfaces;
using CryptoAnalytics.Entities;
using System.Linq;
using System.Collections.Generic;

namespace CryptoAnalytics.Api.Repositories
{
/*     public class MemoryUserRepository : IUserRepository
    {

        readonly List<User> users;

        public MemoryUserRepository()
        {
            users = new List<User>();
            users.Add(new User() { Id = 1, FirstName = "Rena", LastName = "Jun", LoginName = "RenaJun" });
            users.Add(new User() { Id = 2, FirstName = "Bie" });
        }

        public User Get(int id)
        {
            var user = users.SingleOrDefault(x => x.Id == id);
            return user;
        }
        public User Create(User user)
        {
            users.Add(user);
            return user;
        }
        public User Update(User user)
        {
            int index = users.FindIndex(x => x.Id == user.Id);
            if (index != -1)
            {
                users[index] = user;
            }

            return user;
        }
        public bool Delete(int id)
        {
            users.RemoveAll(x => x.Id == id);
            return true;
        }
    } */
}