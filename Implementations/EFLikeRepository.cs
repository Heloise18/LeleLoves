using LeleLoves.Models;
using LeleLoves.Services;

namespace LeleLove.Implementations;

public class EfLikeRepository(LeleLovesDbContext ctx) : ILikeRepository
{
    public Task<Like> Delete(Guid ID)
    {
        throw new NotImplementedException();
    }

    public async Task<Like> Like(Guid UserLikedID, Guid UserID)
    {
        var curtida = new Like
        {
            UserID = UserID,
            UserLikedID = UserLikedID
        };
        ctx.Likes.Add(curtida);
        await ctx.SaveChangesAsync();

        return curtida;
    }

    public async Task<bool> Match(Guid UserLikedID, Guid UserID)
    {
        throw new NotImplementedException();
    }

    public Task<Like> Match(User UserLiked, User User)
    {
        throw new NotImplementedException();
    }
}