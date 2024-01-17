namespace ELMSWebAPI.Models;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public long Id { get; set; }
    [StringLength(75)]
    public string? EmployeeName { get; set; }
     [StringLength(75)]
    public string? EmployeeId { get; set; }
   [StringLength(75)]
    public string? Password { get; set; }
    public bool IsAdmin { get; set; }

}