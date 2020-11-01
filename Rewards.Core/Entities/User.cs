using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public int? TotalPoints => Points?.Sum(x => x.Pontuation);
        public virtual ICollection<Points> Points { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public User()
        {
        }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public User(string name, string email, string cpf, DateTime birthDate, string password)
            :this(name, email)
        {
            Cpf = cpf;
            BirthDate = birthDate;
            Password = password;
        }
    }


}
