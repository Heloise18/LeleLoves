using Microsoft.EntityFrameworkCore;
using LeleLoves.Models;
using LeleLoves.Services;
namespace LeleLove.Implementations;

public class EFUsuarioRepository(LeleLovesDbContext ctx) : IUserRepository
{
    public async Task<Guid?> Create(string name, string password)
    {
        var usuario = new User(name, password);
        ctx.Users.Add(usuario);
        await ctx.SaveChangesAsync();
        return usuario.Id;
    }

    public async Task<User?> Search(Guid id)
    {
       return await ctx.Users
        .FirstOrDefaultAsync(u => u.Id == id);
    }
} 