using Patterns.Shared.Entities;

namespace Patterns.Facade;

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