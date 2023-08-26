using Patterns.Facade;
using Patterns.Shared.Entities;

namespace PatternsTests;

public class FacadeTests
{
    private readonly IUserFacade _userFacade;

    public FacadeTests()
    {
        _userFacade = new UserFacade();
    }
    
    [Fact]
    public async Task Facade_should_return_specific_user()
    {
        var userInfo = await _userFacade.GetUserInfo();
        userInfo.Id.Should().Be(User.DefaultUser.Id);
        userInfo.Name.Should().Be(User.DefaultUser.Name);
    }
}