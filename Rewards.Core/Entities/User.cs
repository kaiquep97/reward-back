﻿using System;
using System.Collections.Generic;
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
        public virtual ICollection<Points> Points { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }


}