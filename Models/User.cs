namespace LeleLoves.Models;

public class User(string name, string password)
{
    public Guid Id { get; set; }
    public string Username { get; set; } = name;
    public string Bio { get; set; }
    public string? Description { get; set; }
    public string Password { get; set; } = password;
    public ICollection<Like> Likes { get; set; } = [];
    public ICollection<Like> ReceivedLikes { get; set; } = [];
    
}