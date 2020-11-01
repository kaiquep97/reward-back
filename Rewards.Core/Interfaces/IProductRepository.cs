using Rewards.Core.Entities;
using System.Collections.Generic;

namespace Rewards.Core.Interfaces
{
    public interface IProductRepository: IQuery<Product>, ICommand<Product>
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId, int pageSize, int pageIndex);
    }

}
