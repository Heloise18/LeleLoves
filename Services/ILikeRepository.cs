using LeleLoves.Models;
using LeleLoves.Services;
namespace LeleLoves.Services;

public interface ILikeRepository
{
    Task<Like> Like(Guid UserLikedID, Guid UserID);
    Task<Like> Match(Guid UserLikedID, Guid UserID);
    Task<Like> Delete(Guid ID);
    
}

