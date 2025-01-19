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
        DbConfigInitalizer.Build();
        optionsBuilder.UseMySql(DbConfigInitalizer.Configuration.GetConnectionString("Conn"), new MySqlServerVersion("8.0"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
         * Id : [Key] [AutoIncrement]
         * Name : [Required]
         * Surname : [Required]
         */
        modelBuilder.Entity<User>().HasKey(user => user.Id);
        modelBuilder.Entity<User>().Property(user => user.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(user => user.Name).IsRequired(true);
        modelBuilder.Entity<User>().Property(user => user.Surname).IsRequired(true);
        base.OnModelCreating(modelBuilder);
    }
}