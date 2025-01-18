using EFCoreConsoleApp.DAL.Entities;
using EFCoreConsoleApp.DAL.Repositories;

namespace EFCoreConsoleApp.DAL.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> GetAllUsers()
    {
        List<User> users = await _userRepository.GetUsersAsync();
        return users;
    }
    
}