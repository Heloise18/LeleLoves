using LeleLoves.Models;
using LeleLoves.Services;
namespace LeleLoves.Services;

public interface IUserRepository
{
    Task<Guid?> Login(string name, string password);
    Task Create(User user);
    Task<User?> Search(Guid id);


}

