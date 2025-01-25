using EFCoreConsoleApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreConsoleApp.DAL;

public class MyDbContext : DbContext
{
    public DbSet<Employee> Users { get; set; }
    public DbSet<Company> Companies { get; set; }

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
        modelBuilder.Entity<Employee>().HasKey(user => user.Id);
        modelBuilder.Entity<Employee>().Property(user => user.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Employee>().Property(user => user.Name).IsRequired(true);
        modelBuilder.Entity<Employee>().Property(user => user.Surname).IsRequired(true);
        
        /* The below comment line means has-many relation with fluent api
         * modelBuilder.Entity<Company>().HasMany(x => x.Employees).WithOne(x => x.Company).HasForeignKey(x => x.CompanyId);)
         * company HAS MANY employees WITH ONE company that HAS FOREIGN KEY companyId
         */
        
        base.OnModelCreating(modelBuilder);
    }
}