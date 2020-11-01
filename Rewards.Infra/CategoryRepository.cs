using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Infra
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public Category Get(int id)
        {
            return _context.Category.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Category item)
        {
            _context.Category.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Category> List()
        {
            return _context.Category.ToList();
        }

        public void Update(Category item)
        {
            _context.Category.Update(item);
            _context.SaveChanges();
        }
    }
}
