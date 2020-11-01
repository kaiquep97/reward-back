using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Infra
{
    public class UserRepository : IUserRepository
    {

        public User Get(string email, string password)
        {
            var users = new List<User>
            {
                new User { Email = "teste@teste.com", Password = "1234", Name = "Teste" }
            };

            return users.Where(x => x.Email.ToLower() == email.ToLower() && x.Password == password.ToLower()).FirstOrDefault();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(string email)
        {
            var users = new List<User>
            {
                new User { Email = "teste@teste.com", Password = "1234", Name = "Teste" }
            };

            return users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        public void Insert(User item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> List()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
