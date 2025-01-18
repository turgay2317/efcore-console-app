using EFCoreConsoleApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreConsoleApp.DAL;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MyDbContext()
    {
        
    }
    
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
       
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(DbConfigInitalizer.Configuration.GetConnectionString("Conn"), new MySqlServerVersion("8.0"));
    }
}