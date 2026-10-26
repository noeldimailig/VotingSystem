using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.Models.Entities;

public class PartyList
{
    [Key]
    public Guid  Id { get; set; }
    
    public Guid ElectionId { get; set; }
    [ForeignKey(nameof(ElectionId))]
    public Election Election { get; set; }
    
    public string Name { get; set; }
    
    public string Advocacy { get; set; } // Plataporma???
    
    public ICollection<Candidate> Candidates { get; set; }
}