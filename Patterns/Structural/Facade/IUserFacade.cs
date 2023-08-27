using Patterns.Structural.Facade.Resources;

namespace Patterns.Structural.Facade;

public interface IUserFacade
{
    public Task<User> GetUserInfo();
}