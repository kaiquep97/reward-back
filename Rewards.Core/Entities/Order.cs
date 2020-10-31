using Rewards.Core.Enums;

namespace Rewards.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Points { get; set; }
        public OrderStatusEnum Status { get; set; }

    }


}
