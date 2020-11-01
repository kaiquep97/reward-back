﻿using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Infra
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        public User Get(string email, string password)
        {
            return _context.User.Where(x => x.Email.ToLower() == email.ToLower() && x.Password == password.ToLower()).FirstOrDefault();
        }

        public User Get(int id)
        {
            return _context.User.FirstOrDefault(x => x.Id == id);
        }

        public User Get(string email)
        {
            return _context.User.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        public void Insert(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<User> List()
        {
            return _context.User.ToList();
        }

        public void Update(User item)
        {
            _context.User.Update(item);
            _context.SaveChanges();
        }
    }
}
