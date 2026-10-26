using System.ComponentModel.DataAnnotations;

namespace VotingSystem.Models.Entities;

public class Department
{
    [Key]
    public Guid Id { get; set; }
    public string DepartmentName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}