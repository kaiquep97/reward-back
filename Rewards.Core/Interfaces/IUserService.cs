using Rewards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface IUserService
    {
        void Update(User userToBeSaved, User user);
    }
}
