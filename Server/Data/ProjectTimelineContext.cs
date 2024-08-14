using Microsoft.EntityFrameworkCore;
using PepsiCoProjectTimeline.Server.Data.Entities;

namespace PepsiCoProjectTimeline.Server.Data
{
    public class ProjectTimelineContext : DbContext
    {
        public virtual DbSet<ProjectTimeline>? ProjectTimelines { get; set; }

        public ProjectTimelineContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectTimeline>()
                .Property(p => p.PercentCompletion)
                .HasPrecision(3, 2);

            modelBuilder.Entity<ProjectTimeline>()
                .HasCheckConstraint("CK_ProjectTimeline_PercentCompletion", "[PercentCompletion] >= 0 AND [PercentCompletion] <= 1");
        }
    }
}