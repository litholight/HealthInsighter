namespace HealthInsighter.Core.Models
{
    public class MeasurementType
    {
        public Guid MeasurementTypeId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; } // Unit of measurement (e.g., meters, kg, BPM).
    }
}
