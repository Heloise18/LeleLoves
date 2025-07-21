using Microsoft.EntityFrameworkCore;
using LeleLoves.Models;
using LeleLoves.Services;
namespace LeleLove.Implementations;

public class EFUsuarioRepository(LeleLovesDbContext ctx) : IUserRepository
{
    public async Task Create(User user)
    {
        ctx.Users.Add(user);
        await ctx.SaveChangesAsync();
    }

    public async Task<Guid?> Login(string name, string password)
    {
        throw new Exception();
    }

    public async Task<User?> Search(Guid id)
    {
       return await ctx.Users
        .FirstOrDefaultAsync(u => u.Id == id);
    }
} 