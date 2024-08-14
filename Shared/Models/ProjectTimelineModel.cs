namespace PepsiCoProjectTimeline.Shared.Models
{
    public class ProjectTimelineModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string ResponsibleGroup { get; set; } = string.Empty;
        public string TaskName { get; set; } = string.Empty;
        public string ProjectManager { get; set; } = string.Empty;
        public string ProjectManagerEmail { get; set; } = string.Empty;
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal PercentCompletion { get; set; }
        public string? MilestoneType { get; set; }
    }
}