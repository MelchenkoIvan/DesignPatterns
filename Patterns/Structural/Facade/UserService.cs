using Patterns.Structural.Facade.Resources;

namespace Patterns.Structural.Facade;

internal static class UserService
{
    public static Task<User> GetUserMainInfo() =>
        Task.FromResult(User.DefaultUser);
}