using LeleLoves.Models;
using LeleLoves.Services;
namespace LeleLoves.Services;

public interface IUserRepository
{
    Task<Guid?> Create(string name, string password);
    Task<User?> Search(Guid id);


}

