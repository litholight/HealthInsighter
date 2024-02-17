using HealthInsighter.Core.Models;

namespace HealthInsighter.Core.Interfaces
{
    public interface IHealthEventService
    {
        Task<IEnumerable<HealthEvent>> GetAllEventsAsync();
        Task<HealthEvent> GetEventByIdAsync(Guid id);
        Task<HealthEvent> CreateEventAsync(HealthEvent healthEvent);
        Task UpdateEventAsync(HealthEvent healthEvent);
        Task DeleteEventAsync(Guid id);
    }
}
