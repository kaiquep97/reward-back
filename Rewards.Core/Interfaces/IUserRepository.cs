using Rewards.Core.Entities;

namespace Rewards.Core.Interfaces
{
    public interface IUserRepository: IQuery<User>, ICommand<User> 
    {
        User Get(string email, string password);
        User Get(string email);
    }
}
