using HealthInsighter.Core.Models;

namespace HealthInsighter.Interfaces
{
    public interface IHealthRecordService
    {
        Task<IEnumerable<HealthRecord>> GetAllHealthRecordsAsync();
        Task<HealthRecord> GetHealthRecordByIdAsync(Guid id);
        Task<HealthRecord> CreateHealthRecordAsync(HealthRecord healthRecord);
        Task UpdateHealthRecordAsync(HealthRecord healthRecord);
        Task DeleteHealthRecordAsync(Guid id);
    }
}
