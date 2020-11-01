using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Update(int id, User user)
        {
            if (CpfIsAlreadyExists(id, user.Cpf))
                throw new Exception("CPf já cadastrado");

            if (EmailAlreadyExists(id, user.Email))
                throw new Exception("Email já cadastrado");

            _userRepository.Update(user);
        }

        private bool CpfIsAlreadyExists(int id , string cpf)
        {
            return  _userRepository.Get(x => x.Cpf == cpf && x.Id != id) != null;
        }

        private bool EmailAlreadyExists(int id, string email)
        {
            return _userRepository.Get(x => x.Id != id && x.Email == email) != null;
        }
    }
}
