using Rewards.Core.Entities;

namespace Rewards.Core.Interfaces
{
    public interface ICategoryRepository : IQuery<Category>, ICommand<Category>
    {
    }

}
