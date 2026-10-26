using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.Models.Entities;

public class ElectionVoterLog
{
    [Key]
    public Guid Id { get; set; }
    
    public Guid ElectionId { get; set; }
    [ForeignKey(nameof(ElectionId))]
    public Election Election { get; set; }
    
    public Guid StudentId { get; set; }
    [ForeignKey(nameof(StudentId))]
    public Student Student { get; set; }
    
    public DateTime VotedAt { get; set; }
    
    public string IpAddress { get; set; } // Ensure only one vote per device
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}