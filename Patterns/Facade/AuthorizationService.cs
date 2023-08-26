namespace Patterns.Facade;

internal static class AuthorizationService
{
    public static Task<bool> GetAdminAccess() => Task.FromResult(true);
}