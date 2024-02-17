namespace HealthInsighter.Core.Models
{
    public class HealthRecord
    {
        public Guid HealthRecordId { get; set; }
        public Guid UserId { get; set; }
        public string RecordType { get; set; }
        public DateTime Timestamp { get; set; }
        public string Value { get; set; } // This can be serialized data for flexibility.
        public string Unit { get; set; }
        public string DataType { get; set; } // Numeric, Text, Complex, etc.
    }
}
