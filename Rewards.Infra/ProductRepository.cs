using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Infra
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context) 
        {
            _context = context;
        }

        public Product Get(int id)
        {
            return _context.Product.Find(id);
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product item)
        {
            _context.Product.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Product> List()
        {
            return _context.Product.ToList();
        }

        public void Update(Product item)
        {
            _context.Product.Update(item);
            _context.SaveChanges();
        }
    }
}
