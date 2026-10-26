using Microsoft.EntityFrameworkCore;
using VotingSystem.Models.Entities;

namespace VotingSystem.Models;

public class AppDbContext: DbContext
{
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Election> Elections { get; set; }
    public DbSet<ElectionVoterLog> ElectionVoterLogs { get; set; }
    public DbSet<PartyList> PartyLists { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Vote> Votes { get; set; }
    
    public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Candidate>(entity =>
        {
            entity.HasOne(c => c.Election)
                .WithMany(e => e.Candidates)
                .HasForeignKey(c => c.ElectionId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasOne(c => c.Student)
                .WithMany()
                .HasForeignKey(c => c.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasOne(c => c.Position)
                .WithMany(p => p.Candidates)
                .HasForeignKey(c => c.PositionId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(c => c.PartyList)
                .WithMany(p => p.Candidates)
                .HasForeignKey(c => c.PartyListId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        
        modelBuilder.Entity<Vote>(entity =>
        {
            entity.HasOne(v => v.Election)
                .WithMany(e => e.Votes)
                .HasForeignKey(v => v.ElectionId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasOne(v => v.Position)
                .WithMany()
                .HasForeignKey(v => v.PositionId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(v => v.Candidate)
                .WithMany()
                .HasForeignKey(v => v.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}