using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Core.Interfaces
{
    public interface ICommand<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
    }
}
