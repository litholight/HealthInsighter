using HealthInsighter.Core.Models;

namespace HealthInsighter.Core.Interfaces
{
    public interface IBloodSampleService
    {
        Task<IEnumerable<BloodSample>> GetAllBloodSamplesAsync();
        Task<BloodSample> GetBloodSampleByIdAsync(Guid id);
        Task<BloodSample> CreateBloodSampleAsync(BloodSample bloodSample);
        Task UpdateBloodSampleAsync(BloodSample bloodSample);
        Task DeleteBloodSampleAsync(Guid id);
    }
}
