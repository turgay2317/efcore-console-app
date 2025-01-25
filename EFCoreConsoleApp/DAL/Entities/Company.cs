using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreConsoleApp.DAL.Entities;

[Table("Companies")]
public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = new();
}