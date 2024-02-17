using HealthInsighter.Core.Models;

namespace HealthInsighter.Core.Interfaces
{
    public interface IHealthEventTypeService
    {
        Task<IEnumerable<HealthEventType>> GetHealthEventTypesAsync();
        Task<HealthEventType> GetHealthEventTypeAsync(Guid eventTypeId);
        Task<HealthEventType> CreateHealthEventTypeAsync(HealthEventType healthEventType);
        Task<HealthEventType> UpdateHealthEventTypeAsync(HealthEventType healthEventType);
        Task DeleteHealthEventTypeAsync(Guid eventTypeId);
    }
}
