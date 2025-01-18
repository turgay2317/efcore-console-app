using EFCoreConsoleApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly MyDbContext _context;

    public UserRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}