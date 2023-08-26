using Patterns.Shared.Entities;

namespace Patterns.Facade;

internal static class UserService
{
    public static Task<User> GetUserMainInfo() =>
        Task.FromResult(User.DefaultUser);
}