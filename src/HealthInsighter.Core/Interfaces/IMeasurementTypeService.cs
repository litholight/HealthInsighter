using HealthInsighter.Core.Models;

namespace HealthInsighter.Core.Interfaces
{
    public interface IMeasurementTypeService
    {
        Task<IEnumerable<MeasurementType>> GetAllMeasurementTypesAsync();
        Task<MeasurementType> GetMeasurementTypeByIdAsync(Guid id);
        Task<MeasurementType> CreateMeasurementTypeAsync(MeasurementType measurementType);
        Task UpdateMeasurementTypeAsync(MeasurementType measurementType);
        Task DeleteMeasurementTypeAsync(Guid id);
    }
}
