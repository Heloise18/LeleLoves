namespace LeleLoves.Models;

public class Like
{
    public Guid ID { get; set; }
    public Guid UserID { get; set; }
    public Guid UserLikedID { get; set; }
    
    public User User { get; set; }
    public User UserLiked { get; set; }
}
