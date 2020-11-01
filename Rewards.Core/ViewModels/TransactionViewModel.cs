using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.ViewModels
{
    public class TransactionViewModel
    {
        public int UserId { get; set; }

        public List<int> Products { get; set; }
    }

}
