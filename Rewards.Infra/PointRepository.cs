using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Infra
{
    public class PointRepository : IPointRepository
    {
        private readonly Context _context;

        public PointRepository(Context context)
        {
            _context = context;
        }
        public void Insert(Points item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(Points item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
