using Rewards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface ITransactionRepository : IQuery<Transaction>, ICommand<Transaction>
    {
    }
}
