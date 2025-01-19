using EFCoreConsoleApp.DAL;
using EFCoreConsoleApp.DAL.Repositories;
using EFCoreConsoleApp.DAL.Services;

// Database Initialization and Connection
DbConfigInitalizer.Build();
var context = new MyDbContext();

var repository = new UserRepository(context);
var service = new UserService(repository);
var users = await service.GetAllUsers();

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