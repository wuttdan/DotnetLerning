using Domain.Entities.Minieai;

namespace Application.Common.Interfaces;

public interface ICacheLovRepository
{
    Task<List<FbbTblListOfValue>?> GetAllAsync(CancellationToken cancellationToken = default);
    Task<List<FbbTblListOfValue>?> GetByNameAsync(string lovName, CancellationToken cancellationToken = default);
    Task<List<FbbTblListOfValue>?> GetFilterAsync(Func<FbbTblListOfValue, bool> predicate, CancellationToken cancellationToken = default);
}
