using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface IPointService
    {
        void UpdatePoints(int userId, int points);
    }
}
