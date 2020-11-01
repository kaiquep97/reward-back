using Rewards.Core.Entities;
using System;
using System.Linq.Expressions;

namespace Rewards.Core.Interfaces
{
    public interface IUserRepository: IQuery<User>, ICommand<User> 
    {
        User GetWithPontuation(int id);
        User Get(string email, string password);
        User Get(string email);
        User Get(Expression<Func<User, bool>> expression);
    }
}
