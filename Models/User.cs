namespace LeleLoves.Models;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string? Description { get; set; }
    public string Password { get; set; }
    public ICollection<Like> Likes { get; set; } = [];
    public ICollection<Like> ReceivedLikes { get; set; } = [];
    
}