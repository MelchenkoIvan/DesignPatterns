namespace Patterns.Structural.Facade.Resources;

public class User
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public static User DefaultUser = new User()
    {
        Id = 1,
        Name = "Bot"
    };
}