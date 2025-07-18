namespace LeleLoves.Models;

public class Like
{
    public Guid IDlike { get; set; }
    public bool Liked { get; set; } = false;
    public Guid IdUser { get; }
    List<User> UserLiked = [];
}
