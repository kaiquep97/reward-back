using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface IQuery<T> where T: class
    {
        IEnumerable<T> List();
        T Get(int id);
    }


}
