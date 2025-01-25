using EFCoreConsoleApp.DAL.Entities;
using EFCoreConsoleApp.DAL.Repositories;

namespace EFCoreConsoleApp.DAL.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<List<Employee>> GetAllEmployeesAsync()
    {
        List<Employee> employees = await _employeeRepository.GetEmployeesAsync();
        return employees;
    }
    
}