using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }
        public int? TotalPoints { get; set; }
    }

    public class CreateUserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
    }
}
