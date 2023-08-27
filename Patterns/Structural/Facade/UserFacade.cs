using Patterns.Structural.Facade.Resources;

namespace Patterns.Structural.Facade;

public class UserFacade : IUserFacade
{
    public async Task<User> GetUserInfo()
    {
        var canReadData = await AuthorizationService.GetAdminAccess();
        if (!canReadData)
            throw new UnauthorizedAccessException();

        var userInfo = await UserService.GetUserMainInfo();
        return userInfo;
    }
}