using AutoMapper;
using Rewards.Core.Entities;
using Rewards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductViewModel, Product>();
            CreateMap<Product, CreateProductViewModel>();
            CreateMap<UpdateProductViewModel, Product>();
            CreateMap<Product, UpdateProductViewModel>();
        }
    }
}
