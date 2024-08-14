using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PepsiCoProjectTimeline.Server.Data.Entities
{
public class ProjectTimeline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ProjectName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string ResponsibleGroup { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TaskName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string ProjectManager { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string ProjectManagerEmail { get; set; } = string.Empty;

        [Required]
        public DateTimeOffset StartDate { get; set; }

        [Required]
        public DateTimeOffset EndDate { get; set; }

        [Required]
        [Range(0, 1)]
        public decimal PercentCompletion { get; set; }

        [StringLength(100)]
        public string? MilestoneType { get; set; }
    }
}