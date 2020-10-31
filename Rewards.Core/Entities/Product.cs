using Rewards.Core.Enums;

namespace Rewards.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string Image { get; set; }
        public ProductStatusEnum Status{ get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }


}
