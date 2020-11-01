using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using Rewards.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Infra
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Context _context;

        public TransactionRepository(Context context)
        {
            _context = context;
        }

        public Transaction Get(int id)
        {
            return _context.Transaction.Find(id);
        }

        public void Insert(Transaction item)
        {
            _context.Transaction.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Transaction> List()
        {
            return _context.Transaction.ToList();
        }

        public void Update(Transaction item)
        {
            _context.Transaction.Update(item);
            _context.SaveChanges();
        }
    }
}
