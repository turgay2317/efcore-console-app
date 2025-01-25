using EFCoreConsoleApp.DAL.Entities;
using EFCoreConsoleApp.DAL.Repositories;

namespace EFCoreConsoleApp.DAL.Services;

public class CompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public async Task<List<Company>> GetAllCompaniesAsync()
    {
        List<Company> companies = await _companyRepository.GetCompaniesAsync();
        return companies;
    }
    
}