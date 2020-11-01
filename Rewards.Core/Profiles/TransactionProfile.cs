using AutoMapper;
using Rewards.Core.Entities;
using Rewards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rewards.Core.Profiles
{
    public class TransactionProfile: Profile
    {
        public TransactionProfile()
        {
            CreateMap<TransactionViewModel, Transaction>()
                .ForMember(t => t.Orders,
                            map => map.MapFrom(x => x.Products.Select(p => new Order { ProductId = p })));
        }
    }
}
