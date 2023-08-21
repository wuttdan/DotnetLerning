using Domain.Entities.Minieai;

namespace Application.Common.Interfaces;

public interface ICacheRepository<T>
{
    Task<List<T>?> GetAllAsync(CancellationToken cancellationToken = default);
    Task<List<T>?> GetByKeyAsync(string itemKey, string activeFlag = "Y", CancellationToken cancellationToken = default);
    Task<List<T>?> GetFilterAsync(Func<T, bool> predicate, CancellationToken cancellationToken = default);
}


public interface ICacheLovRepository: ICacheRepository<FbbTblListOfValue>
{

}

public interface ICacheValidateRepository : ICacheRepository<FbbTblMappingValidate>
{

}