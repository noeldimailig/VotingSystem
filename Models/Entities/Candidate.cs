using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.Models.Entities;

public class Candidate
{
    [Key]
    public Guid Id { get; set; }
    
    public Guid ElectionId { get; set; }
    [ForeignKey(nameof(ElectionId))]
    public Election Election { get; set; }
    
    public Guid StudentId { get; set; }
    [ForeignKey(nameof(StudentId))] 
    public Student Student { get; set; }

    public Guid PositionId { get; set; }
    [ForeignKey(nameof(PositionId))]
    public Position Position { get; set; }
    
    public Guid? PartyListId { get; set; }
    [ForeignKey(nameof(PartyListId))]
    public PartyList? PartyList { get; set; }
    
    public string Platform { get; set; }
    public string? Image { get; set; }
    
    public ICollection<Vote> Votes { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
}