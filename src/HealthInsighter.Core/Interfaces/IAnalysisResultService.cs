using HealthInsighter.Core.Models;

namespace HealthInsighter.Core.Interfaces
{
    public interface IAnalysisResultService
    {
        Task<IEnumerable<AnalysisResult>> GetAllAnalysisResultsAsync();
        Task<AnalysisResult> GetAnalysisResultByIdAsync(Guid id);
        Task<AnalysisResult> CreateAnalysisResultAsync(AnalysisResult analysisResult);
        Task UpdateAnalysisResultAsync(AnalysisResult analysisResult);
        Task DeleteAnalysisResultAsync(Guid id);
    }
}
