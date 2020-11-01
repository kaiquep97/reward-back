using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id);
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId, int? pageSize, int? pageIndex)
        {
            return _productRepository.GetProductsByCategory(categoryId, pageSize ?? 20, pageIndex ?? 1);
        }

        public void Insert(Product item)
        {
            _productRepository.Insert(item);
        }

        public IEnumerable<Product> List()
        {
            return _productRepository.List();
        }

        public void Update(Product item)
        {
            _productRepository.Update(item);
        }

        public void Update(Product productToBeSaved, Product product)
        {
            product.CategoryId = productToBeSaved.CategoryId;
            product.Description = productToBeSaved.Description;
            product.Image = productToBeSaved.Image;
            product.Name = productToBeSaved.Name;
            product.Points = productToBeSaved.Points;
            product.Status = product.Status;

            Update(product);
        }
    }
}
