using EFCoreConsoleApp.DAL;
using EFCoreConsoleApp.DAL.Repositories;
using EFCoreConsoleApp.DAL.Services;

// Database Initialization and Connection
DbConfigInitalizer.Build();
var context = new MyDbContext();

// Be ensured that database is created already
context.Database.EnsureCreated();
var repository = new UserRepository(context);
var service = new UserService(repository);
var users = await service.GetAllUsers();

users.ForEach(user =>
{
    Console.WriteLine($"{user.Id} {user.Name} {user.Surname}");
});