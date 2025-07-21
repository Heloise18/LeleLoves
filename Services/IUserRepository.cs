using LeleLoves.Models;
using LeleLoves.Services;
namespace LeleLoves.Services;

public interface IUserRepository
{
    Task<User> Create(Guid Id, string Password);
    Task<User> Search(Guid id);


}

