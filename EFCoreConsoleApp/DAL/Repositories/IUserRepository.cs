using EFCoreConsoleApp.DAL.Entities;

namespace EFCoreConsoleApp.DAL.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetUsersAsync();
}