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

        public void Update(User userToBeSaved, User user)
        {
            if (CpfIsAlreadyExists(user.Id, userToBeSaved.Cpf))
                throw new Exception("CPf já cadastrado");

            if (EmailAlreadyExists(user.Id, userToBeSaved.Email))
                throw new Exception("Email já cadastrado");

            user.Cpf = userToBeSaved.Cpf;
            user.Email = userToBeSaved.Email;
            user.Password = userToBeSaved.Password;

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
