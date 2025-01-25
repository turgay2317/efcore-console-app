using EFCoreConsoleApp.DAL.Entities;

namespace EFCoreConsoleApp.DAL.Repositories;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetEmployeesAsync();
}