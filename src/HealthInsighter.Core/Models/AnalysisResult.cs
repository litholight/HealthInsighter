namespace HealthInsighter.Core.Models
{
    public class AnalysisResult
    {
        public Guid AnalysisResultId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string ResultType { get; set; }
        public string Value { get; set; }
        public string Notes { get; set; }

        // Existing foreign key to HealthRecord
        public Guid? HealthRecordId { get; set; }

        // New: Add a nullable foreign key for HealthEvent
        public Guid? HealthEventId { get; set; } // Nullable to allow for optional relationship

        // Navigation properties
        public HealthRecord HealthRecord { get; set; }

        // New: Navigation property to HealthEvent
        public HealthEvent HealthEvent { get; set; }
    }
}
