using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Infra
{
    public class CommandRepository<TEntity> : ICommand<TEntity> where TEntity:class
    {
        private Context _context;

        public CommandRepository(Context context)
        {
            _context = context;
        }

        public void Insert(TEntity item)
        {
            _context.Set<TEntity>().Add(item);
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
