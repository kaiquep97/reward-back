using Rewards.Core.Entities;

namespace Rewards.Core.Interfaces
{
    public interface IProductRepository: IQuery<Product>, ICommand<Product>
    {
    }

}
