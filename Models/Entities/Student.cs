using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.Models.Entities;

public class Student
{
    [Key]
    public Guid Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string? MiddleName { get; set; }
    
    public string LastName { get; set; }
    
    public string Gender { get; set; }
    public Guid DepartmentId { get; set; }
    
    [ForeignKey((nameof(DepartmentId)))]
    public Department Department { get; set; }
    
    public string YearLevel { get; set; }
    
    public bool IsActive { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}