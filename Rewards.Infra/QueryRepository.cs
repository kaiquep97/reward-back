using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Infra
{
    public class QueryRepository<TEntity> : IQuery<TEntity> where TEntity : class
    {
        private readonly Context _context;

        public QueryRepository(Context context)
        {
            _context = context;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> List()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
