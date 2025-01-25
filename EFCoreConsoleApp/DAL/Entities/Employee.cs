using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreConsoleApp.DAL.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    
    public decimal Salary { get; set; }
    
    // Navigation Property
    [ForeignKey("CompanyId")]
    public Company Company { get; set; }
}