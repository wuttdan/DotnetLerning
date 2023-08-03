using Domain.Entities.Minieai;

namespace Application.Common.Interfaces;

public interface ICacheLovRepository
{
    Task<FbbTblListOfValue> GetByNameAsync(string lovName, CancellationToken cancellationToken = default);
}
