using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.ViewModels
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }

    }
}
