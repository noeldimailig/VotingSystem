using System.ComponentModel.DataAnnotations;

namespace VotingSystem.Models.Entities;

public class Election
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string AcademicYear { get; set; }
    public ElectionStatus Status  { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public ICollection<Position> Positions { get; set; }
    public ICollection<PartyList> PartyList { get; set; }
    public ICollection<Candidate> Candidates { get; set; }
    public ICollection<ElectionVoterLog> VoterLogs { get; set; }
    public ICollection<Vote> Votes { get; set; }
}

public enum ElectionStatus
{
    DRAFT,
    UPCOMING,
    ACTIVE,
    COMPLETED,
    CANCELED
}