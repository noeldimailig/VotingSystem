using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.Models.Entities;

public class Position
{
    [Key]
    public Guid Id { get; set; }
    
    public Guid ElectionId { get; set; }
    
    [ForeignKey((nameof(ElectionId)))]
    public Election Election { get; set; }

    public string Title { get; set; }

    public int DisplayOrder { get; set; }

    public int MaxVotes { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public ICollection<Candidate> Candidates { get; set; }
    public ICollection<Vote> Votes { get; set; }
}