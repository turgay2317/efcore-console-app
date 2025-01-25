using EFCoreConsoleApp.DAL;
using EFCoreConsoleApp.DAL.Repositories;
using EFCoreConsoleApp.DAL.Services;

// Database Initialization and Connection
DbConfigInitalizer.Build();
var context = new MyDbContext();

var companyRepository = new CompanyRepository(context);
var companyService = new CompanyService(companyRepository);
var companies = await companyService.GetAllCompaniesAsync();

companies.ForEach(company =>
{
    Console.WriteLine($"*Company = {company.Id} {company.Name} Employee Count: {company.Employees.Count}");
    
    company.Employees.ForEach(employee =>
    {
        Console.WriteLine($"****Employee = {employee.Name} {employee.Surname} ${employee.Salary}");
    });
});

/*
 
users.ForEach(user =>
{
    Console.WriteLine($"State before updating = {context.Entry(user).State}");
    user.Salary = 100;
    Console.WriteLine($"State after updating = {context.Entry(user).State}");
});

context.SaveChanges();

users.ForEach(user =>
{
    Console.WriteLine($"State after all = {context.Entry(user).State}");
}); 

*/