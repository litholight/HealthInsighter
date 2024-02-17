namespace HealthInsighter.Core.Models
{
    public class BloodSample
    {
        public Guid BloodSampleId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Metrics { get; set; } // JSON string to store various metrics.
    }
}
