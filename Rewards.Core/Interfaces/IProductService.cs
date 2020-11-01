using Rewards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface IProductService: IQuery<Product>, ICommand<Product>
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId, int? pageSize, int? pageIndex);

        IEnumerable<Product> GetProductsPaginated(int? pageSize, int? pageIndex);

        void Update(Product productToBeSaved, Product product);
    }
}
