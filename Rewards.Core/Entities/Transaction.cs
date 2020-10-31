using System;
using System.Collections.Generic;

namespace Rewards.Core.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }


}
