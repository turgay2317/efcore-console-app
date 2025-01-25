using EFCoreConsoleApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp.DAL.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly MyDbContext _context;

    public CompanyRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<List<Company>> GetCompaniesAsync()
    {
        return await _context.Companies.Include(c => c.Employees).ToListAsync();
    }
}