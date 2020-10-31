using Rewards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
