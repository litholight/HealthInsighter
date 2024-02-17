namespace HealthInsighter.Core.Models
{
    public class HealthEvent
    {
        public Guid HealthEventId { get; set; }
        public Guid EventTypeId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Notes { get; set; } // Additional details about the event.
    }
}
