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

    Task<Like> ILikeRepository.Match(Guid UserLikedID, Guid UserID)
    {
        throw new NotImplementedException();

    }

}