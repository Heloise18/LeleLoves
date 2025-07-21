using LeleLoves.Models;
using LeleLoves.Services;

namespace LeleLove.Implementations;

public class EFUsuarioRepository(LeleLovesDbContext ctx) : IUserRepository
{
    public async Task<Guid?> Create(User usuario)
    {
        ctx.User.Add(usuario);
        await ctx.SaveChangesAsync();
        return usuario.Id;
    }

}