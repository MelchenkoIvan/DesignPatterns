using Patterns.Shared.Entities;

namespace Patterns.Facade;

public interface IUserFacade
{
    public Task<User> GetUserInfo();
}