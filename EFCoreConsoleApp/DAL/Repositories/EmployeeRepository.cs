using EFCoreConsoleApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp.DAL.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly MyDbContext _context;

    public EmployeeRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await _context.Users.ToListAsync();
    }
}