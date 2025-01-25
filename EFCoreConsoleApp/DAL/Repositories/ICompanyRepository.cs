using EFCoreConsoleApp.DAL.Entities;

namespace EFCoreConsoleApp.DAL.Repositories;

public interface ICompanyRepository
{
    Task<List<Company>> GetCompaniesAsync();
}