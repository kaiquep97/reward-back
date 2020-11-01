using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.ViewModels
{
    public abstract class PaginationViewModel
    {
        public int? PageSize { get; set; }
        public int? PageIndex { get; set; }
    }
}
