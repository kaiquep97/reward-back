using AutoMapper;
using Rewards.Core.Entities;
using Rewards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();
            CreateMap<CreateUserViewModel, User>();
            CreateMap<User, CreateUserViewModel>();
        }
    }
}
