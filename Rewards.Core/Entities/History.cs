using Rewards.Core.Enums;
using System;

namespace Rewards.Core.Entities
{
    public class History
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public OrderStatusEnum Status { get; set; }
    }


}
