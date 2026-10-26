using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.Models.Entities;

public class Vote
{
    [Key]
    public Guid Id { get; set; }
    
    public Guid ElectionId { get; set; }
    [ForeignKey(nameof(ElectionId))]
    public Election Election { get; set; }
    
    public Guid PositionId { get; set; }
    [ForeignKey(nameof(PositionId))]
    public Position Position { get; set; }
    
    public Guid CandidateId { get; set; }
    [ForeignKey(nameof(CandidateId))]
    public Candidate Candidate { get; set; }
    
    public DateTime VotedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}